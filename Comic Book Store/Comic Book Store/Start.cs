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
    public partial class Start : Form
    {
      
        public Start()
        {
            InitializeComponent();
            //close any connections left open from previous program run
            SQLConnect.getCon().Close();

        }

        private void btnSign_Click(object sender, EventArgs e)
        {

            string query1 = "SELECT Username FROM Accounts WHERE Username = @user and password = @pass";

            SqlCommand cmd = new SqlCommand(query1, SQLConnect.getCon());
            Account.sanitizeUser(cmd, txtUsername, txtPassword);
            int count= connect(query1, cmd);

            if (count == 1)
            {
                //username correct
                Account.setUsername(txtUsername.Text);

                //only get vip if details are correct
                string getDetails = "SELECT Ad_Pref, Points_Earned, Avatar FROM Accounts WHERE Username = '" + Account.getUsername() + "'";

                try
                {
                    SqlCommand cmd2 = new SqlCommand(getDetails, SQLConnect.getCon());

                    SqlDataReader dbr;
                    SQLConnect.getCon().Open();
                    dbr = cmd2.ExecuteReader();
                    while (dbr.Read())
                    {
                        Image avatar = SQLConnect.getImage(dbr, "Avatar");
                        
                        if (dbr["Avatar"] != null)
                        {
                            Account.avatar = avatar;
                        }
                        //if avatar is not set, select default picture
                        else
                        {
                            
                        }

                        Account.points = (int)dbr["Points_Earned"];
                        Account.pref= (string)dbr["Ad_Pref"];
                    }
                    dbr.Close();

                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }
                SQLConnect.getCon().Close();

                StaffAccount.isStaff = false;
                //hide current form and call customer form

                CustomerForm secondForm = new CustomerForm();
                this.Hide();
                secondForm.ShowDialog();
                this.Close();
            }

            else
            {
                error();
            }

        }

        private void btnSignStaff_Click(object sender, EventArgs e)
        {
            string query = "SELECT SN FROM StaffAccounts WHERE SN = @user AND Password = @pass;";

            SqlCommand cmd = new SqlCommand(query, SQLConnect.getCon());
            Account.sanitizeUser(cmd, txtUsername, txtPassword);
            int count= connect(query, cmd);


            if (count == 1)
            {
                StaffAccount.setUsername(txtUsername.Text);


                //only get auth if details are correct
                string getAuth = "SELECT Authorisation FROM StaffAccounts WHERE SN = '" + StaffAccount.getUsername() + "'";
                try
                {
                    SqlCommand cmd2 = new SqlCommand(getAuth, SQLConnect.getCon());

                    SQLConnect.getCon().Open();
                        
                        StaffAccount.setAuth((string)cmd2.ExecuteScalar());

                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }

                SQLConnect.getCon().Close();

                StaffAccount.isStaff = true;

                StaffForm thirdForm = new StaffForm();
                this.Hide();
                thirdForm.ShowDialog();
                this.Close();
            }

            else
            {
                error();
            }


        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //open new form and add new record to database
            NewAccount createForm = new NewAccount();
            createForm.Show();
        }

        private void error() {
            txtUsername.Text = String.Empty;
            txtPassword.Text = String.Empty;
            MessageBox.Show("Incorrect password or username", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

       int connect(string query, SqlCommand cmd)
        {
           
            int count = 0;

            try
            {
                if (!(txtUsername.Text == string.Empty))
                {
                    if (!(txtPassword.Text == string.Empty))
                    {

                       count= SQLConnect.countOccur(cmd);
                    }
                    else
                    {
                        MessageBox.Show("Please fill in password field");
                    }

                }
                else
                {
                    MessageBox.Show("Please fill in username field");
                }


                    }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);

            }
            return count;
        }


        private void Start_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

  
    }
}
