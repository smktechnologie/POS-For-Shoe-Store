using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.text.rtf.table;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos
{
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = String.Empty;
                Query = "SELECT p.id,p.Name,ps.Number,ps.Quantity from `pos`.product p, `pos`.productstock ps where ps.ProductID = p.id and p.id= " + cmbbxitem.SelectedValue;

                MySqlConnection MyConn2 = new MySqlConnection(Program.dbconnectionstring);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dgResults.DataSource = dTable;
                MyConn2.Close();
                btn_print.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " \n " + ex.StackTrace);
            }
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            load_Products();

        }

        private void load_Products()
        {
            try
            {
                DataTable dTableproducts = new DataTable();
                string Query = "select ID,Name from `pos`.`product` where isactive=1;";
                MySqlConnection MyConn2 = new MySqlConnection(Program.dbconnectionstring);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;

                MyAdapter.Fill(dTableproducts);
                cmbbxitem.DataSource = dTableproducts;
                cmbbxitem.DisplayMember = "Name";
                cmbbxitem.ValueMember = "ID";
                cmbbxitem.AutoCompleteMode = AutoCompleteMode.Suggest;
                cmbbxitem.AutoCompleteSource = AutoCompleteSource.ListItems;
                MyConn2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " \n " + ex.StackTrace);
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            DataTable dTable = new DataTable();

            try
            {
                string Query = String.Empty;
                Query = "SELECT p.id,p.Name,ps.Number,ps.Quantity from `pos`.product p, `pos`.productstock ps where ps.ProductID = p.id and p.isactive = 1;";

                MySqlConnection MyConn2 = new MySqlConnection(Program.dbconnectionstring);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                MyAdapter.Fill(dTable);
                MyConn2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " \n " + ex.StackTrace);
            }


            if (dTable.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Stocks.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dTable.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataColumn column in dTable.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataRow row in dTable.Rows)
                            {

                                for (int i = 0; i < dTable.Columns.Count; i++)
                                {
                                    if (row[i] != null)
                                        pdfTable.AddCell(row[i].ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }

        }
    }
}
