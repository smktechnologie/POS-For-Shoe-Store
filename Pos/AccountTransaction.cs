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
    public partial class AccountTransaction : Form
    {
        double SelectedBalance = 0.0;
        DataTable Accounts = new DataTable();

        public AccountTransaction()
        {
            InitializeComponent();
        }

        private void AccountTransaction_Load(object sender, EventArgs e)
        {
            load_Accounts();

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


                    DataRow[] filteredRowsacct = Accounts.Select("ID = " + cmbbxAccount.SelectedValue.ToString());
                    txtbxBal.Text = filteredRowsacct[0]["Balance"].ToString();
                    btnSubmit.Enabled = true;
                    SelectedBalance = Convert.ToDouble(txtbxBal.Text);
                }
                else
                {
                    txtbxBal.Text = string.Empty;
                    cmbbxAccount.DataSource = null;
                    cmbbxAccount.Items.Clear();
                    cmbbxAccount.Text = "Select Account";
                    btnSubmit.Enabled = false;
                }
            }

        }

        void clearform()
        {
            txtbxAmount.Clear();
            txtbxBal.Clear();
            txtbxDesc.Clear();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (isValidated())
            {
                insertTransactions();
                updateBalance();
                DialogResult dialogResult = MessageBox.Show("Transaction inserted succcesfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearform();
                Accounts.Clear();
                SelectedBalance = 0.0;
                load_Accounts();
            }
        }

        bool isValidated()
        {
            bool isvalidate = true;

            if (string.IsNullOrWhiteSpace(txtbxAmount.Text))
            {
                isvalidate = false;
                errprvdr.SetError(this.txtbxAmount, "Ammount Name is required.");
            }
            else
            {
                errprvdr.SetError(this.txtbxAmount, String.Empty);
            }

            return isvalidate;
        }


        void updateBalance()
        {
            try
            {
                double NewBalance = SelectedBalance - Convert.ToDouble(txtbxAmount.Text);
                string Query = "update `pos`.`account` set Balance =" + NewBalance + " where id = " + cmbbxAccount.SelectedValue.ToString() + ";";
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


        void insertTransactions()
        {
            try
            {

                string Query = "insert into  `pos`.`accounttransactions`(AccountID,PaidAmount,Description,DateTime) values('" + cmbbxAccount.SelectedValue.ToString() + "'," + this.txtbxAmount.Text + ",'" + txtbxDesc.Text + "','" + System.DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") + "');";
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

        private void cmbbxAccount_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var cmb = (sender as ComboBox);
            if (cmb != null && cmb.SelectedItem != null)
            {
                DataRow[] filteredRowsacct = Accounts.Select("ID = " + cmbbxAccount.SelectedValue.ToString());

                if (filteredRowsacct.Length > 0)
                {
                    txtbxBal.Text = filteredRowsacct[0]["Balance"].ToString();
                    btnSubmit.Enabled = true;
                    SelectedBalance = Convert.ToDouble(txtbxBal.Text);
                }
            }

        }

        private void txtbxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && !string.IsNullOrWhiteSpace((sender as TextBox).Text))
            {
                e.Handled = true;
            }
        }
    }
}
