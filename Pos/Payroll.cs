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
    public partial class Payroll : Form
    {
        DataTable employees = new DataTable();
        public Payroll()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (isValidated())
            {
                insertTransactions();
                LoadData();
                txtbx_amount.Clear();
            }
        }

        bool isValidated()
        {
            bool isvalidate = true;
            if (cmbx_type.SelectedItem == null)
            {
                isvalidate = false;
                errprvdr.SetError(this.cmbx_type, "Please select type.");
            }
            else
            {
                errprvdr.SetError(this.cmbx_type, String.Empty);
            }

            if (string.IsNullOrWhiteSpace(txtbx_amount.Text))
            {
                isvalidate = false;
                errprvdr.SetError(this.txtbx_amount, "Amount is required.");
            }
            else
            {
                errprvdr.SetError(this.txtbx_amount, String.Empty);
            }




            return isvalidate;
        }


        private void load_EmployeeAccounts()
        {
            try
            {

                string Query = "select ID,Name,Salary from `pos`.`account` where Type = 'Employee' and isactive=1;";
                MySqlConnection MyConn2 = new MySqlConnection(Program.dbconnectionstring);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;

                MyAdapter.Fill(employees);
                cmbx_Account.DataSource = employees;
                cmbx_Account.DisplayMember = "Name";
                cmbx_Account.ValueMember = "ID";

                MyConn2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbx_Account_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataRow[] filteredRows = employees.Select("ID = " + cmbx_Account.SelectedValue.ToString());
            txtbx_sal.Text = filteredRows.FirstOrDefault()["Salary"].ToString();
            LoadData();
        }

        void LoadData()
        {
            try
            {
                string Query = String.Empty;


                Query = "select a.Name,at.BillType as Type,at.PaidAmount as Amount,at.Description,at.Datetime from `pos`.`accounttransactions` at, `pos`.`account` a where a.id = at.accountid and  at.accountid = " + cmbx_Account.SelectedValue.ToString() + " order by Datetime desc;";

                MySqlConnection MyConn2 = new MySqlConnection(Program.dbconnectionstring);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;
                MyConn2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void insertTransactions()
        {
            try
            {
                string Query = "insert into  `pos`.`accounttransactions`(AccountID,PaidAmount,BillType,DateTime) values('" + cmbx_Account.SelectedValue.ToString() + "'," + this.txtbx_amount.Text + ",'" + cmbx_type.SelectedItem.ToString() + "','" + System.DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") + "');";
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
        }

        private void Payroll_Load(object sender, EventArgs e)
        {
            load_EmployeeAccounts();
        }

        private void txtbx_amount_KeyPress(object sender, KeyPressEventArgs e)
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