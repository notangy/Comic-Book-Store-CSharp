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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            txtPassword2.PasswordChar = '*';
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            boxPrefs.Items.Add("Batman");
            boxPrefs.Items.Add("Superman");
            boxPrefs.Items.Add("Captain America");
            boxPrefs.Items.Add("Spiderman");

            imgAvatar.Image = Account.avatar;

            int pointsToGo = 100 - Account.points;

            if (pointsToGo <= 0)
            {
                lblVIP.Text = "You have VIP status!";
            }
            else
            {
                lblVIP.Text = "Points until VIP status: " + pointsToGo.ToString();
            }

        }


        private void btnAvatar_Click(object sender, EventArgs e)
        {
            avatarDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            DialogResult result = avatarDialog.ShowDialog(); // Show the dialog.

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                Image newAvatar = Bitmap.FromFile(avatarDialog.FileName);

                Account.avData= SQLConnect.imageFile(newAvatar, Account.avData);

                try
                {
                    SQLConnect.getCon().Open();

                    string updateAv = "UPDATE Accounts SET Avatar= @avatar WHERE Username = '" + Account.getUsername() + "'";
                    string getNewAv = "SELECT Avatar FROM Accounts WHERE Username = '" + Account.getUsername() + "';";

                    SqlCommand cmd = new SqlCommand(updateAv, SQLConnect.getCon());
                    SqlCommand cmd2 = new SqlCommand(getNewAv, SQLConnect.getCon());

                    cmd.Parameters.AddWithValue("@avatar", Account.avData);
                    cmd.ExecuteNonQuery();

                    SqlDataReader dbr;
                    dbr = cmd2.ExecuteReader();

                    while (dbr.Read())
                    {

                        Account.avData = (byte[])dbr["Avatar"];
                        Account.avatar = SQLConnect.getImage(dbr, "Avatar");
                        imgAvatar.Image = Account.avatar;
                    }

                    dbr.Close();

                    SQLConnect.getCon().Close();

                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }

                MessageBox.Show("Avatar changed", "Success!", MessageBoxButtons.OK);

            }

        }

        private void btnPass_Click(object sender, EventArgs e)
        {

            if (txtPassword.Text != txtPassword2.Text)
            {
                txtPassword2.Text = String.Empty;
                MessageBox.Show("Passwords do not match.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                try
                {

                    string passChange = "UPDATE Accounts SET Password = @newPass WHERE Username = '"
                        + Account.getUsername() + "'";

                    SQLConnect.getCon().Open();
                    SqlCommand cmd = new SqlCommand(passChange, SQLConnect.getCon());
                    cmd.Parameters.AddWithValue("@newPass", txtPassword.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK);
                    SQLConnect.getCon().Close();

                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);

                }
            }
        }

        private void btnSavePref_Click(object sender, EventArgs e)
        {

             Account.pref = boxPrefs.Text;

            string updatePref = "UPDATE Accounts SET Ad_Pref= @newPref WHERE Username = '" + Account.getUsername() + "'";

            try { 

            SQLConnect.getCon().Open();
            SqlCommand cmd = new SqlCommand(updatePref, SQLConnect.getCon());
                cmd.Parameters.AddWithValue("@newPref", Account.pref);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Preference saved");

                SQLConnect.getCon().Close();

            }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }

        }

    }
    }

