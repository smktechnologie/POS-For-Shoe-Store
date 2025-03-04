﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
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

        public ProductDetails(string _ProductName, int _Quantity, double _Price, double _Total, int _RemainingQuantity)
        {
            ProductName = _ProductName;
            Quantity = _Quantity;
            Price = _Price;
            Total = _Total;
            RemainingQuantity = _RemainingQuantity;
        }
        public string ProductName;
        public int Quantity;
        public double Price;
        public double Total;
        public int RemainingQuantity;
    }


    public class PurchaseDetails
    {

        public PurchaseDetails(int _Quantity, double _Price, double _Total, int _RemainingQuantity)
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

    public static class Configurations
    {
        public static bool isPrintReceiptOrder = false;
    }


    internal static class Program
    {
        public static string LoggedinUser = string.Empty;
        public static void LoadSettings()
        {

            try
            {
                DataTable dt = new DataTable();
                string Query = "select * from `pos`.`configurations`;";
                MySqlConnection MyConn2 = new MySqlConnection(Program.dbconnectionstring);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                MyConn2.Close();

                DataRow[] filteredRows = dTable.Select("Key = 'PrintReceipt'");
                Configurations.isPrintReceiptOrder = filteredRows.FirstOrDefault()["Value"].ToString() == "1" ? true : false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " \n " + ex.StackTrace);
            }
        }
        public static string dbconnectionstring = string.Empty;
        public static List<int> productsizes = new List<int>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            dbconnectionstring = config.AppSettings.Settings["DBConnectionString"].Value;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            load_data();
            LoadSettings();
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
            //Application.Run(new Stock());
        }

        private static void load_data()
        {
            try
            {

                string Query = "select * from `pos`.`size`;";
                MySqlConnection MyConn2 = new MySqlConnection(Program.dbconnectionstring);
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
                MessageBox.Show(ex.Message + " \n " + ex.StackTrace);
            }
        }
    }
}
