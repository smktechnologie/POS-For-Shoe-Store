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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pos
{
    public partial class Inventory : Form
    {
        DataTable dTableproducts = new DataTable();
        public Inventory()
        {
            InitializeComponent();
        }

        private void btnAddInventory_Click(object sender, EventArgs e)
        {
            AddInventory();
            updateproductquantity();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            load_Products();
            DataRow[] filteredRows = dTableproducts.Select("ID = " + cmbbxSelectProduct.SelectedValue);
            txtbxPid.Text = filteredRows.FirstOrDefault()["ID"].ToString();
            txtbxStock.Text = filteredRows.FirstOrDefault()["Quantity"].ToString();

        }

        private void load_Products()
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=Password@11";
                string Query = "select * from `pos`.`product` where isactive=1;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;

                MyAdapter.Fill(dTableproducts);
                cmbbxSelectProduct.DataSource = dTableproducts;
                cmbbxSelectProduct.DisplayMember = "Name";
                cmbbxSelectProduct.ValueMember = "id";
                MyConn2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       private void AddInventory()
        {
            try
            {
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=Password@11";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "insert into  `pos`.`productinventory`(ProductID,Quantity,Vendor,Description,DateTime) values(" + this.txtbxPid.Text + "," + this.txtbxQuantity.Text + ",'" + this.txtbxVendor.Text + "','"
                    + txtbxDesc.Text + "','" + System.DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
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

        private void updateproductquantity()
        {
            try
            {
                int totalquantity = Convert.ToInt32(txtbxStock.Text) + Convert.ToInt32(txtbxQuantity.Text);
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=Password@11";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "update `pos`.`product` set Quantity =" + totalquantity.ToString() + " where id = " + txtbxPid.Text + ";";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
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
        private void cmbbxSelectProduct_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataRow[] filteredRows = dTableproducts.Select("ID = " + cmbbxSelectProduct.SelectedValue);
            txtbxPid.Text = filteredRows.FirstOrDefault()["ID"].ToString();
            txtbxStock.Text = filteredRows.FirstOrDefault()["Quantity"].ToString();
        }
    }
}
