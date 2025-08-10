using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Comic_Book_Store
{
    public partial class EditProduct : Form

    {
        protected IEnable CallingForm;

        public EditProduct(IEnable form)
        {
            this.CallingForm = form;
            InitializeComponent();
        }

        private void Modify_Load(object sender, EventArgs e)
        {

            if (this.CallingForm.addEnable == true)
            {
                btnSubmit.Text = "Add new product";
            }
            else
            {
                btnSubmit.Text = "Submit changes";
            }

            txtAddName.Text = Product.itemName;
            boxTypes.Text = Product.type;
            txtAddInfo.Text = Product.info;
            txtPrice.Text = Product.price.ToString("#.00");
            txtStock.Text = Product.stock.ToString();
            txtManu.Text = Product.manu;
            txtPoints.Text = Product.points.ToString();

            boxTypes.Items.Add("Comic book");
            boxTypes.Items.Add("Back issue");
            boxTypes.Items.Add("Video game");
            boxTypes.Items.Add("Board game");
            boxTypes.Items.Add("Figure");
            boxTypes.Items.Add("DVD");
            boxTypes.Items.Add("Poster");
            boxTypes.Items.Add("Costume");
            boxTypes.Items.Add("Other");
        }

        //make sure only numbers are entered
        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"; 
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.

            if (result == System.Windows.Forms.DialogResult.OK)
            {
               Image productImage = Bitmap.FromFile(openFileDialog1.FileName);

                Product.imgData = SQLConnect.imageFile(productImage, Product.imgData);

            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string query = "";

            if (this.CallingForm.addEnable == true)
            {
                query = "INSERT INTO Products VALUES (@name, @type, @info, @image, @stock, @price, @manu, @points)";
            }
            else
            {
                query = @"UPDATE Products SET Item_Name=@name, Item_Type=@type, Info=@info, 
                    Picture = @image, Stock= @stock, Price= @price, Manufacturer= @manu, VIP_Points= @points WHERE Item_ID=" + Product.itemID;
            }

            try
            {
               

                SQLConnect.getCon().Open();
                SqlCommand cmd = new SqlCommand(query, SQLConnect.getCon());
                cmd.Parameters.AddWithValue("@name", txtAddName.Text);
                cmd.Parameters.AddWithValue("@type", boxTypes.Text);
                cmd.Parameters.AddWithValue("@info", txtAddInfo.Text);
                cmd.Parameters.AddWithValue("@image", Product.imgData);
                cmd.Parameters.AddWithValue("@stock", Int32.Parse(txtStock.Text));
                cmd.Parameters.AddWithValue("@price", System.Convert.ToDecimal(txtPrice.Text));
                cmd.Parameters.AddWithValue("@manu", txtManu.Text);
                cmd.Parameters.AddWithValue("@points", Int32.Parse(txtPoints.Text));
                cmd.ExecuteNonQuery();

                MessageBox.Show("Query successful", "Success", MessageBoxButtons.OK);

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);

            }

            SQLConnect.getCon().Close();
            this.Close();
        }
    }
}
