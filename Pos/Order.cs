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

    public partial class Order : Form
    {
        double TotalOrderSum = 0.0;
        Dictionary<KeyValuePair<int, int>, ProductDetails> DictOrderDetails = new Dictionary<KeyValuePair<int, int>, ProductDetails>();
        DataTable dTableproductsstock = new DataTable();

        DataTable dTableproducts = new DataTable();
        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            load_Products();
            load_product_stock();
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = Program.productsizes;
            cmbbxSize.DataSource = bindingSource1.DataSource;
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
                cmbbxitem.DataSource = dTableproducts;
                cmbbxitem.DisplayMember = "Name";
                cmbbxitem.ValueMember = "id";
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int ProductID = Convert.ToInt32(cmbbxitem.SelectedValue.ToString());
            int Size = Convert.ToInt32(cmbbxSize.SelectedValue.ToString());
            int Quantity = Convert.ToInt32(txtbxQuantity.Text);
            int Stock = Convert.ToInt32(txtbxStock.Text);
            KeyValuePair<int, int> Productkey = new KeyValuePair<int, int>(ProductID, Size);
            if (!DictOrderDetails.ContainsKey(Productkey))
            {
                if (Quantity <= Stock)
                {

                    Double Total = Convert.ToDouble(txtbxPrice.Text) * Convert.ToDouble(txtbxQuantity.Text);
                    dtgviewItems.Rows.Add(
                        cmbbxitem.SelectedValue.ToString(),
                        cmbbxitem.Text,
                        txtbxPrice.Text,
                         cmbbxSize.SelectedValue.ToString(),
                        txtbxStock.Text,
                        txtbxQuantity.Text,
                        Total.ToString(),
                        "Remove"
                        );
                    DictOrderDetails.Add(Productkey, new ProductDetails(Convert.ToInt32(txtbxQuantity.Text), Convert.ToDouble(txtbxPrice.Text), Total, Stock - Quantity));
                    btn_Submit.Enabled = true;
                    TotalOrderSum += Total;
                    txtbxTotal.Text = TotalOrderSum.ToString();

                }
                else
                {
                    MessageBox.Show("Quantity is higher than stock.");

                }
            }
            else
            {
                MessageBox.Show("Item already added.");
            }
        }

        private void cmbbxitem_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var cmb = (sender as ComboBox);
            if (cmb != null && cmb.SelectedItem != null)
            {
                DataRow[] filteredRows = dTableproducts.Select("ID = " + cmb.SelectedValue.ToString());
                txtbxPrice.Text = filteredRows.FirstOrDefault()["Price"].ToString();
                DataRow[] filteredRowsstock = dTableproductsstock.Select("ProductID = " + cmb.SelectedValue + " and Number = " + cmbbxSize.SelectedValue);
                if (filteredRowsstock.Length > 0)
                {
                    txtbxStock.Text = filteredRowsstock.FirstOrDefault()["Quantity"].ToString();
                }
                else
                {
                    txtbxStock.Text = "0"; ;
                }
                cmbbxSize.Enabled = true;
                btnAdd.Enabled = true;
                txtbxQuantity.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
                txtbxQuantity.Enabled = false;
            }
        }

        private void dtgviewItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != dtgviewItems.NewRowIndex && e.ColumnIndex == 7)
            {
                ProductDetails pd;
                int ProductID = Convert.ToInt32(dtgviewItems.Rows[e.RowIndex].Cells[0].Value);
                int Size = Convert.ToInt32(dtgviewItems.Rows[e.RowIndex].Cells[3].Value);
                KeyValuePair<int, int> Productkey = new KeyValuePair<int, int>(ProductID, Size);
                dtgviewItems.Rows.RemoveAt(e.RowIndex);
                DictOrderDetails.TryGetValue(Productkey, out pd);
                DictOrderDetails.Remove(Productkey);
                TotalOrderSum = TotalOrderSum - pd.Total;
                txtbxTotal.Text = TotalOrderSum.ToString();
                if (DictOrderDetails.Count <= 0)
                {
                    btn_Submit.Enabled = false;
                }
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            insertOrder();
            int OrderID = getOrderID();
            insertOrderDetails(OrderID);
            MessageBox.Show("Order Submitted Successfully,Order ID : " + OrderID.ToString());
            this.Close();
        }

        void insertOrder()
        {

            try
            {
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=Password@11";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "insert into `pos`.`order`(Total,DateTime) values(" + this.txtbxTotal.Text + ",'" + System.DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") + "');";
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

        private int getOrderID()
        {
            int OrderID = -1;
            try
            {
                DataTable mydt = new DataTable();
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=Password@11";
                string Query = "select max(OrderID) as OrderID from `pos`.`order`";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;

                MyAdapter.Fill(mydt);
                OrderID = Convert.ToInt32(mydt.Rows[0]["OrderID"].ToString());
                MyConn2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return OrderID;
        }


        void insertOrderDetails(int OrderID)
        {
            try
            {
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=Password@11";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "insert into `pos`.`orderdetail`(OrderID,ProductID,Price,size,Quantity,Total) values";
                string UpdateQuery = string.Empty;
                foreach (var item in DictOrderDetails)
                {
                    Query += "(" + OrderID + "," + item.Key.Key.ToString() + "," + item.Value.Price.ToString() + "," + item.Key.Value.ToString() + "," + item.Value.Quantity.ToString() + "," + item.Value.Total.ToString() + "),";
                    UpdateQuery += "Update `pos`.`productstock` set Quantity =" + item.Value.RemainingQuantity.ToString() + " where ProductID = " + item.Key.Key.ToString() + " and Number = " + item.Key.Value.ToString() + ";";
                }
                Query = Query.Remove(Query.Length - 1, 1);
                Query += ";";
                Query += UpdateQuery;


                //MessageBox.Show(Query);
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

        private void cmbbxSize_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var cmb = (sender as ComboBox);
            if (cmb != null && cmb.SelectedItem != null)
            {
                DataRow[] filteredRowsstock = dTableproductsstock.Select("ProductID = " + cmbbxitem.SelectedValue + " and Number = " + cmbbxSize.SelectedValue);
                if (filteredRowsstock.Length > 0)
                {
                    txtbxStock.Text = filteredRowsstock.FirstOrDefault()["Quantity"].ToString();
                }
                else
                {
                    txtbxStock.Text = "0"; ;
                }
                btnAdd.Enabled = true;
                txtbxQuantity.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
                txtbxQuantity.Enabled = false;
            }
        }
    }
}