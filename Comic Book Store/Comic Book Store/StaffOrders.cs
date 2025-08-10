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
    public partial class StaffOrders : Form
    {
        private BindingSource orderBinding = new BindingSource();
        private BindingSource itemBinding = new BindingSource();
        string orderQuery = "SELECT * FROM Orders";
        string itemQuery = "SELECT * FROM OrderItems";

        public StaffOrders()
        {
            InitializeComponent();
            dataOrders.SelectionChanged += new EventHandler(dataOrders_SelectionChanged);
        }

        private void AllOrders_Load(object sender, EventArgs e)
        {
            if (StaffAccount.getAuth() == "Manager")
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                chkID.Enabled = true;
            }

            //no operations on items table, shown only for staff reference
            //items can be removed via the edit form
            SQLConnect.fillData(dataOrders, orderQuery, orderBinding);
            SQLConnect.fillData(dataItems, itemQuery, itemBinding);
        }

        //shortcut for if staff already know ID of order to be changed
        private void chkID_CheckedChanged(object sender, EventArgs e)
        {
            if (chkID.Checked == true)
            {
                txtID.Enabled = true;
            }
            else
            {
                txtID.Enabled = false;
            }
        }

        private void dataOrders_SelectionChanged(object sender, EventArgs e)
        {
           try
            {
                int index = dataOrders.CurrentRow.Index;
                DataGridViewRow selectedRow = dataOrders.Rows[index];

                if (dataOrders.Rows.Count > 1)
                {
                    Order.ordernum = (int)selectedRow.Cells[0].Value;
                    //set username to selected buyer
                    Account.setUsername(selectedRow.Cells[1].Value.ToString());
                    Order.delivery = selectedRow.Cells[2].Value.ToString();
                    Order.mail = selectedRow.Cells[3].Value.ToString();
                    Order.total = (decimal)selectedRow.Cells[4].Value;
                    Order.paid = selectedRow.Cells[6].Value.ToString();
                    Shop.id= (int)selectedRow.Cells[7].Value;

                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            //for integrity purposes, staff cannot change order number or buyer

            if (chkID.Checked == true)
            {
                Order.ordernum = Int32.Parse(txtID.Text);
                string getDetails = "SELECT * FROM Orders WHERE Order_Num= @num";

                SqlCommand cmd = new SqlCommand(getDetails, SQLConnect.getCon());
                cmd.Parameters.AddWithValue("@id", Order.ordernum);

                SqlDataReader dbr;

                try
                {
                    SQLConnect.getCon().Open();
                    dbr = cmd.ExecuteReader();
                    while (dbr.Read())
                    {
                        Account.setUsername((string)dbr["Buyer"]);
                        Order.delivery = (string)dbr["Delivery_Addr"];
                        Order.mail = (string)dbr["Mail_Service"];
                        Order.total = (decimal)dbr["Total_Cost"];
                        Order.points = (int)dbr["Total_Points"];
                       Shop.id = (int)dbr["Shop"];
                        Order.paid = (string)dbr["Paid_For"];

                    }
                    dbr.Close();

                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);

                }
                SQLConnect.getCon().Close();
            }

            OrderEdit staffOrderEdit = new OrderEdit();
            staffOrderEdit.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (chkID.Checked == true)
            {
                Order.ordernum= Int32.Parse(txtID.Text);

            }
            Order.deleteOrder(dataOrders);
            //refresh tables
            SQLConnect.fillData(dataOrders, orderQuery, orderBinding);
            SQLConnect.fillData(dataItems, itemQuery, itemBinding);
        }
    }
}
