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
    public partial class NewAccount : Form
    {
        public NewAccount()
        {
            InitializeComponent();

            txtPassword.PasswordChar = '*';
            txtPassword2.PasswordChar = '*';
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        { 

                if (txtPassword.Text != txtPassword2.Text)
                {
                    txtPassword2.Text = String.Empty;
                    MessageBox.Show("Passwords do not match.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
                else
                {
                    //make sure username is unique
                    string query = "SELECT * FROM Accounts WHERE Username = @userCheck";

                SqlCommand cmd = new SqlCommand(query, SQLConnect.getCon());
                cmd.Parameters.AddWithValue("@userCheck", txtUsername.Text);

                int count = SQLConnect.countOccur(cmd);

                    if (count > 0)
                    {

                        MessageBox.Show("Username is already registered.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                    try
                    {

                        string query2 = "INSERT INTO Accounts (Username, Password, Avatar) VALUES (@user, @pass, @image)";
                        SqlCommand cmd2 = new SqlCommand(query2, SQLConnect.getCon());

                        //set default avatar
                        //initialise byte so program doesnt yell at me
                        byte[] data = { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 };

                        Image defaultAv = Image.FromFile(@"C:\Users\Nicole\Documents\Uni work\Year 2\App Design\Comic Book Store\default.png");
                        data= SQLConnect.imageFile(defaultAv, data);

                        Account.sanitizeUser(cmd2, txtUsername, txtPassword);
                        cmd2.Parameters.AddWithValue("@image", data);
                        SQLConnect.getCon().Open();

                        cmd2.ExecuteNonQuery();

                        MessageBox.Show("New user registered, please log in.", "Success", MessageBoxButtons.OK);
                        this.Hide();

                    }
                    catch (Exception es)
                    {
                        MessageBox.Show(es.Message);

                    }

                    SQLConnect.getCon().Close();
                }
            }
           


        }
        }
    }
