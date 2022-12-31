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
        Dictionary<int, ProductDetails> DictOrderDetails = new Dictionary<int, ProductDetails>();

        DataTable dTableproducts = new DataTable();
        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            load_Products();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int ProductID = Convert.ToInt32(cmbbxitem.SelectedValue.ToString());
            int Quantity = Convert.ToInt32(txtbxQuantity.Text);
            int Stock = Convert.ToInt32(txtbxStock.Text);
            if (!DictOrderDetails.ContainsKey(ProductID))
            {
                if (Quantity <= Stock)
                {

                    Double Total = Convert.ToDouble(txtbxPrice.Text) * Convert.ToDouble(txtbxQuantity.Text);
                    dtgviewItems.Rows.Add(
                        cmbbxitem.SelectedValue.ToString(),
                        cmbbxitem.SelectedText.ToString(),
                        txtbxPrice.Text,
                        txtbxStock.Text,
                        txtbxQuantity.Text,
                        Total.ToString(),
                        "Remove"
                        );
                    DictOrderDetails.Add(ProductID, new ProductDetails(Convert.ToInt32(txtbxQuantity.Text), Convert.ToDouble(txtbxPrice.Text), Total, Stock - Quantity));
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
                txtbxStock.Text = filteredRows.FirstOrDefault()["Quantity"].ToString();
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

            if (e.RowIndex != dtgviewItems.NewRowIndex && e.ColumnIndex == 6)
            {
                ProductDetails pd;
                int ProductID = Convert.ToInt32(dtgviewItems.Rows[e.RowIndex].Cells[0].Value);
                dtgviewItems.Rows.RemoveAt(e.RowIndex);
                DictOrderDetails.TryGetValue(ProductID, out pd);
                DictOrderDetails.Remove(ProductID);
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
                string Query = "insert into `pos`.`orderdetail`(OrderID,ProductID,Price,Quantity,Total) values";
                string UpdateQuery = string.Empty;
                foreach (var item in DictOrderDetails)
                {
                    Query += "(" + OrderID + "," + item.Key.ToString() + "," + item.Value.Price.ToString() + "," + item.Value.Quantity.ToString() + "," + item.Value.Total.ToString() + "),";
                    UpdateQuery += "Update `pos`.`product` set Quantity =" + item.Value.RemainingQuantity.ToString() + " where ID = " + item.Key.ToString() + " and isactive=1;";
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
    }
}