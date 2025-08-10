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
    public partial class OrderEdit : Form
    {
        decimal newTotal = 0m;
        public OrderEdit()
        {
            InitializeComponent();

            }

        private void OrderEdit_Load(object sender, EventArgs e)
        {
            if (StaffAccount.isStaff == true)
            {
                lblStaff.Visible = true;
                chkPaidY.Visible = true;
                chkPaidN.Visible = true;
                lstBasket.Enabled = false;
                btnBasket.Enabled = false;
                btnPay.Enabled = false;
            }

            //make sure not to add onto total if mail service isnt changed

            List<int> itemIds = new List<int>();

            string getIDs = "SELECT Item_ID FROM OrderItems WHERE Order_Num= " + Order.ordernum;

            SqlCommand cmd = new SqlCommand(getIDs, SQLConnect.getCon());
            SqlDataReader dbr;
            try
            {
                SQLConnect.getCon().Open();
                dbr = cmd.ExecuteReader();
                while (dbr.Read())
                {
                    itemIds.Add((int)dbr["Item_ID"]);

                }
                dbr.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }


            //loop through list and add each item name to list box
            foreach (var id in itemIds)
            {
                string getNames = "SELECT Item_Name FROM Products WHERE Item_ID= " + id;
                SqlCommand cmd2 = new SqlCommand(getNames, SQLConnect.getCon());
                Product.itemName = (string)cmd2.ExecuteScalar();
                lstItems.Items.Add(Product.itemName);
            }

            SQLConnect.getCon().Close();

            string fillShops = "SELECT Address FROM Shops";
            SQLConnect.fillList(fillShops, lstShops, "Address", Shop.address);
            string fillBask = @"SELECT Basket.Item_ID, Products.Item_Name 
                                FROM Basket INNER JOIN Products ON Basket.Item_ID=Products.Item_ID WHERE Username = '"
                                    + Account.getUsername() + "'";

            SQLConnect.fillList(fillBask, lstBasket, "Item_Name", Product.itemName);

            //if delivery not set
            //radio button defaults to delivery no matter what, very annoying >:(
            if (Order.delivery != "N/A" || Order.delivery != null)
            {

                txtDelivery.Text = Order.delivery;
                Order.fillMail(boxMail);
                boxMail.Text = Order.mail;
                lstShops.Enabled = false;

                rdoDelivery.Checked = true;

            }
            else
             {
             rdoCollection.Checked = true;
                txtDelivery.Text = "N/A";
             this.Enabled = false;
             boxMail.Enabled = false;


             }
            lblTotal.Text = "Total: £" + Order.total.ToString("#.00");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //do not allow deletion if order only has one item
            if (lstItems.Items.Count == 1)
            {
                MessageBox.Show("Orders must contain at least one item. To delete this order, use the Orders form.");
            }
            else
            {


                bool subtract = true;
                setValues(subtract);

                string update = "UPDATE Orders SET Total_Cost = " + Order.total + ", Total_Points = " + Order.points +
                                "; DELETE FROM OrderItems WHERE Item_ID= (SELECT Item_ID FROM Products WHERE Item_Name = '"
                    + Product.itemName + "') AND Order_Num = " + Order.ordernum +";" +
                    "UPDATE Products SET Stock = " + (Product.stock + 1) + "WHERE Item_Name = " + Product.itemName;

                SQLConnect.nonQuery(update);
                lstItems.Items.Remove(Product.itemName);

                lblTotal.Text = "Total: £" + Order.total.ToString("#.00");
            }
        
        }

        private void boxMail_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal shipping = Order.verifyMail(boxMail);

            if (boxMail.Text != Order.mail)
            {
                lblShipping.Visible = true;
                lblShipping.Text = "New shipping cost: £" + shipping.ToString("#.00");

                newTotal = Order.total + shipping;

            }
            else
            {
                lblShipping.Visible = false;
                newTotal = Order.total;
                
            }
            lblTotal.Text = "Total: £" + newTotal.ToString("#.00");
        }

        private void rdoCollection_CheckedChanged(object sender, EventArgs e)
        {
            newTotal = 0;
                if (rdoCollection.Checked == true) 
                {
                    rdoCollection.Checked = true;
                    txtDelivery.Enabled = false;
                    boxMail.Enabled = false;
                    lstShops.Enabled = true;

                //subtract shipping cost from new total
                decimal shipping = Order.verifyMail(boxMail);
                newTotal = newTotal + shipping;
                lblTotal.Text = "Total: £" + (Order.total - newTotal).ToString("#.00");
            }

                else
                {
                txtDelivery.Enabled = true;
                boxMail.Enabled = true;
                lstShops.Enabled = false;
                lblTotal.Text= "Total: £" + Order.total.ToString("#.00");
            }
            
     
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //left empty so it doesnt interfere with normal customer saving
            string paid = "";

            if (StaffAccount.isStaff == true)
            {
                paid = ", Paid_For = '" + Order.paid +"' ";
            }

            if (rdoCollection.Checked == true)
            {
                Order.delivery = "";
                Order.mail = "";
            }
            else
            {
                Order.delivery = txtDelivery.Text;
                Order.mail = boxMail.Text;
            }

            string updateOrder = "UPDATE Orders SET Delivery_Addr = @delivery, Mail_Service = @mail, Total_Cost = " 
                + (Order.total + newTotal) + paid + ", Shop = " + Shop.id + " WHERE Order_Num= " 
                + Order.ordernum;


            try
            {

                SqlCommand cmd = new SqlCommand(updateOrder, SQLConnect.getCon());

                cmd.Parameters.AddWithValue("@delivery", Order.delivery);
                cmd.Parameters.AddWithValue("@mail", Order.mail);

                SQLConnect.getCon().Open();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Order updated!");


            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            SQLConnect.getCon().Close();


        }

        //prevent user with delivery selected from having an empty address
        private void txtDelivery_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDelivery.Text) && rdoDelivery.Checked == true)
            {
                btnSave.Enabled = false;
            }
        }

        private void lstShops_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shop.getDetails(lstShops, lblLocation);
        }

        private void txtPay_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPayment.Text))
            {
                btnPay.Enabled = false;
            }
            else
            {
                btnPay.Enabled = true;
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            string pay = "UPDATE Orders SET Paid_For = 'Y', Date = GetDate() WHERE Order_Num= " + Order.ordernum;

            try
            {

                SqlCommand cmd = new SqlCommand(pay, SQLConnect.getCon());

                SQLConnect.getCon().Open();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Payment complete! Refresh order window to see updated order history");


            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }


            SQLConnect.getCon().Close();
            this.Close();
        }

        private void btnBasket_Click(object sender, EventArgs e)
        {
            bool isDuplicate= Product.duplicate();
            bool subtract = false;

            if (isDuplicate != true) {
                setValues(subtract);

                string add = "INSERT INTO OrderItems VALUES (" + Order.ordernum +
                    ", (SELECT Item_ID FROM Products WHERE Item_Name = '" + Product.itemName + "'))";
                string update = "UPDATE Orders SET Total_Cost = " + Order.total + ", Total_Points =" + Order.points + "WHERE Order_Num = " + Order.ordernum + ";" +
                    "UPDATE Products SET Stock = " + (Product.stock - 1) + "WHERE Item_ID = " + Product.itemID;
                string delete = "DELETE FROM Basket WHERE Item_ID= " + Product.itemID + " AND Username = '" + Account.getUsername() + "'";

                SQLConnect.nonQuery(add);
                SQLConnect.nonQuery(update);
                SQLConnect.nonQuery(delete);

                lstItems.Items.Add(Product.itemName);
                lstBasket.Items.Remove(Product.itemName);
                lblTotal.Text = "Total: £" + Order.total.ToString("#.00");
            }
            else
            {
                MessageBox.Show("Sorry, order cannot contain duplicate items");
            }

        }

        private void lstBasket_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product.itemName = lstBasket.Text;
            btnRemove.Enabled = false;
            btnBasket.Enabled = true;
            getDets();
        }

        //allow staff override in case a customer payment doesnt go through

        // hold the last checked CheckBox
        //make sure only one box is checked at a time
        CheckBox lastChecked;

        private void chkPaidY_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != lastChecked && lastChecked != null) lastChecked.Checked = false;
            lastChecked = activeCheckBox.Checked ? activeCheckBox : null;

            if (chkPaidY.Checked == true)
            {
                chkPaidN.Checked = false;
                Order.paid = "Y";
            }
            else if (chkPaidN.Checked == true)
            {
                chkPaidY.Checked = false;
                Order.paid = "N";
            }
        }

        private void chkPaidN_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != lastChecked && lastChecked != null) lastChecked.Checked = false;
            lastChecked = activeCheckBox.Checked ? activeCheckBox : null;

            if (chkPaidN.Checked == true)
            {
                chkPaidY.Checked = false;
                Order.paid = "N";
            }
            else if (chkPaidY.Checked == true)
            {
                chkPaidN.Checked = false;
                Order.paid = "Y";
            }
        }

        void setValues(bool subtract)
        {
            int userPoints = 0;
            decimal userCost = 0;

            lstItems.Text = Product.itemName;

            //select points and cost from product table
            //subtract from fields on orders table
            string selectUpdate = "SELECT Total_Points, Total_Cost FROM Orders WHERE Order_Num = " + Order.ordernum;

            SqlCommand cmd = new SqlCommand(selectUpdate, SQLConnect.getCon());
            SqlDataReader dbr;
            try
            {
                SQLConnect.getCon().Open();

                dbr = cmd.ExecuteReader();
                while (dbr.Read())
                {

                    userPoints = (int)dbr["Total_Points"];
                    userCost = (decimal)dbr["Total_Cost"];

                }
                dbr.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }

            SQLConnect.getCon().Close();

           Product.price = Account.verifyVIP(Product.price);

            if (subtract == true)
            {
                Order.total = userCost - Product.price;
                Order.points = userPoints - Product.points;
            }

            else
            {
                Order.total = userCost + Product.price;
                Order.points = userPoints + Product.points;
            }
        }

        private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product.itemName = lstItems.Text;
            getDets();
            btnRemove.Enabled = true;
            btnBasket.Enabled = false;
        }

        void getDets()
        {
            string selectItems = "SELECT Item_ID, Stock, Price, VIP_Points FROM Products WHERE Item_Name = '" + Product.itemName + "'";
            SqlCommand cmd = new SqlCommand(selectItems, SQLConnect.getCon());

            SqlDataReader dbr;
            try
            {
                SQLConnect.getCon().Open();
                dbr = cmd.ExecuteReader();
                while (dbr.Read())
                {
                   Product.itemID = (int)dbr["Item_ID"];
                    Product.stock = (int)dbr["Stock"];
                    Product.price = (decimal)dbr["Price"];
                   Product.points = (int)dbr["VIP_Points"];

                }

                dbr.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }

            SQLConnect.getCon().Close();

        }
    }

   
    }
