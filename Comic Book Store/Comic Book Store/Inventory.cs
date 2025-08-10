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

    public interface IEnable
    {
        bool addEnable { get; set; }
    }

    public partial class Inventory : Form, IEnable
    {
        public bool addEnable { get; set; } = false;

        private BindingSource invenBinding = new BindingSource();
        string query = "SELECT * FROM Products";

        public Inventory()
        {
            InitializeComponent();
            dataInven.SelectionChanged += new EventHandler(dataInven_SelectionChanged);
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            //only enable edit options if staff is manager
            if (StaffAccount.getAuth() == "Manager")
            {
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
                chkID.Enabled = true;
            }
            SQLConnect.fillData(dataInven, query, invenBinding);
        }

        private void dataInven_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int index = dataInven.CurrentRow.Index;
                DataGridViewRow selectedRow = dataInven.Rows[index];

                if (dataInven.Rows.Count > 1)
                {
                    Product.itemID = (int)selectedRow.Cells[0].Value;
                    Product.itemName = selectedRow.Cells[1].Value.ToString();
                    Product.type = selectedRow.Cells[2].Value.ToString();
                    Product.info= selectedRow.Cells[3].Value.ToString();
                    Product.imgData = (byte[])selectedRow.Cells[4].Value;
                    Product.stock = (int)selectedRow.Cells[5].Value;
                    Product.price = (decimal)selectedRow.Cells[6].Value;
                    Product.manu = selectedRow.Cells[7].Value.ToString();
                    Product.points = (int)selectedRow.Cells[8].Value;

                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //to add new product, open edit form but set all variables to blank

            Product.itemName = "";
            Product.manu = "";
            Product.price = 0m;
            Product.stock = 0;
            Product.info = "";
            Product.type = "";
            Product.points = 0;

            addEnable = true;

            EditProduct newProduct = new EditProduct(this);
            newProduct.ShowDialog();
        }

        private void chkID_CheckedChanged(object sender, EventArgs e)
        {
            if (chkID.Checked == true)
            {
                txtID.Enabled = true;
                btnAdd.Enabled = false;
            }
            else {
                txtID.Enabled = false;
                btnAdd.Enabled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkID.Checked == true)
                {
                    Product.itemID = (Int32.Parse(txtID.Text));
                    string select = "SELECT * FROM Products WHERE Item_ID= @id";

                    SqlCommand cmd = new SqlCommand(select, SQLConnect.getCon());
                    SqlDataReader dbr;

                    cmd.Parameters.AddWithValue("@id", Product.itemID);



                    SQLConnect.getCon().Open();
                    dbr = cmd.ExecuteReader();

                    while (dbr.Read())
                    {
                        Product.itemName = (string)dbr["Item_Name"];
                        Product.type = (string)dbr["Item_Type"];
                        Product.info = (string)dbr["Info"];
                        Product.imgData = (byte[])dbr["Picture"];
                        Product.manu = (string)dbr["Manufacturer"];
                        Product.price = (decimal)dbr["Price"];
                        Product.stock = (int)dbr["Stock"];
                        Product.points = (int)dbr["VIP_Points"];

                    }
                    dbr.Close();

                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);

            }
            SQLConnect.getCon().Close();
      
            addEnable = false;
            EditProduct editProduct = new EditProduct(this);
            editProduct.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (chkID.Checked == true)
            {
                Product.itemID = Int32.Parse(txtID.Text);

            }
           string delete = "DELETE FROM Products WHERE Item_ID=" + Product.itemID;
            SQLConnect.nonQuery(delete);

            //refresh table
            SQLConnect.fillData(dataInven, query, invenBinding);

        }
    }
}
