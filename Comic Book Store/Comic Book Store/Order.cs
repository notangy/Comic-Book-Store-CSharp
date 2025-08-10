using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Comic_Book_Store
{
    static class Order
    {
        static public int ordernum;
        static public string delivery;
        static public string mail;
        static public decimal total;
        static public int points;

        //used in staff orders form
        static public string paid;

        static public void fillMail(ComboBox box)
        {
            box.Items.Add("Royal Mail Standard");
            box.Items.Add("Royal Mail Next Day");
            box.Items.Add("Private Courier");
        }

        

        static public void deleteOrder(DataGridView data)
        {
            string delete = "DELETE FROM Orders WHERE Order_Num=" + ordernum +
               ";  DELETE FROM OrderItems WHERE Order_Num=" + ordernum;
            SQLConnect.nonQuery(delete);
        }


        static public decimal verifyMail(ComboBox mail)
        {
            decimal shipping = 0m;

            if (mail.Text == "Royal Mail Standard" || Order.mail == "Royal Mail Standard")
            {
                shipping = 2.50m;

            }
            if (mail.Text == "Royal Mail Next Day" || Order.mail == "Royal Mail Next Day")
            {
                shipping = 4.00m;

            }
            if (mail.Text == "Private Courier" || Order.mail == "Private Courier")
            {
                shipping = 1.50m;

            }
            return shipping;
        }

    }

}
