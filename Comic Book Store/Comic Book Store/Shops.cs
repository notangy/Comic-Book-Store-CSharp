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
    public partial class Shops : Form
    {
        public Shops()
        {
            InitializeComponent();
        }

        private void Shops_Load(object sender, EventArgs e)
        {

            string query = "SELECT Address FROM Shops";
            SQLConnect.fillList(query, lstShops, "Address", Shop.address);
        }

        private void lstShops_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shop.getDetails(lstShops, lblLocation);

        }

    }
}
