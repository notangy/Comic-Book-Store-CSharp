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

    public interface ITotal
    {
        decimal total { get; set; }
        int points { get; set; }
        void getTotal(Label a);
    }


    public partial class BasketForm : Form, ITotal

    {
        public decimal total { get; set; }
        public int points { get; set;}
        protected IBasket CallingForm;

        public BasketForm(IBasket form)
        {

            this.CallingForm = form;
            InitializeComponent();
        }

        private void Basket_Load(object sender, EventArgs e)
        {
           getTotal(lblTotal);
            //also show selected items cost

            string itemQuery = @"SELECT Basket.Item_ID, Products.Item_Name 
                                FROM Basket INNER JOIN Products ON Basket.Item_ID=Products.Item_ID WHERE Username = '"
                                    + Account.getUsername() + "'";

            SQLConnect.fillList(itemQuery, lstBasket, "Item_Name", Product.itemName);
            checkEmpty();
        }
        
        private void lstBasket_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Product.itemName = lstBasket.Text;

            string costQuery = "SELECT Price, Item_ID, Stock FROM Products WHERE Item_Name= '" + Product.itemName + "'";


            try
            {
                SqlCommand cmd = new SqlCommand(costQuery, SQLConnect.getCon());
                
                    SqlDataReader dbr;
                    SQLConnect.getCon().Open();

              
                dbr = cmd.ExecuteReader();
                    while (dbr.Read())
                    {
                        Product.itemID = (int)dbr["Item_ID"];
                        Product.price = (decimal)dbr["Price"];
                    Product.stock = (int)dbr["Stock"];
                    lblCost.Text = "Item cost: £" + String.Format("{0:0.00}", Product.price);

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

            string removeQuery = "DELETE FROM Basket WHERE Item_ID ='" + Product.itemID + "';" +
                "UPDATE Products SET Stock = " + (Product.stock + 1) + "WHERE Item_ID = " + Product.itemID;;
           SQLConnect.nonQuery(removeQuery);
            lstBasket.Items.Remove(Product.itemName);
            //update total
            getTotal(lblTotal);

            //update basket count in customer form
            this.CallingForm.basketCount--;
            //check that basket is not empty again
           checkEmpty();


            string basketTotal = this.CallingForm.basketCount.ToString();
            this.CallingForm.setLabel(basketTotal);
        }


        public void getTotal(Label labelName)
        {

            string totalQuery = @"SELECT Sum(Products.Price) AS Cost, Sum(Products.VIP_Points) AS Points  
                                    FROM Basket INNER JOIN Products ON Basket.Item_ID = 
                             Products.Item_ID WHERE Username = '"+ Account.getUsername() + "'";
            SqlDataReader dbr;


            try
            {
                SqlCommand cmd = new SqlCommand(totalQuery, SQLConnect.getCon());
                
                    SQLConnect.getCon().Open();

                dbr = cmd.ExecuteReader();
                while (dbr.Read())
                {
                    points = (int)dbr["Points"];
                    total = (decimal)dbr["Cost"];

                    if (dbr["Cost"] != null) //if result is not null
                    {
                        //if user is VIP, give 10 percent discount
                       total = Account.verifyVIP(total);
                        labelName.Text = "Total: £" + total.ToString("#.00");
                    }

                    else
                    {
                        labelName.Text = "Total: £0.00";
                    }

                }
                dbr.Close();

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            SQLConnect.getCon().Close();
        }

        //prevents users from checking out with empty baskets
        //or removing from empty lists
        void checkEmpty()
        {
            if (lstBasket.Items.Count != 0)
            {
                btnCheck.Enabled = true;
                btnRemove.Enabled = true;
            }
            else
            {
                btnCheck.Enabled = false;
                btnRemove.Enabled = false;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //show checkout form
            Checkout check1 = new Checkout(this);
            check1.Show();

        }

    }
    }
