using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Comic_Book_Store
{
   
    public class Account
    {
        static string username;
        public static int points;
        public static string pref;
        public static Image avatar;
        public static byte[] avData;


        public static void setUsername(string a)
        {
            username = a;

        }
       public static string getUsername()
        {
            return username;

        }
        static public void sanitizeUser(SqlCommand cmd, TextBox username, TextBox password)
        {
            cmd.Parameters.AddWithValue("@user", username.Text);
            cmd.Parameters.AddWithValue("@pass", password.Text);
        }

        static public decimal verifyVIP(decimal price)
        {
            if (points >= 100)
            {
                price = price * 0.9m;
            }

            return price;
        }
    }

}
