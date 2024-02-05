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
    public partial class FrmOrderDetail : Form
    {
        int m_orderid = 0;
        public FrmOrderDetail(int orderID)
        {
            InitializeComponent();
            this.lblOrder.Text = "Order ID : " + orderID.ToString();
            m_orderid = orderID;
            load_data();
        }

        private void load_data()
        {
            try
            {

                string Query = "select od.ProductID,p.Name,od.Size,od.Price,od.Quantity,od.Total from `pos`.`orderdetail` od,`pos`.`product` p where p.id=od.productid and orderid = " + m_orderid + ";";
                MySqlConnection MyConn2 = new MySqlConnection(Program.dbconnectionstring);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dgOrderDetails.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.
                MyConn2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " \n " + ex.StackTrace);
            }
        }
    }
}
