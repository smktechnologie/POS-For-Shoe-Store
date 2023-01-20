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
    public partial class User : Form
    {
        string selectedusername = "";
        public User()
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

                string Query = "select username,password,isactive,isadmin ,datetime from `pos`.`users` where username like '%" + txtbx_name_search.Text + "%';";
                MySqlConnection MyConn2 = new MySqlConnection(Program.dbconnectionstring);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dg_users.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.
                MyConn2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (isValidated())
            {
                try
                {

                    string Query = "insert into  `pos`.`users`(username,password,isactive,isadmin,DateTime) values('" + this.txtbx_username.Text + "','" + this.txtbxpassword.Text + "'," + (chkbxactive.Checked ? "1" : "0") + ","
                        + (chkbxisadmin.Checked ? "1" : "0") + ",'" + System.DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") + "');";
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
                clear();
            }
        }
        void clear()
        {
            selectedusername = string.Empty;
            txtbx_uid.Clear();
            txtbxpassword.Clear();
            txtbx_username.Clear();
            chkbxactive.Checked = false;
            chkbxisadmin.Checked = false;
            btnupdate.Enabled = false;
            btnDelete.Enabled = false;
            btn_add.Enabled = true;
        }
        bool isValidated()
        {
            bool isvalidate = true;

            if (string.IsNullOrWhiteSpace(txtbx_username.Text))
            {
                isvalidate = false;
                errprvdr.SetError(this.txtbx_username, "User Name is required.");
            }
            else
            {
                errprvdr.SetError(this.txtbx_username, String.Empty);
            }

            if (string.IsNullOrWhiteSpace(txtbxpassword.Text))
            {
                isvalidate = false;
                errprvdr.SetError(this.txtbxpassword, "Password is required.");
            }
            else
            {
                errprvdr.SetError(this.txtbxpassword, String.Empty);
            }

            return isvalidate;
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (isValidated())
            {
                try
                {

                    string Query = "update `pos`.`users` set username='" + txtbx_username.Text + "' ,password = '" + txtbxpassword.Text + "',isactive = " + (chkbxactive.Checked ? "1" : "0") + ",isadmin = " + (chkbxisadmin.Checked ? "1" : "0") + " where username = '" + selectedusername + "';";
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
                clear();
            }
        }

        private void dg_users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dgrow = dg_users.Rows[e.RowIndex];
                selectedusername = dgrow.Cells[0].Value.ToString();
                txtbx_uid.Text = selectedusername;
                txtbx_username.Text = dgrow.Cells[0].Value.ToString();
                txtbxpassword.Text = dgrow.Cells[1].Value.ToString();
                chkbxactive.Checked = dgrow.Cells[2].Value.ToString() == "1" ? true : false;
                chkbxisadmin.Checked = dgrow.Cells[3].Value.ToString() == "1" ? true : false;
                btnupdate.Enabled = true;
                btnDelete.Enabled = true;
                btn_add.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    string Query = "Delete from `pos`.`users` where username = '" + selectedusername + "';";
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
                clear();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
