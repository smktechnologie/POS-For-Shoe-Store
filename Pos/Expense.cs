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
    public partial class Expense : Form
    {
        public Expense()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    string Query = "update `pos`.`expense` set isactive= 0 where id = " + txtbx_pid.Text + ";";
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

        private void load_data()
        {
            try
            {

                string Query = "select id,name,amount,description,datetime from `pos`.`expense` where name like '%" + txtbx_name_search.Text + "%' and isactive=1;";
                MySqlConnection MyConn2 = new MySqlConnection(Program.dbconnectionstring);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dg_products.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.
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

                    //This is my insert query in which i am taking input from the user through windows forms
                    string Query = "insert into  `pos`.`expense` (Name,Amount,Description,DateTime) values('" + this.txtbx_pname.Text + "'," + this.txtbxAmount.Text + ",'" + this.txtbx_pdesc.Text + "','" + System.DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") + "');";
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
        bool isValidated()
        {
            bool isvalidate = true;

            if (string.IsNullOrWhiteSpace(txtbx_pname.Text))
            {
                isvalidate = false;
                errprvdr.SetError(this.txtbx_pname, "Expense Name is required.");
            }
            else
            {
                errprvdr.SetError(this.txtbx_pname, String.Empty);
            }

            if (string.IsNullOrWhiteSpace(txtbxAmount.Text))
            {
                isvalidate = false;
                errprvdr.SetError(this.txtbxAmount, "Expense Amount is required.");
            }
            else
            {
                errprvdr.SetError(this.txtbxAmount, String.Empty);
            }

            return isvalidate;
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (isValidated())
            {
                try
                {
                    //This is my insert query in which i am taking input from the user through windows forms
                    string Query = "update `pos`.`expense` set Name='" + txtbx_pname.Text + "' ,Description = '" + txtbx_pdesc.Text + "' ,Amount = " + txtbxAmount.Text + " where id = " + txtbx_pid.Text + ";";
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
        private void dg_products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dgrow = dg_products.Rows[e.RowIndex];
                txtbx_pid.Text = dgrow.Cells[0].Value.ToString();
                txtbx_pname.Text = dgrow.Cells[1].Value.ToString();
                txtbxAmount.Text = dgrow.Cells[2].Value.ToString();
                txtbx_pdesc.Text = dgrow.Cells[3].Value.ToString();
                btnupdate.Enabled = true;
                btnDelete.Enabled = true;
                btn_add.Enabled = false;
            }
        }

        void clear()
        {
            txtbx_pid.Clear();
            txtbx_pdesc.Clear();
            txtbx_pname.Clear();
            txtbxAmount.Clear();
            btnupdate.Enabled = false;
            btnDelete.Enabled = false;
            btn_add.Enabled = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clear();

        }

        private void txtbxAmount_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}