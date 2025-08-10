using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Comic_Book_Store
{
    static class Shop
    {
        //set default values in case customer doesnt specify store
        public static int id = 1;
        public static string location = "Edinbrugh";
        public static string address = "32 Princes Street";

        
        static public void getDetails(ListBox list, Label loc)
        {
            address= list.Text;

            string getLoc = @"SELECT * FROM Shops WHERE Address = '" + address + "'";

            SqlDataReader dbr;

            try
            {
                SqlCommand cmd = new SqlCommand(getLoc, SQLConnect.getCon());
                SQLConnect.getCon().Open();
                dbr = cmd.ExecuteReader();
                while (dbr.Read())
                {
                    id = (int)dbr["Shop_ID"];
                    location = (string)dbr["Location"];
                    loc.Text = location;

                }
                dbr.Close();

                SQLConnect.getCon().Close();
            }

            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
    }
}
