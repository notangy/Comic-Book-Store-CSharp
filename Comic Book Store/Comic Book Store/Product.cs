using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Comic_Book_Store
{
    //static class as a new object is not needed for each product offered
    //class variables are 'placeholders' for database values
    //eliminates need to constantly query database
    static class Product 
    {

        public static int itemID;
        public static string itemName;
        public static string type;
        public static string info;
        public static string manu;
        public static int stock;
        public static decimal price;
        public static byte[] imgData;

        public static int points;


        public static bool duplicate()
        {
            //need to change so duplicate items cant be added
            string selectBasket = "SELECT Item_ID FROM Basket WHERE Username = '" + Account.getUsername() + "'";
            List<int> ids = new List<int>();

            try
            {
                SQLConnect.getCon().Open();
                SqlCommand cmd = new SqlCommand(selectBasket, SQLConnect.getCon());

                SqlDataReader dbr;

                dbr = cmd.ExecuteReader();

                while (dbr.Read()) {

                    ids.Add((int)dbr["Item_ID"]);

                    }

                    SQLConnect.getCon().Close();

                if (ids != null) //to prevent null object reference errors
                {

                    if (ids.Contains(itemID))
                    {

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                else
                {
                    return false;
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }

            return true;
            
        }

    }

    }
