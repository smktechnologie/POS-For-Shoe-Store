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
    public partial class ViewTransations : Form
    {
        DataTable Accounts = new DataTable();
        public ViewTransations()
        {
            InitializeComponent();
        }
        private void load_Accounts()
        {
            try
            {
                string Query = "select ID,Name,Balance,Type from `pos`.`account` where isactive=1;";
                MySqlConnection MyConn2 = new MySqlConnection(Program.dbconnectionstring);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                MyAdapter.Fill(Accounts);
                MyConn2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = String.Empty;

                if (chkbxdate.Checked)
                    Query = "select * from `pos`.`accounttransactions` where accountid = " + cmbbxAccount.SelectedValue.ToString() + " and (Datetime >= '" + dtfrom.Value.ToString("yyyy-MM-dd H:mm:ss") + "' and Datetime <= '" + dtTo.Value.ToString("yyyy-MM-dd H:mm:ss") + "');";
                else
                    Query = "select * from `pos`.`accounttransactions` where accountid = " + cmbbxAccount.SelectedValue.ToString() + " order by Datetime desc;";

                MySqlConnection MyConn2 = new MySqlConnection(Program.dbconnectionstring);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dgResults.DataSource = dTable;
                MyConn2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cmbbxtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cmb = (sender as ComboBox);
            if (cmb != null && cmb.SelectedItem != null)
            {
                DataRow[] filteredRows = Accounts.Select("Type = '" + cmb.SelectedItem.ToString() + "'");

                if (filteredRows.Length > 0)
                {
                    DataTable dt = filteredRows.CopyToDataTable();
                    cmbbxAccount.DataSource = dt;
                    cmbbxAccount.ValueMember = "ID";
                    cmbbxAccount.DisplayMember = "Name";
                    btnSearch.Enabled = true;
                }
                else
                {
                    cmbbxAccount.DataSource = null;
                    cmbbxAccount.Items.Clear();
                    cmbbxAccount.Text = "Select Account";
                    btnSearch.Enabled = false;
                }
            }
        }

        private void ViewTransations_Load(object sender, EventArgs e)
        {
            load_Accounts();
        }

        private void cmbbxAccount_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var cmb = (sender as ComboBox);
            if (cmb != null && cmb.SelectedItem != null)
            {
                btnSearch.Enabled = true;
            }
        }

        private void chkbxdate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxdate.Checked)
            {
                dtfrom.Enabled = true;
                dtTo.Enabled = true;
            }
            else
            {
                dtfrom.Enabled = false;
                dtTo.Enabled = false;
            }
        }
    }
}
