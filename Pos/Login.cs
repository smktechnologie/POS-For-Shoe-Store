using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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
    public partial class Login : Form
    {
        public bool UserSuccessfullyAuthenticated { get; private set; }
        public bool IsUserAdmin { get; private set; }
        public Login()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Tuple<Boolean, Boolean> result = IsUserValid();
            if (result.Item1 && result.Item2)
            {
                UserSuccessfullyAuthenticated = true;
                IsUserAdmin = true;
                Program.LoggedinUser = txtbxUserName.Text;
                this.Close();

            }
            else if (result.Item1)
            {
                UserSuccessfullyAuthenticated = true;
                Program.LoggedinUser = txtbxUserName.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect username or password.");
                txtbxpassword.Clear();
                txtbxUserName.Clear();
            }
        }

        private Tuple<Boolean, Boolean> IsUserValid()
        {

            bool isAuthenticated = false;
            bool isAdmin = false;
            try
            {


                string Query = "select username,isadmin from `pos`.`users` where username = '" + txtbxUserName.Text + "' and password='" + txtbxpassword.Text + "' and isactive=1;";
                MySqlConnection MyConn2 = new MySqlConnection(Program.dbconnectionstring);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                MyConn2.Close();

                if (dTable.Rows.Count == 1)
                {
                    isAuthenticated = true;
                    isAdmin = dTable.Rows[0][1].ToString() == "1" ? true : false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return Tuple.Create(isAuthenticated, isAdmin);

        }
    }
}
