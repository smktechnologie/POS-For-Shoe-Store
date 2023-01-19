using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
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

        void ClearForm()
        {
            btn_add.Enabled = true;
            btnDelete.Enabled = false;
            btnupdate.Enabled = false;
            txtbx_sal.Clear();
            txtAccID.Clear();
            txtbxbalance.Clear();
            txtbxPhone.Clear();
            txtbx_address.Clear();
            txtbx_aname.Clear();
            cmbbxtype.Enabled = true;
        }

        private void load_data()
        {
            try
            {
                string Query = "select ID,Name,Type,Balance,Address,Phone,Salary from `pos`.`account` where name like '%" + txtbx_aname_search.Text + "%' and Type = '" + cmbbxtypesrch.SelectedItem + "' and isactive=1;";
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
                double balance = 0.0;
                int salary = 0;
                if (cmbbxtype.SelectedItem.ToString() == "Employee")
                {
                    if (!string.IsNullOrWhiteSpace(txtbx_sal.Text))
                        salary = Convert.ToInt32(txtbx_sal.Text);
                    else
                    {
                        MessageBox.Show("Salary cannot be empty");
                        return;
                    }

                }

                if (!string.IsNullOrWhiteSpace(txtbxbalance.Text))
                    balance = Convert.ToInt32(txtbxbalance.Text);



                string Query = "insert into  `pos`.`account`(Name,Type,Phone,Address,Balance,Salary,DateTime) values('" + this.txtbx_aname.Text + "','" + cmbbxtype.SelectedItem + "','" + txtbxPhone.Text + "','" + txtbx_address.Text + "'," + balance.ToString() + "," + salary.ToString() + ",'" + System.DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") + "');";
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
            ClearForm();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                double balance = 0.0;
                int salary = 0;
                if (cmbbxtype.SelectedItem.ToString() == "Employee")
                {
                    if (!string.IsNullOrWhiteSpace(txtbx_sal.Text))
                        salary = Convert.ToInt32(txtbx_sal.Text);
                    else
                    {
                        MessageBox.Show("Salary cannot be empty");
                        return;
                    }

                }

                if (!string.IsNullOrWhiteSpace(txtbxbalance.Text))
                    balance = Convert.ToInt32(txtbxbalance.Text);


                string Query = "update `pos`.`account` set Name='" + txtbx_aname.Text + "' ,Address = '" + txtbx_address.Text + "',Phone = '" + txtbxPhone.Text + "', Balance = " + balance.ToString() +
                    ",Salary = " + salary.ToString() + " where id = " + txtAccID.Text + ";";
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
            ClearForm();
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
            ClearForm();
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
                txtbx_sal.Text = dgrow.Cells[6].Value.ToString();
                cmbbxtype.Enabled = false;
                btn_add.Enabled = false;
                btnupdate.Enabled = true;
                btnDelete.Enabled = true;

            }
        }

        private void Account_Load(object sender, EventArgs e)
        {

        }

        private void cmbbxtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbxtype.SelectedItem.ToString() == "Employee")
                txtbx_sal.Enabled = true;
            else
                txtbx_sal.Enabled = false;
        }

        private void txtbx_sal_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtbxbalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtbxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
