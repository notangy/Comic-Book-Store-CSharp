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
    //interface bypasses need for data binding because it caused issues
    public interface IBasket
    {
        int basketCount { get; set; }
        void setLabel(string a);
    }

    public partial class CustomerForm : Form, IBasket
    {

        public int basketCount { get; set; } = 0;

        public CustomerForm()
        {
            InitializeComponent();
        }

        public void setLabel(string a)
        {
            lblBasket.Text = a;
        }


        private void CustomerForm_Load(object sender, EventArgs e)
        {

            lblGreeting.Text = ("Hello, " + Account.getUsername() + "!");

            //saves basket contents
            string query = "SELECT * FROM Basket WHERE Username= '" + Account.getUsername() + "'";
            SqlCommand cmd = new SqlCommand(query, SQLConnect.getCon());

            basketCount = SQLConnect.countOccur(cmd);
            lblBasket.Text = basketCount.ToString();

            getAd();
            announce();
            addTypes();

        }

        void addTypes()
        {
            //list of product types
            List<string> _items = new List<string>();

            //Add items to product type list
            _items.Add("Comic");
            _items.Add("Back issue");
            _items.Add("Video Game");
            _items.Add("Board Game");
            _items.Add("Figure");
            _items.Add("DVD");
            _items.Add("Poster");
            _items.Add("Costume");
            _items.Add("Other");

            lstTypes.DataSource = _items;

        }

        void getAd()
        {

            //select random ad from advertisement table based on user prefs
            //also show general ads regardless
            string adQuery = @"SELECT TOP 1 Image FROM Advertisements WHERE Pref = '"
                            + Account.pref + "' OR Pref = 'General' ORDER BY NEWID()";
            try
            {
                SqlCommand cmd = new SqlCommand(adQuery, SQLConnect.getCon());
                SqlDataReader dbr;
                SQLConnect.getCon().Open();

                dbr = cmd.ExecuteReader();

                while (dbr.Read())
                {

                    advert1.Image = SQLConnect.getImage(dbr, "Image");

                }
                dbr.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }

            SQLConnect.getCon().Close();

        }

        void announce()
        {
            //announce if favourited item is low on stock
            string lowStock = @"SELECT Favourites.Item_ID, Products.Item_Name 
                                FROM Favourites INNER JOIN Products ON Favourites.Item_ID=Products.Item_ID WHERE Username = '"
              + Account.getUsername() + "' AND Products.Stock < 10";

            List<string> items = new List<string>();

            try
            {
                SqlCommand cmd = new SqlCommand(lowStock, SQLConnect.getCon());
                SqlDataReader dbr;
                SQLConnect.getCon().Open();

                dbr = cmd.ExecuteReader();

                while (dbr.Read())
                {

                    items.Add((string)dbr["Item_Name"]);

                }
                dbr.Close();
            }


            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }

            SQLConnect.getCon().Close();

            //if list is not empty, show message
            if (items.Count!=0)
            {
                var message = string.Join(Environment.NewLine, items);
                MessageBox.Show("The following favourite items are low on stock: " + message, "Warning");
            }

        }

    private void lstTypes_SelectedIndexChanged(object sender, EventArgs e)
    {
        lstProducts.Items.Clear();
        //saves value of current selection as string
        Product.type = lstTypes.Text;

        string productQuery = "SELECT Item_Name FROM Products WHERE Item_Type= '" + Product.type + "'";

        SQLConnect.fillList(productQuery, lstProducts, "Item_Name", Product.itemName);

    }

    private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtInfo.Text = String.Empty;
        txtPrice.Text = String.Empty;
        txtStock.Text = String.Empty;

        string itemName = lstProducts.Text;

        string infoQuery = "SELECT * FROM Products WHERE Item_Name= '" + itemName + "'";

        try
        {
            SqlCommand cmd = new SqlCommand(infoQuery, SQLConnect.getCon());
            SqlDataReader dbr;
            SQLConnect.getCon().Open();

            dbr = cmd.ExecuteReader();

            while (dbr.Read())
            {
                Product.itemID = (int)dbr["Item_ID"];

                Product.info = (string)dbr["Info"];
                Product.manu = (string)dbr["Manufacturer"];
                txtInfo.Text = Product.info + "\r\n" + "Manufacturer: " + Product.manu;
                Product.price = (decimal)dbr["Price"];

                Product.price = Account.verifyVIP(Product.price);

                txtPrice.Text = String.Format("{0:0.00}", Product.price);
                Product.stock = (int)dbr["Stock"];
                txtStock.Text = Product.stock.ToString();

                productImg.Image = SQLConnect.getImage(dbr, "Picture");

            }
            dbr.Close();

        }
        catch (Exception es)
        {
            MessageBox.Show(es.Message);
        }
        SQLConnect.getCon().Close();


        //if product is out of stock, disable adding to basket
        if (Product.stock == 0)
        {
            btnBasket.Enabled = false;
        }
        else
        {
            btnBasket.Enabled = true;
        }
    }

    //add chosen item to basket table
    private void btnBasket_Click(object sender, EventArgs e)
    {
            bool isDuplicate = Product.duplicate();
            if (isDuplicate != true)
            {
                basketCount++;
                lblBasket.Text = basketCount.ToString();
                string addQuery = "INSERT INTO Basket VALUES ('" + Product.itemID + "', '"
                    + Account.getUsername() + "'); UPDATE Products SET Stock = " + (Product.stock - 1) + "WHERE Item_ID = " + Product.itemID;

                SQLConnect.nonQuery(addQuery);
            }
            else
            {
                MessageBox.Show("Sorry, basket cannot contain duplicate items");
            }
    }

    //reset user varirables and close form
    private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Account.setUsername("");
        this.Hide();
        Start login = new Start();
        login.ShowDialog();
        this.Close();

    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
        BasketForm basket = new BasketForm(this);
        basket.ShowDialog();
    }

    private void btnShops_Click(object sender, EventArgs e)
    {
        Shops shopForm = new Shops();
        shopForm.ShowDialog();
    }

    private void btnFav_Click(object sender, EventArgs e)
    {
        //values taken from current values in text boxes
        string favQuery = "INSERT INTO Favourites VALUES ('" + Product.itemID + "', '" + Account.getUsername() + "')";

        SQLConnect.nonQuery(favQuery);

    }

    private void viewAcountToolStripMenuItem_Click(object sender, EventArgs e)
    {
        //show profile form
        Profile profileForm = new Profile();
        profileForm.ShowDialog();
    }

    private void favoritesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        //show favourites form
        Favourites favForm = new Favourites(this);
        favForm.ShowDialog();
    }

    private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
    {
        //show orders form
        Orders orderForm = new Orders();
        orderForm.ShowDialog();

    }
}
}


