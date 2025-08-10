using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Comic_Book_Store
{
    public partial class Orders : Form
    {
        private BindingSource savedBinding = new BindingSource();
        private BindingSource histBinding = new BindingSource();
        string savedQuery = @"SELECT Order_Num, Delivery_Addr, 
                                Mail_Service, Total_Cost, 
                                Shop FROM Orders WHERE " +
                    "Orders.Buyer = '" + Account.getUsername() + "' AND Paid_For='N';";

        public Orders()
        {
            InitializeComponent();
            this.Load += new EventHandler(Orders_Load);
            dataSaved.SelectionChanged += new EventHandler(dataSaved_SelectionChanged);
        }

        private void Orders_Load(object sender, EventArgs e)
        {

            string historyQuery = @"SELECT Order_Num, Delivery_Addr, 
                                Mail_Service, Total_Cost, 
                                Shop, Date FROM Orders WHERE " +
                                "Orders.Buyer = '" + Account.getUsername() + "' AND Paid_For='Y';";

            SQLConnect.fillData(dataSaved, savedQuery, savedBinding);
            SQLConnect.fillData(dataHistory, historyQuery, histBinding);
            checkEmpty();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //open new form to take in edit details
            OrderEdit editForm = new OrderEdit();
            editForm.ShowDialog();
        }

        private void dataSaved_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                int index = dataSaved.CurrentRow.Index;
                DataGridViewRow selectedRow = dataSaved.Rows[index];

                if (dataSaved.Rows.Count > 1) {
                    Order.ordernum = (int)selectedRow.Cells[0].Value;
                    Order.delivery = selectedRow.Cells[1].Value.ToString();
                    Order.mail = selectedRow.Cells[2].Value.ToString();
                    Order.total = (decimal)selectedRow.Cells[3].Value;
                    Shop.id = (int)selectedRow.Cells[4].Value;
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Order.deleteOrder(dataSaved);
            SQLConnect.fillData(dataSaved, savedQuery, savedBinding);
            checkEmpty();

        }

        void checkEmpty()
        {
            if (dataSaved.Rows.Count == 1)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
        }
    }
}
