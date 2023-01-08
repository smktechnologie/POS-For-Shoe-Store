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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();


        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
              
                string Query = "insert into  `pos`.`product`(Name,Description,Price,DateTime) values('" + this.txtbx_pname.Text + "','" + this.txtbx_pdesc.Text + "'," + Convert.ToDouble(txtbxPrice.Text) + ",'" + System.DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") + "');";
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
        void AddPRoductStock()
        {

        }

        private void load_data()
        {
            try
            { 
                string Query = "select id,name,price,description,datetime from `pos`.`product` where name like '%" + txtbx_name_search.Text + "%' and isactive=1;";
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

        private void dg_products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dgrow = dg_products.Rows[e.RowIndex];
                txtbx_pid.Text = dgrow.Cells[0].Value.ToString();
                txtbx_pname.Text = dgrow.Cells[1].Value.ToString();
                txtbxPrice.Text = dgrow.Cells[2].Value.ToString();
                txtbx_pdesc.Text = dgrow.Cells[3].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path
               
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "update `pos`.`product` set isactive= 0 where id = " + txtbx_pid.Text + ";";
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
              
                string Query = "update `pos`.`product` set Name='" + txtbx_pname.Text + "' ,Description = '" + txtbx_pdesc.Text + "',Price = " + txtbxPrice.Text + " where id = " + txtbx_pid.Text + ";";
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
    }
}
