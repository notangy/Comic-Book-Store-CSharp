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
    public partial class Favourites : Form
    {
        protected IBasket CallingForm;

        public Favourites(IBasket form)
        {

            this.CallingForm = form;
            InitializeComponent();
            Product.itemName = lstFav.Text;

        }

        private void Favourites_Load(object sender, EventArgs e)
        {
            string favQuery = @"SELECT Favourites.Item_ID, Products.Item_Name 
                                FROM Favourites INNER JOIN Products ON Favourites.Item_ID=Products.Item_ID WHERE Username = '"
                                    + Account.getUsername() + "'";
            SQLConnect.fillList(favQuery, lstFav, "Item_Name", Product.itemName);

            if (lstFav.Items.Count > 1)
            {
                btnAdd.Enabled = true;
                btnDetails.Enabled = true;
                btnRemove.Enabled = true;
            }
           else {
                btnAdd.Enabled = false;
                btnDetails.Enabled = false;
                btnRemove.Enabled = false;
            }

            checkEmpty();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            //to trim trailing 0s
            string price = String.Format("{0:0.00}", Product.price);

            MessageBox.Show(Product.info + "\n" +
                "Price: " + price + "\n" +
                "Stock: " + Product.stock + "\n" +
                "Manufacturer: " + Product.manu);
            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            bool isDuplicate = Product.duplicate();

            if (isDuplicate != true)
            {
                string addQuery = @"INSERT INTO Basket (Item_ID, Username) 
                                select Products.Item_ID, Accounts.Username  
                                FROM Products, Accounts
                            WHERE Products.Item_Name= '" + Product.itemName + "' AND Accounts.Username = '"
                                + Account.getUsername() + "';" +
                                "UPDATE Products SET Stock = " + (Product.stock - 1) + "WHERE Item_ID = " + Product.itemID; ;

                try
                {
                    SQLConnect.nonQuery(addQuery);

                    MessageBox.Show("Item added successfully");

                    //update basket count in customer form
                    this.CallingForm.basketCount++;
                    string total = this.CallingForm.basketCount.ToString();
                    this.CallingForm.setLabel(total);

                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }
            }
            else
            {
                MessageBox.Show("Sorry, basket cannot contain duplicate items");
            }

        }

        private void lstFav_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product.itemName = lstFav.Text;

            string favQuery = "SELECT * FROM Products WHERE Item_Name= '" + Product.itemName + "'";

            try
            {
                SqlCommand cmd = new SqlCommand(favQuery, SQLConnect.getCon());

                SqlDataReader dbr;
                SQLConnect.getCon().Open();


                dbr = cmd.ExecuteReader();
                while (dbr.Read())
                {

                    Product.itemID = (int)dbr["Item_ID"];
                    Product.info = (string)dbr["Info"];
                    Product.manu = (string)dbr["Manufacturer"];
                    Product.price = (decimal)dbr["Price"];
                    Product.stock = (int)dbr["Stock"];

                }

                dbr.Close();

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            SQLConnect.getCon().Close();


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                string removeQuery =@"DELETE FROM Favourites WHERE Item_ID IN (SELECT Item_ID FROM Products WHERE Products.Item_Name= '" + Product.itemName + "')";

                SQLConnect.nonQuery(removeQuery);
                lstFav.Items.Remove(Product.itemName);

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }

            checkEmpty();

        }

        void checkEmpty()
        {
            if (lstFav.Items.Count != 0)
            {
                btnAdd.Enabled = true;
                btnDetails.Enabled = true;
                btnRemove.Enabled = true;
            }
            else {
                btnAdd.Enabled = false;
                btnDetails.Enabled = false;
                btnRemove.Enabled = false;
            }
        }
    }
}
