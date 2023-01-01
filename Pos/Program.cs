using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos
{
    public class ProductDetails
    {

        public ProductDetails(int _Quantity, double _Price, double _Total, int _RemainingQuantity)
        {
            Quantity = _Quantity;
            Price = _Price;
            Total = _Total;
            RemainingQuantity = _RemainingQuantity;
        }

        public int Quantity;
        public double Price;
        public double Total;
        public int RemainingQuantity;
    }

    internal static class Program
    {
        public static List<int> productsizes = new List<int>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            load_data();
            Login frmlogin = new Login();

            Application.Run(frmlogin);

            if (frmlogin.UserSuccessfullyAuthenticated && frmlogin.IsUserAdmin)
            {
                Application.Run(new Home());
            }
            else if (frmlogin.UserSuccessfullyAuthenticated)
            {
                Application.Run(new HomeUser());
            }
            // Application.Run(new Home());
        }

        private static void load_data()
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=Password@11";
                string Query = "select * from `pos`.`size`;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                foreach (DataRow row in dTable.Rows)
                {
                    productsizes.Add(Convert.ToInt32(row[0]));
                }
                MyConn2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
