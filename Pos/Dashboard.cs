using iTextSharp.text.rtf.table;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            ReportTransactions f2 = new ReportTransactions();
            f2.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ReportTransactions f2 = new ReportTransactions();
            f2.Show();
            this.Hide();
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            Stock f2 = new Stock();
            f2.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Stock f2 = new Stock();
            f2.Show();
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadPurchaseCount();
            LoadSellCount();
        }


        void LoadPurchaseCount()
        {
            try
            {
                string Query = String.Empty;
                Query = "SELECT sum(NetAmount) FROM `pos`.accounttransactions where BillType='Purchasing' and DATE(Datetime) = '" + System.DateTime.Now.ToString("yyyy-MM-dd") + "';";

                MySqlConnection MyConn2 = new MySqlConnection(Program.dbconnectionstring);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                if (dTable.Rows.Count > 0 && !string.IsNullOrWhiteSpace(dTable.Rows[0][0].ToString()))
                    lblpurchasingamt.Text = dTable.Rows[0][0].ToString();
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        void LoadSellCount()
        {
            try
            {
                string Query = String.Empty;
                Query = "SELECT sum(NetAmount),count(*) FROM `pos`.accounttransactions where BillType='Selling' and DATE(Datetime) = '" + System.DateTime.Now.ToString("yyyy-MM-dd") + "';";

                MySqlConnection MyConn2 = new MySqlConnection(Program.dbconnectionstring);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                if (dTable.Rows.Count > 0 && !string.IsNullOrWhiteSpace(dTable.Rows[0][0].ToString()))
                {
                    lblSellAmount.Text = dTable.Rows[0][0].ToString();
                    lblInvoice.Text = dTable.Rows[0][1].ToString();
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
