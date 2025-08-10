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
    public partial class Checkout : Form
    {
        protected ITotal CallingForm;

        public Checkout(ITotal form)
        {
            this.CallingForm = form;
            InitializeComponent();
        }

        string tempTable = "DECLARE @last_id INT;" +
                "SET @last_id = SCOPE_IDENTITY(); " +
            "CREATE TABLE TempItems(Order_Num int, Item_ID int);" +
                "INSERT INTO TempItems(Item_ID)(SELECT Item_ID FROM Basket WHERE Username = '" + Account.getUsername() + "');" +
                "UPDATE TempItems SET Order_Num = @last_id;" +
                "INSERT INTO OrderItems SELECT *FROM TempItems; DROP TABLE TempItems;" +
            " DELETE FROM Basket WHERE Username = '" + Account.getUsername() + "';";

        private void Checkout_Load(object sender, EventArgs e)
        {
  
            this.CallingForm.getTotal(lblFinal);
            lblAddress.Text = Shop.address;
            lblPoints.Text = "Points to earn: " + this.CallingForm.points;
            Order.fillMail(boxMail);
      
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //order is saved to both order items and order tables
            //with paid for set to 'n'
            //date is not set until order is paid for
            string saveOrder = @"INSERT INTO Orders VALUES ('" + Account.getUsername() + "', @delivery, @mail, " + this.CallingForm.total + ", "
                + this.CallingForm.points + ", 'N', " + Shop.id + ", NULL); " + tempTable;
                ;
            try
            {

                SqlCommand cmd = new SqlCommand(saveOrder, SQLConnect.getCon());
                cmd.Parameters.AddWithValue("@delivery", txtDelivery.Text);
                cmd.Parameters.AddWithValue("@mail", boxMail.Text);
                SQLConnect.getCon().Open();

                cmd.ExecuteNonQuery();
                
                MessageBox.Show("Order saved! You can edit it in the Orders panel");
                SQLConnect.getCon().Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            this.Close();

        }

        private void chkDelivery_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDelivery.Checked == true)
            {
                txtDelivery.Enabled = true;
                boxMail.Enabled = true;

                if (String.IsNullOrEmpty(txtDelivery.Text))
                {
                    btnPay.Enabled = false;
                }
                else
                {
                    btnPay.Enabled = true;
                }
            }
            else
            {
                txtDelivery.Enabled = false;
                boxMail.Enabled = false;
                //reset total cost
                lblFinal.Text = "Total: £" + this.CallingForm.total.ToString("#.00");
                lblMail.Visible = false;
            }
        }

        private void boxMail_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal shipping= Order.verifyMail(boxMail);
            lblMail.Visible = true;
            lblMail.Text = "Shipping cost: £" + shipping;
            decimal finalCost = this.CallingForm.total + shipping;

            lblFinal.Text = "Total: £" + finalCost.ToString("#.00");
        }

        //ensure payment details are not empty when paying
        private void txtPayment_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPayment.Text))
            {
                btnPay.Enabled = false;
            }
            else {
                btnPay.Enabled = true;
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

            string values = "'" + Account.getUsername() + "', @delivery, @mail, "
                            + this.CallingForm.total + ", " + this.CallingForm.points + ", 'Y', " + Shop.id + ", GetDate()";


            string transaction =
                @"BEGIN TRANSACTION INSERT INTO Orders VALUES (" + values +
                "); UPDATE Accounts SET Points_Earned = Points_Earned + " + this.CallingForm.points + ";" +
                tempTable +  "COMMIT";
            /*full transaction: insert user values into order table
             Set Accounts.Points_Earned to current value plus points earned in this transaction
             Declare a scalar variable to save the last-set primary key (Order Num) for use in OrderItems
             Since a subquery returning multiple values (Item_ID in Basket) cannot be used in an insert with other single values (order num and shop):
                Create new empty temporary table
                Fill this table with Item_IDs from user basket
                Update table columns Order Num and Shop with last_id and saved shop id
                Insert these values into main OrderItems table
                Drop temp table
             Empty basket*/

            try
            {

                SqlCommand cmd = new SqlCommand(transaction, SQLConnect.getCon());

                cmd.Parameters.AddWithValue("@delivery", txtDelivery.Text);
                cmd.Parameters.AddWithValue("@mail", boxMail.Text);
                SQLConnect.getCon().Open();

                cmd.ExecuteNonQuery();

                    MessageBox.Show("Payment successful! Basket total will be updated when window is refreshed.");
                    this.CallingForm.total = 0;
                    this.CallingForm.points = 0;
                    this.Hide();
   
                    //cant reset basket total from here
               
                SQLConnect.getCon().Close();

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }


        }


    }
}
