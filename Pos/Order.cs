using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
            load_Customers();
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = Program.productsizes;
            cmbbxSize.DataSource = bindingSource1.DataSource;
        }

        private void load_Customers()
        {
            try
            {
                DataTable customers = new DataTable();
                string Query = "select ID,Name from `pos`.`account` where Type = 'Customer' and isactive=1;";
                MySqlConnection MyConn2 = new MySqlConnection(Program.dbconnectionstring);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;

                MyAdapter.Fill(customers);
                cmbbx_CustomerAcc.DataSource = customers;
                cmbbx_CustomerAcc.DisplayMember = "Name";
                cmbbx_CustomerAcc.ValueMember = "ID";
                /* cmbbxitem.AutoCompleteMode = AutoCompleteMode.Suggest;
                 cmbbxitem.AutoCompleteSource = AutoCompleteSource.ListItems;*/
                MyConn2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void load_Products()
        {
            try
            {
                string Query = "select * from `pos`.`product` where isactive=1;";
                MySqlConnection MyConn2 = new MySqlConnection(Program.dbconnectionstring);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;

                MyAdapter.Fill(dTableproducts);
                cmbbxitem.DataSource = dTableproducts;
                cmbbxitem.DisplayMember = "Name";
                cmbbxitem.ValueMember = "id";
                cmbbxitem.AutoCompleteMode = AutoCompleteMode.Suggest;
                cmbbxitem.AutoCompleteSource = AutoCompleteSource.ListItems;
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

                string Query = "select * from `pos`.`productstock` ;";
                MySqlConnection MyConn2 = new MySqlConnection(Program.dbconnectionstring);
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
            if (isValidated())
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
                        txtNetTotal.Text = TotalOrderSum.ToString();
                        txtremaining.Text = TotalOrderSum.ToString();

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
                txtNetTotal.Text = TotalOrderSum.ToString();
                txtremaining.Text = TotalOrderSum.ToString();
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

            if (Configurations.isPrintReceiptOrder)
            {
                PaperSize psize = new PaperSize("Custom", 100, 30000);

                printDocument1.DefaultPageSettings.PaperSize = psize;
                printDocument1.DefaultPageSettings.PaperSize.Height = 30000;
                printDocument1.DefaultPageSettings.PaperSize.Width = 520;
                printDocument1.Print();
            }
            this.Close();
        }

        void insertOrder()
        {
            try
            {
                string Query = "insert into `pos`.`order`(CustomerAccountID,Total,Discount,NetTotal,Paid,Remaining,DateTime) values("
                    + this.cmbbx_CustomerAcc.SelectedValue.ToString() + ","
                    + this.txtbxTotal.Text + ","
                    + this.txtbxDiscount.Text + ","
                    + this.txtNetTotal.Text + ","
                    + this.txtbxpaid.Text + ","
                    + this.txtremaining.Text + ",'"
                    + System.DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") + "');";
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

        private int getOrderID()
        {
            int OrderID = -1;
            try
            {
                DataTable mydt = new DataTable();

                string Query = "select max(OrderID) as OrderID from `pos`.`order`";
                MySqlConnection MyConn2 = new MySqlConnection(Program.dbconnectionstring);
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
                double NetAmount = string.IsNullOrWhiteSpace(txtNetTotal.Text) ? 0.0 : double.Parse(txtNetTotal.Text);
                double PaidAmount = string.IsNullOrWhiteSpace(txtbxpaid.Text) ? 0.0 : double.Parse(txtbxpaid.Text);
                double RemainingAmount = string.IsNullOrWhiteSpace(txtremaining.Text) ? 0.0 : double.Parse(txtremaining.Text);

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
                Query += "insert into  `pos`.`accounttransactions`(AccountID,Invoice,BillType,NetAmount,PaidAmount,RemainingAmount,DateTime) values("
                    + cmbbx_CustomerAcc.SelectedValue.ToString() + ","
                    + OrderID.ToString() + ",'Selling',"
                    + NetAmount + ","
                    + PaidAmount + ","
                    + RemainingAmount + ",'"
                    + System.DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") + "');";
                if (RemainingAmount > 0.0)
                {
                    Query += "update `pos`.`account` set Balance = Balance + " + RemainingAmount + " where id = " + cmbbx_CustomerAcc.SelectedValue.ToString() + ";";
                }

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
        bool isValidated()
        {
            bool isvalidate = false;
            int result;
            if (string.IsNullOrWhiteSpace(txtbxQuantity.Text))
            {

                errprvdr_quantity.SetError(this.txtbxQuantity, "Quantity is required.");
            }
            else if (!Int32.TryParse(txtbxQuantity.Text, out result))
            {

                errprvdr_quantity.SetError(this.txtbxQuantity, "Quantity is not a valid number.");
            }
            else
            {
                isvalidate = true;
                errprvdr_quantity.SetError(this.txtbxQuantity, String.Empty);
            }
            return isvalidate;
        }
        private void txtbxQuantity_Validating(object sender, CancelEventArgs e)
        {
            int result;
            if (string.IsNullOrWhiteSpace(txtbxQuantity.Text))
            {
                errprvdr_quantity.SetError(this.txtbxQuantity, "Quantity is required.");
            }
            else if (!Int32.TryParse(txtbxQuantity.Text, out result))
            {

                errprvdr_quantity.SetError(this.txtbxQuantity, "Quantity is not a valid number.");
            }
            else
            {
                errprvdr_quantity.SetError(this.txtbxQuantity, String.Empty);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                //-----------
                Graphics graphics = e.Graphics;
                Font font = new Font("calibri", 10);
                float fontHeight = font.GetHeight();
                String underLine = "-------------------------------------------------------------";
                int startX = 10;
                int startY = 0;
                int Offset = 0;
                //  Offset += 0;
                // Offset = Offset + 15;
                graphics.DrawString(underLine, new Font("calibri", 10), new SolidBrush(Color.Black), 0, startY + Offset);
                Offset = Offset + 15;
                graphics.DrawString("Shabana Foot Wear Store ", new Font("Calibri", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX + 45, startY + Offset);
                Offset = Offset + 15;
                graphics.DrawString(underLine, new Font("calibri", 10), new SolidBrush(Color.Black), 0, startY + Offset);

                Offset = Offset + 15;
                graphics.DrawString("Name", new Font("Calibri", 9, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + Offset);
                graphics.DrawString("Quantity", new Font("Calibri", 9, FontStyle.Bold), new SolidBrush(Color.Black), startX + 130, startY + Offset);
                graphics.DrawString("Price", new Font("Calibri", 9, FontStyle.Bold), new SolidBrush(Color.Black), startX + 200, startY + Offset);
                Offset = Offset + 15;
                for (int i = 0; i < 2; i++)
                {
                    string item = (i + 1) + " - " + "Name " + i.ToString();
                    string quantity = i.ToString();
                    graphics.DrawString(item, new Font("Calibri", 8), new SolidBrush(Color.Black), startX, startY + Offset);
                    graphics.DrawString(quantity, new Font("Calibri", 8), new SolidBrush(Color.Black), startX + 130, startY + Offset);
                    graphics.DrawString((i * 100).ToString(), new Font("Calibri", 8), new SolidBrush(Color.Black), startX + 200, startY + Offset);
                    Offset = Offset + 15;
                }
                graphics.DrawString(underLine, new Font("calibri", 10), new SolidBrush(Color.Black), 0, startY + Offset);
                Offset = Offset + 15;
                graphics.DrawString("Total", new Font("Calibri", 8), new SolidBrush(Color.Black), startX, startY + Offset);
                graphics.DrawString("20000", new Font("Calibri", 8), new SolidBrush(Color.Black), startX + 200, startY + Offset);
                Offset = Offset + 15;
                graphics.DrawString("Print Time :  " + DateTime.Now.ToString("d, MMMM, yyyy. hh:mm - tt "), new Font("Calibri", 10), new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 15;

                graphics.DrawString("By : SMK Technologies", new Font("Calibri", 10), new SolidBrush(Color.Black), startX, startY + Offset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtbxDiscount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtbxpaid_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtbxDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtbxDiscount.Text.Length > 0)
            {
                txtNetTotal.Text = (Double.Parse(txtbxTotal.Text) - Double.Parse(txtbxDiscount.Text)).ToString();
            }
            else
            {
                txtNetTotal.Text = txtbxTotal.Text;


            }
        }

        private void txtbxpaid_TextChanged(object sender, EventArgs e)
        {
            if (txtbxpaid.Text.Length > 0)
            {
                txtremaining.Text = (Double.Parse(txtNetTotal.Text) - Double.Parse(txtbxpaid.Text)).ToString();
            }
            else
            {
                txtremaining.Text = txtNetTotal.Text;


            }
        }

    }
}