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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.fonts;
using System.Drawing.Design;

using System.Reflection;
namespace CLOApp
{
    public partial class frmStudentsDetails : Form
    {
        public frmStudentsDetails()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selected_row = dataGridView1.Rows[index];
            string id = selected_row.Cells[0].Value.ToString();
            int x;
            Int32.TryParse(id, out x);
            MyClass.count = x;
            if (e.ColumnIndex == 7)
            {
                if (DialogResult.Yes == MessageBox.Show("Do you want to edit the row?", "", MessageBoxButtons.YesNo))
                {
                    frmEditStdDetail s2 = new frmEditStdDetail();
                    s2.Show();
                    this.Hide();        
                }
            }
            else if (e.ColumnIndex == 8)
            {
                if (DialogResult.Yes == MessageBox.Show("Do you want to delete the row?", "", MessageBoxButtons.YesNo))
                {
                    String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
                    //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
                    SqlConnection conn1 = new SqlConnection(conURL1);
                    conn1.Open();

                    String cmd1 = "Delete FROM Student Where Student.Id = " + MyClass.count;
                    //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
                    SqlDataAdapter cmd = new SqlDataAdapter(cmd1, conn1);
                    cmd.SelectCommand.ExecuteNonQuery();
                    conn1.Close();
                    MessageBox.Show("Data Has been successfuly deleted");
                }
            }
}
        
        private void button1_Click(object sender, EventArgs e)
        {
          frmAddStudents mgs = new frmAddStudents();
            mgs.Show();
            this.Hide();
        }

        private void StudentsDetails_Load(object sender, EventArgs e)
        {
            //Show , Edit or Delete Button
            Showdata();
            Editbtn();
            Deletebtn();

        }

        // Function to Show data in Grid View 
        // From database
        public void Showdata()
        {
            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();
            String cmd1 = "SELECT * FROM Student";
            //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
            SqlCommand cmd = new SqlCommand(cmd1, conn1);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn1.Close();
            dataGridView1.DataSource = dt;
            /*Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Student.pdf", FileMode.Create));
            doc.Open();
            //doc.Add(dataGridView1.DataSource);
            doc.Close();*/
            /////////////////////////////////////////////
            //Creating iTextSharp Table from the DataTable data
            /*
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
            for (int h = 0; h<(l-2); h++)
            {
                DataGridViewRow row = dataGridView1.Rows[h];
                for (int n = 0; n<dataGridView1.ColumnCount; n++)
                {
                    
                    DataGridViewCell cell = row.Cells[n];
                    pdfTable.AddCell(cell.Value.ToString());
                }
            }

           /* foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value.ToString());
                }
            }
            */
            //Exporting to PDF
            /*string folderPath = "C:\\PDFs\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "DataGridViewExport2.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                //////
                BaseFont bfn = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
               

                Paragraph p = new Paragraph("Students Details");

                p.Alignment = Element.ALIGN_CENTER;
               
                /////
                pdfDoc.Add(p);
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();*/
            
        }





    
        // Create Edit btn In datagridView
        public void Editbtn()
        {
            DataGridViewButtonColumn b1 = new DataGridViewButtonColumn();
            b1.HeaderText = "Edit Data";
            b1.Name = "Edit Data";
            b1.Text = "Edit";
            b1.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(b1);
        }

        // Create Delete btn in datagridview
        public void Deletebtn()
        {
            DataGridViewButtonColumn b1 = new DataGridViewButtonColumn();
            b1.HeaderText = "Delete Data";
            b1.Name = "Delete Data";
            b1.Text = "Delete";
            b1.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(b1);
        }

        private void button2_Click(object sender, EventArgs e)
        {

           
            frmManageData f1 = new frmManageData();
            f1.Show();
            this.Hide();
        }
    }
}
