using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        DataTable dTableproductsstock = new DataTable();
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
            load_product_stock();
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = Program.productsizes;
            cmbSize.DataSource = bindingSource1.DataSource;

            DataRow[] filteredRows = dTableproductsstock.Select("ProductID = " + cmbbxSelectProduct.SelectedValue + " and Number = " + cmbSize.SelectedValue);
            if (filteredRows.Length > 0)
            {
                txtbxPid.Text = filteredRows.FirstOrDefault()["ProductID"].ToString();
                txtbxStock.Text = filteredRows.FirstOrDefault()["Quantity"].ToString();
            }
            else
            {
                txtbxPid.Text = cmbbxSelectProduct.SelectedValue.ToString();
                txtbxStock.Text = "0"; ;
            }
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

        private void load_product_stock()
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=Password@11";
                string Query = "select * from `pos`.`productstock` ;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;

                MyAdapter.Fill(dTableproductsstock);

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
                string Query = "insert into  `pos`.`productinventory`(ProductID,Quantity,Vendor,Description,DateTime,Number) values(" + this.txtbxPid.Text + "," + this.txtbxQuantity.Text + ",'" + this.txtbxVendor.Text + "','"
                    + txtbxDesc.Text + "','" + System.DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") + "'," + cmbSize.SelectedValue + ");";
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
                using (MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=Password@11"))
                {
                    conn.Open();

                    // 1.  create a command object identifying the stored procedure
                    MySqlCommand cmd = new MySqlCommand("pos.insertproductstock", conn);

                    // 2. set the command object so it knows to execute a stored procedure
                    cmd.CommandType = CommandType.StoredProcedure;

                    // 3. add parameter to command, which will be passed to the stored procedure
                    cmd.Parameters.Add(new MySqlParameter("@pproductid", Convert.ToInt32(txtbxPid.Text)));
                    cmd.Parameters.Add(new MySqlParameter("@pnumber", Convert.ToInt32(cmbSize.SelectedValue)));
                    cmd.Parameters.Add(new MySqlParameter("@pquantity", totalquantity));
                    // execute the command
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cmbbxSelectProduct_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataRow[] filteredRows = dTableproductsstock.Select("ProductID = " + cmbbxSelectProduct.SelectedValue + " and Number = " + cmbSize.SelectedValue);
            if (filteredRows.Length > 0)
            {
                txtbxPid.Text = filteredRows.FirstOrDefault()["ProductID"].ToString();
                txtbxStock.Text = filteredRows.FirstOrDefault()["Quantity"].ToString();
            }
            else
            {
                txtbxPid.Text = cmbbxSelectProduct.SelectedValue.ToString();
                txtbxStock.Text = "0"; ;
            }
        }

        private void cmbSize_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataRow[] filteredRows = dTableproductsstock.Select("ProductID = " + cmbbxSelectProduct.SelectedValue + " and Number = " + cmbSize.SelectedValue);
            if (filteredRows.Length > 0)
            {
                txtbxPid.Text = filteredRows.FirstOrDefault()["ProductID"].ToString();
                txtbxStock.Text = filteredRows.FirstOrDefault()["Quantity"].ToString();
            }
            else
            {
                txtbxPid.Text = cmbbxSelectProduct.SelectedValue.ToString();
                txtbxStock.Text = "0"; ;
            }
        }
    }
}
