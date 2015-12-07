using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Office.Interop.Excel;
namespace QuanLyQuanCafe.QuanLy
{
    public partial class HangHoa : UserControl
    {
        public HangHoa()
        {
            InitializeComponent();

            dataGridView1.Rows.Add(72132139, "Cà phê đen", "20000", 200);
            dataGridView1.Rows.Add(21312321, "Trà sữa", "30000", 500);
            dataGridView1.Rows.Add(13213213, "Cà phê sữa", "25000", 200);
            dataGridView1.Rows.Add(23131233, "Chanh đá", "25000", 250);
            dataGridView1.Rows.Add(21331231, "Sinh tố bơ", "30000",300);
            dataGridView1.Rows.Add(21321313, "Cocacola", "18000", 150);
            dataGridView1.Rows.Add(43534553, "Pepsi", "20000", 100);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void materialSingleLineTextField3_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.InitialDirectory = "C:";
            //saveFileDialog.Filter = @"Execl files (*.xls)|*.xls";
            //saveFileDialog.Title = @"Save as Excel File";
            //saveFileDialog.FileName = "";
            //saveFileDialog.FilterIndex = 0;

            //if (saveFileDialog.ShowDialog() != DialogResult.Cancel)
            //{
            //    Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            //    excelApp.Application.Workbooks.Add(Type.Missing);
            //    excelApp.Columns.ColumnWidth = 20;

            //    for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            //    {
            //        excelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            //    }

            //    for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //    {
            //        for (int j = 0; j < dataGridView1.Columns.Count; j++)
            //        {
            //            excelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
            //        }
            //    }
            //    excelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog.FileName.ToString());
            //    excelApp.ActiveWorkbook.Saved = true;
            //    excelApp.Quit();
            //}
            //PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);
            //pdfTable.DefaultCell.Padding = 3;
            //pdfTable.WidthPercentage = 30;
            //pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            //pdfTable.DefaultCell.BorderWidth = 1;


            ////Adding Header row
            //foreach (DataGridViewColumn column in dataGridView1.Columns)
            //{
            //    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
            //    pdfTable.AddCell(cell);
            //}

            ////Adding DataRow
            //foreach (DataGridViewRow row in dataGridView1.Rows)
            //{
            //    foreach (DataGridViewCell celli in row.Cells)
            //    {
            //        try
            //        {
            //            pdfTable.AddCell(celli.Value.ToString());
            //        }
            //        catch { }
            //    }
            //}






            ////Exporting to PDF
            //string folderPath = "C:\\PDFs\\";
            //if (!Directory.Exists(folderPath))
            //{
            //    Directory.CreateDirectory(folderPath);
            //}
            //using (FileStream stream = new FileStream(folderPath + "DataGridViewExport.pdf", FileMode.Create))
            //{
            //    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
            //    PdfWriter.GetInstance(pdfDoc, stream);
            //    pdfDoc.Open();
            //    pdfDoc.Add(pdfTable);
            //    pdfDoc.Close();
            //    stream.Close();
            //}
         
        }
    }
    
}
