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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            try
            {

                string Query = "update `pos`.`configurations` set `value` ='" + (chkbx_printRec.Checked ? "1" : "0") + "' where `key` = 'PrintReceipt';";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn2 = new MySqlConnection(Program.dbconnectionstring);
                //This is command class which will handle the query and connection object.
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.

                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " \n " + ex.StackTrace);
            }
            Program.LoadSettings();
            MessageBox.Show("Settings Updated Successfully", "Settingss", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void load_data()
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
                chkbx_printRec.Checked = filteredRows.FirstOrDefault()["Value"].ToString() == "1" ? true : false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " \n " + ex.StackTrace);
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            load_data();
        }
    }
}
