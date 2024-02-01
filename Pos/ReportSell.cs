using iTextSharp.text.pdf;
using iTextSharp.text;
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
    public partial class ReportSell : Form
    {
        public ReportSell()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = String.Empty;
                Query = "select o.OrderID as ID,a.Name,o.Total,o.Discount,o.NetTotal as 'Net Total',o.Paid,o.Remaining,o.Datetime from `pos`.`order` o,`pos`.`account` a where a.id=o.CustomerAccountID and (o.Datetime >= '" + dtfrom.Value.ToString("yyyy-MM-dd H:mm:ss") + "' and o.Datetime <= '" + dtTo.Value.ToString("yyyy-MM-dd H:mm:ss") + "');";

                MySqlConnection MyConn2 = new MySqlConnection(Program.dbconnectionstring);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                MyConn2.Close();

                if (dTable.Rows.Count > 0)
                {
                    foreach (DataRow dr in dTable.Rows)
                    {
                        dgResults.Rows.Add("View",
                               dr[0].ToString(),
                              dr[1].ToString(),
                               dr[2].ToString(),
                              dr[3].ToString(),
                              dr[4].ToString(),
                               dr[5].ToString(),
                              dr[6].ToString(),
                                dr[7].ToString()
                               );
                    }


                    btn_print.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " \n " + ex.StackTrace);
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            if (dgResults.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
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
                            PdfPTable pdfTable = new PdfPTable(dgResults.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dgResults.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dgResults.Rows)
                            {

                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (cell.Value != null)
                                        pdfTable.AddCell(cell.Value.ToString());
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

        private void dgResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != dgResults.NewRowIndex && e.ColumnIndex == 0)
            {
                ProductDetails pd;
                int OrderID = Convert.ToInt32(dgResults.Rows[e.RowIndex].Cells[1].Value);
                FrmOrderDetail frm = new FrmOrderDetail(OrderID);
                frm.ShowDialog(this);
                frm.Dispose();
            }
        }
    }
}
