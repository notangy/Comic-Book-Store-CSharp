using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Comic_Book_Store
{
    class SQLConnect
    {
        //stores sql connect data to be used across all forms
        static private string str = "Data Source=.;Initial Catalog=Comic;Integrated Security=True";
        static private SqlConnection con = new SqlConnection(str);
        

        public static SqlConnection getCon()
        {
            return con;
        }

        //Note: all SQL close statements are outside try/catch statments due to connections not closing properly

        public static int countOccur(SqlCommand cmd)
        {
            int count = 0;
            try
            {
                con.Open();
                SqlDataReader dbr;

                dbr = cmd.ExecuteReader();
                //if username and password is found in database, make counter + 1
                while (dbr.Read())
                {
                    count++;
                }
                con.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }

            return count;

        }

        public static void fillList(string query, ListBox list, string column, string item)
        {
            SqlCommand cmd = new SqlCommand(query, SQLConnect.getCon());
            SqlDataReader dbr;
            try
            {
                getCon().Open();
                dbr = cmd.ExecuteReader();
                while (dbr.Read())
                {
                    //fill product text boxes with database entries
                    //and set product class variables to database values
                    item= (string)dbr[column]; //name is coming from database
                    list.Items.Add(item);

                }
                dbr.Close();

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            getCon().Close();

        }

        static public void fillData(DataGridView data, string query, BindingSource source)
        {
            try
            {

                // Create a new data adapter based on the specified query.
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, SQLConnect.getCon());

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand. These are used to
                // update the database.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                source.DataSource = table;


                // finally bind the data to the grid
                data.DataSource = source;

                int totalWidth = 0;

                //Auto Resize the columns to fit the data
                foreach (DataGridViewColumn column in data.Columns)
                {
                    data.Columns[column.Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    int widthCol = data.Columns[column.Index].Width;
                    data.Columns[column.Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    data.Columns[column.Index].Width = widthCol;
                    totalWidth = totalWidth + widthCol;
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        public static void nonQuery(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, getCon());

                getCon().Open();

                cmd.ExecuteNonQuery();

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }

            getCon().Close();
        }

        public static Image getImage(SqlDataReader dbr, string column)
        {
            Image img;
            //code to retrieve image binary data
            byte[] imgData = dbr[column] as byte[] ?? null;
            Byte[] byteBLOBData = new Byte[0];
            byteBLOBData = (Byte[])dbr[column];
            MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
            img = Image.FromStream(stmBLOBData, false, false);
            return img;
        }

        public static byte[] imageFile(Image img, byte[] imgData)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Jpeg);
            byte[] photo_array = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(photo_array, 0, photo_array.Length);
            imgData = photo_array;

            return imgData;
        }
        
    }
}