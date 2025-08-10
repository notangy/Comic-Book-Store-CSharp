using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comic_Book_Store
{
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            //retrieve employees full name from database
            lblGreeting.Text = ("Hello, " + StaffAccount.getUsername() + "!");

            string auth = StaffAccount.getAuth();
            if (auth == "Manager")
                {
                    btnCus.Enabled = true;
                btnOrders.Enabled = true;
                btnPers.Enabled = true;
            }
            
        }

        private void btnProfits_Click(object sender, EventArgs e)
        {
            //open form to show order totals
            Profits profForm = new Profits();
            profForm.ShowDialog();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            StaffOrders showOrders = new StaffOrders();
            showOrders.ShowDialog();
            this.Close();
        }


        private void btnInven_Click(object sender, EventArgs e)
        {
            Inventory invenForm = new Inventory();
            invenForm.ShowDialog();
        }

        private void btnCus_Click(object sender, EventArgs e)
        {
            bool customer = true;
            //show customer record form
            Records cusForm = new Records(customer);
            cusForm.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffAccount.setUsername("");
            StaffAccount.setAuth("");

            Start login = new Start();
            login.ShowDialog();
            this.Close();

        }

        private void btnPers_Click(object sender, EventArgs e)
        {
            bool customer = false;
            //show personnel record form
            Records persForm = new Records(customer);
            persForm.ShowDialog();
        }
    }
}
