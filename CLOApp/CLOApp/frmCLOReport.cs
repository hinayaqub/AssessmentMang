﻿using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLOApp
{
    public partial class frmCLOReport : Form
    {
        public frmCLOReport()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);
            pdfTable.DefaultCell.Padding = 10;
            pdfTable.WidthPercentage = 70;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            int k = 0;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                k++;
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            int l = dataGridView1.Rows.Count;
            for (int h = 0; h < (l - 2); h++)
            {
                DataGridViewRow row = dataGridView1.Rows[h];
                for (int n = 0; n < dataGridView1.ColumnCount; n++)
                {

                    DataGridViewCell cell = row.Cells[n];
                    pdfTable.AddCell(cell.Value.ToString());
                }
            }
            /*
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value.ToString());
                }
            }*/

            //Exporting to PDF
            string folderPath = "C:\\PDFs\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "Clo.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);

                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                //////
                BaseFont bfn = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);


                Paragraph p = new Paragraph("CLO Report");

                p.Alignment = Element.ALIGN_CENTER;

                /////
                pdfDoc.Add(p);
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
                MessageBox.Show("Report Has been Created");

            }
        }

        private void frmCLOReport_Load(object sender, EventArgs e)
        {
            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();
            String cmd1 = "SELECT RegistrationNumber , FirstName , Clo.Name As CLO , Rubric.Details , MeasurementLevel As [Obtained Marks] FROM((((((StudentResult INNER JOIN  AssessmentComponent ON AssessmentComponentId = AssessmentComponent.Id) INNER JOIN  RubricLevel ON RubricMeasurementId = RubricLevel.Id) INNER JOIN  Rubric ON AssessmentComponent.RubricId = Rubric.Id) INNER JOIN  Assessment ON AssessmentComponent.AssessmentId = Assessment.Id) INNER JOIN  Student ON StudentResult.StudentId = Student.Id) INNER JOIN  Clo ON Clo.Id = Rubric.CloId); ";
            SqlCommand cmd = new SqlCommand(cmd1, conn1);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn1.Close();
        }
    }
}
