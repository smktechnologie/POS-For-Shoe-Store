using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace Pos
{
    public partial class Purchase : Form
    {

        double TotalPurchaseSum = 0.0;
        Dictionary<KeyValuePair<int, int>, PurchaseDetails> DictOrderDetails = new Dictionary<KeyValuePair<int, int>, PurchaseDetails>();
        DataTable dTableproductsstock = new DataTable();

        DataTable dTableproducts = new DataTable();
        public Purchase()
        {
            InitializeComponent();
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
                    DictOrderDetails.Add(Productkey, new PurchaseDetails(Convert.ToInt32(txtbxQuantity.Text), Convert.ToDouble(txtbxPrice.Text), Total, Stock - Quantity));
                    btn_Submit.Enabled = true;
                    TotalPurchaseSum += Total;
                    txtbxTotal.Text = TotalPurchaseSum.ToString();
                    txtNetTotal.Text = TotalPurchaseSum.ToString();
                    txtremaining.Text = TotalPurchaseSum.ToString();
                }
                else
                {
                    MessageBox.Show("Item already added.");
                }
            }
        }
        bool isValidated()
        {
            bool isvalidate = false;
            uint result;
            double dresult;
            if (string.IsNullOrWhiteSpace(txtbxPrice.Text))
            {
                errprvdr_quantity.SetError(this.txtbxQuantity, "Price is required.");
            }
            else if (!Double.TryParse(txtbxPrice.Text, out dresult))
            {
                errprvdr_quantity.SetError(this.txtbxQuantity, "Price is not a valid number.");
            }
            else if (string.IsNullOrWhiteSpace(txtbxQuantity.Text))
            {

                errprvdr_quantity.SetError(this.txtbxQuantity, "Quantity is required.");
            }
            else if (!uint.TryParse(txtbxQuantity.Text, out result))
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
        private void Purchase_Load(object sender, EventArgs e)
        {
            try
            {
                load_Products();
                load_product_stock();
                load_PurchaseAccounts();
                var bindingSource1 = new BindingSource();
                bindingSource1.DataSource = Program.productsizes;
                cmbbxSize.DataSource = bindingSource1.DataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " \n " + ex.StackTrace);
            }
        }


        private void load_PurchaseAccounts()
        {
            try
            {
                DataTable customers = new DataTable();
                string Query = "select ID,Name from `pos`.`account` where Type = 'Purchase' and isactive=1;";
                MySqlConnection MyConn2 = new MySqlConnection(Program.dbconnectionstring);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;

                MyAdapter.Fill(customers);
                cmbbx_PurchaseAcc.DataSource = customers;
                cmbbx_PurchaseAcc.DisplayMember = "Name";
                cmbbx_PurchaseAcc.ValueMember = "ID";

                MyConn2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " \n " + ex.StackTrace);
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
                MessageBox.Show(ex.Message + " \n " + ex.StackTrace);
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
                MessageBox.Show(ex.Message + " \n " + ex.StackTrace);
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

        private void cmbbxitem_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var cmb = (sender as ComboBox);
            if (cmb != null && cmb.SelectedItem != null)
            {
                DataRow[] filteredRows = dTableproducts.Select("ID = " + cmb.SelectedValue.ToString());
                //txtbxPrice.Text = filteredRows.FirstOrDefault()["Price"].ToString();
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
                PurchaseDetails pd;
                int ProductID = Convert.ToInt32(dtgviewItems.Rows[e.RowIndex].Cells[0].Value);
                int Size = Convert.ToInt32(dtgviewItems.Rows[e.RowIndex].Cells[3].Value);
                KeyValuePair<int, int> Productkey = new KeyValuePair<int, int>(ProductID, Size);
                dtgviewItems.Rows.RemoveAt(e.RowIndex);
                DictOrderDetails.TryGetValue(Productkey, out pd);
                DictOrderDetails.Remove(Productkey);
                TotalPurchaseSum = TotalPurchaseSum - pd.Total;
                txtbxTotal.Text = TotalPurchaseSum.ToString();
                txtNetTotal.Text = TotalPurchaseSum.ToString();
                txtremaining.Text = TotalPurchaseSum.ToString();
                if (DictOrderDetails.Count <= 0)
                {
                    btn_Submit.Enabled = false;
                }
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                insertPurchase();
                int PurchaseID = getPurchaseID();
                insertPurchaseDetails(PurchaseID);
                MessageBox.Show("Purchase Submitted Successfully,Purchase ID : " + PurchaseID.ToString());      
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " \n " + ex.StackTrace);
            }
        }

        void insertPurchase()
        {
            try
            {
                string Query = "insert into `pos`.`Purchase`(PurchaseAccountID,Total,Discount,NetTotal,Paid,Remaining,DateTime) values("
                    + this.cmbbx_PurchaseAcc.SelectedValue.ToString() + ","
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
                MessageBox.Show(ex.Message + " \n " + ex.StackTrace);
            }
        }

        private int getPurchaseID()
        {
            int PurchaseID = -1;
            try
            {
                DataTable mydt = new DataTable();

                string Query = "select max(PurchaseID) as PurchaseID from `pos`.`Purchase`;";
                MySqlConnection MyConn2 = new MySqlConnection(Program.dbconnectionstring);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;

                MyAdapter.Fill(mydt);
                PurchaseID = Convert.ToInt32(mydt.Rows[0]["PurchaseID"].ToString());
                MyConn2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " \n " + ex.StackTrace);
            }
            return PurchaseID;
        }


        void insertPurchaseDetails(int OrderID)
        {
            try
            {
                double NetAmount = string.IsNullOrWhiteSpace(txtNetTotal.Text) ? 0.0 : double.Parse(txtNetTotal.Text);
                double PaidAmount = string.IsNullOrWhiteSpace(txtbxpaid.Text) ? 0.0 : double.Parse(txtbxpaid.Text);
                double RemainingAmount = string.IsNullOrWhiteSpace(txtremaining.Text) ? 0.0 : double.Parse(txtremaining.Text);

                string Query = "insert into `pos`.`Purchasedetail`(PurchaseID,ProductID,Price,size,Quantity,Total) values";
                string UpdateQuery = string.Empty;
                foreach (var item in DictOrderDetails)
                {
                    Query += "(" + OrderID + "," + item.Key.Key.ToString() + "," + item.Value.Price.ToString() + "," + item.Key.Value.ToString() + "," + item.Value.Quantity.ToString() + "," + item.Value.Total.ToString() + "),";
                    UpdateQuery += "call  `pos`.`insertproductstock`(" + item.Key.Key.ToString() + "," + item.Key.Value.ToString() + "," + item.Value.Quantity.ToString() + ");";
                }
                Query = Query.Remove(Query.Length - 1, 1);
                Query += ";";
                Query += UpdateQuery;
                Query += "insert into  `pos`.`accounttransactions`(AccountID,Invoice,BillType,NetAmount,PaidAmount,RemainingAmount,DateTime) values("
                    + cmbbx_PurchaseAcc.SelectedValue.ToString() + ","
                    + OrderID.ToString() + ",'Purchasing',"
                    + NetAmount + ","
                    + PaidAmount + ","
                    + RemainingAmount + ",'"
                    + System.DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") + "');";
                if (RemainingAmount > 0.0)
                {
                    Query += "update `pos`.`account` set Balance = Balance + " + RemainingAmount + " where id = " + cmbbx_PurchaseAcc.SelectedValue.ToString() + ";";
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
                MessageBox.Show(ex.Message + " \n " + ex.StackTrace);
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

        private void txtbxPrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtbxQuantity_KeyPress(object sender, KeyPressEventArgs e)
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
