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
    public partial class Profits : Form
    {
        private BindingSource profBinding = new BindingSource();

        public Profits()
        {
            InitializeComponent();
        }

        private void Profits_Load(object sender, EventArgs e)
        {
            string query = @"SELECT SUM(Total_Cost) AS Profit, Date FROM Orders WHERE Paid_For='Y'
                             GROUP BY Date
                            ORDER BY Date DESC; ";

            SQLConnect.fillData(dataProfit, query, profBinding);

            DateTime dt = DateTime.Now;
            string today = dt.ToString("yyyyMMdd");

            string countOrders = "SELECT COUNT(Paid_For) FROM Orders WHERE Paid_For='Y' AND Date ='" + today + "'";
            string selectStaff = "SELECT SUM(Salary) FROM StaffAccounts";
            decimal wages = 0m;



            int count = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(countOrders, SQLConnect.getCon());
                SqlCommand cmd2 = new SqlCommand(selectStaff, SQLConnect.getCon());
                SQLConnect.getCon().Open();

                count = (int)cmd.ExecuteScalar();
                wages= ((decimal)cmd2.ExecuteScalar() / 12);

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }

            SQLConnect.getCon().Close();

            lblOrders.Text += " " + count;
            lblStaff.Text += " £" + wages.ToString("#.00");
    }

    }
}
