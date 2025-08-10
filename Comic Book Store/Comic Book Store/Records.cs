using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comic_Book_Store
{
    public partial class Records : Form
    {
        //both customer and personnel records are shown in the same way
        //and have same controls, so they use the same form and change 
        //appearance based on which button opened it


        private BindingSource genBinding = new BindingSource();

        //password is not selected for security reasons
        string cusQuery = "SELECT Username, Points_Earned, Ad_Pref FROM Accounts";
        string persQuery = "SELECT SN, Authorisation, Salary, Shop FROM StaffAccounts";
        public Records(bool customer)
        {
            InitializeComponent();

            if (customer == true)
            {
                lblRecords.Text = "Customer Records";
                SQLConnect.fillData(dataRecords, cusQuery, genBinding);
            }
            else
            {
                lblRecords.Text = "Staff Records";
                SQLConnect.fillData(dataRecords, persQuery, genBinding);
            }

            if (StaffAccount.getAuth() == "Manager")
            {
                btnDelete.Enabled = true;
            }
                //lamba expression for delete event handler
                //allows handler to use boolean value
                btnDelete.Click += (sender, eventArgs) =>
                {
                    string delete = "";
                    if (customer == true)
                    {
                        delete = "DELETE FROM Accounts WHERE Username = '" + Account.getUsername() + "'";
                        SQLConnect.nonQuery(delete);
                        SQLConnect.fillData(dataRecords, cusQuery, genBinding);
                    }
                    else
                    {
                        delete = "DELETE FROM StaffAccounts WHERE SN = '" + Account.getUsername() + "'";

                        if(Account.getUsername()== StaffAccount.getUsername())
                        {
                            MessageBox.Show("Can't delete your own record! (Did you mean to do that?)");
                        }
                        else {
                            SQLConnect.nonQuery(delete);
                            SQLConnect.fillData(dataRecords, persQuery, genBinding);
                        }
                    }


                };

        }
        

        private void CusRecords_Load(object sender, EventArgs e)
        {
            dataRecords.SelectionChanged += new EventHandler(dataCus_SelectionChanged);
           
        }

        private void dataCus_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int index = dataRecords.CurrentRow.Index;
                DataGridViewRow selectedRow = dataRecords.Rows[index];

                if (dataRecords.Rows.Count > 1)
                {
                    Account.setUsername(selectedRow.Cells[0].Value.ToString());

                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }


        }
    }
}
