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
    public partial class Accounts : Form
    {
        public Accounts()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void load_data()
        {
            try
            {
                string Query = "select ID,Name,Type,Balance,Address,Phone from `pos`.`account` where name like '%" + txtbx_aname_search.Text + "%' and Type = '" + cmbbxtypesrch.SelectedItem + "' and isactive=1;";
                MySqlConnection MyConn2 = new MySqlConnection(Program.dbconnectionstring);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dg_account.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.
                MyConn2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "insert into  `pos`.`account`(Name,Type,Phone,Address,Balance,DateTime) values('" + this.txtbx_aname.Text + "','" + cmbbxtype.SelectedItem + "','" + txtbxPhone.Text + "','" + txtbx_address.Text + "'," + txtbxbalance.Text + ",'" + System.DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") + "');";
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
                MessageBox.Show(ex.Message);
            }
            load_data();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {

                string Query = "update `pos`.`account` set Name='" + txtbx_aname.Text + "' ,Address = '" + txtbx_address.Text + "',Phone = " + txtbxPhone.Text + " where id = " + txtAccID.Text + ";";
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
                MessageBox.Show(ex.Message);
            }
            load_data(); 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path

                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "update `pos`.`account` set isactive= 0 where id = " + txtAccID.Text + ";";
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
                MessageBox.Show(ex.Message);
            }
            load_data();
        }

        private void dg_account_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dgrow = dg_account.Rows[e.RowIndex];
                txtAccID.Text = dgrow.Cells[0].Value.ToString();
                txtbx_aname.Text = dgrow.Cells[1].Value.ToString();
                cmbbxtype.SelectedItem = dgrow.Cells[2].Value.ToString();
                txtbxbalance.Text = dgrow.Cells[3].Value.ToString();
                txtbx_address.Text = dgrow.Cells[4].Value.ToString();
                txtbxPhone.Text = dgrow.Cells[5].Value.ToString();

                cmbbxtype.Enabled = false;
                txtbxbalance.Enabled = false;
                btn_add.Enabled = false;

            }
        }

        private void Account_Load(object sender, EventArgs e)
        {

        }
    }
}
