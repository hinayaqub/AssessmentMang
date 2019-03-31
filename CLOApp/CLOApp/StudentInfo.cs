
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
    class StudentInfo
    {

        /// <summary>
        /// Bind Data of Database with DataTable
        /// </summary>
        /// <returns>DataTable Containing Student Info</returns>
        public DataTable Showdata()
        {
            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();
            String cmd1 = "SELECT * FROM Student";
            SqlCommand cmd = new SqlCommand(cmd1, conn1);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn1.Close();
            return dt;

        }
       
        /// <summary>
        /// To Edit the data of Student 
        /// </summary>
        public void EditStdData()
        {

            if (DialogResult.Yes == MessageBox.Show("Do you want to edit the row?", "", MessageBoxButtons.YesNo))
            {
                frmEditStdDetail EditStdDetail = new frmEditStdDetail();
                EditStdDetail.Show();
                
            }
        }
        /// <summary>
        /// To delete data of student
        /// </summary>
        public void DeleteStdData()
        {
            if (DialogResult.Yes == MessageBox.Show("Do you want to delete the row?", "", MessageBoxButtons.YesNo))
            {
                String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
                SqlConnection conn1 = new SqlConnection(conURL1);
                conn1.Open();

                ///Delete from StudentResult table where it is used ad Foreign Key
                String stdRes = "Delete FROM StudentResult Where StudentId = " + MyClass.count;
                SqlDataAdapter Sqldata = new SqlDataAdapter(stdRes, conn1);
                Sqldata.SelectCommand.ExecuteNonQuery();

                ///Delete from StudentAttendence table where it is used ad Foreign Key
                String stdAttend = "Delete FROM StudentAttendance Where StudentAttendance.StudentId = " + MyClass.count;
                SqlDataAdapter Sqldataadap = new SqlDataAdapter(stdAttend, conn1);
                Sqldataadap.SelectCommand.ExecuteNonQuery();

                String cmd1 = "Delete FROM Student Where Student.Id = " + MyClass.count;
                //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
                SqlDataAdapter cmd = new SqlDataAdapter(cmd1, conn1);
                cmd.SelectCommand.ExecuteNonQuery();
                conn1.Close();
                MessageBox.Show("Data Has been successfuly deleted");
            }
        }

       

        /// <summary>
        ///  Create Edit btn In datagridView
        /// </summary>
        /// <returns>Return Edit Button Column</returns>
        public DataGridViewButtonColumn Editbtn()
        {
            DataGridViewButtonColumn dgvEditBtnColumn = new DataGridViewButtonColumn();
            dgvEditBtnColumn.HeaderText = "Edit Data";
            dgvEditBtnColumn.Name = "Edit Data";
            dgvEditBtnColumn.Text = "Edit";
            dgvEditBtnColumn.UseColumnTextForButtonValue = true;
            return dgvEditBtnColumn;
        }

        /// <summary>
        ///  Create Delete btn in datagridview
        /// </summary>
        /// <returns>Return Delete Button Column</returns>
        public DataGridViewButtonColumn Deletebtn()
        {
            DataGridViewButtonColumn dgvDeleteBtn = new DataGridViewButtonColumn();
            dgvDeleteBtn.HeaderText = "Delete Data";
            dgvDeleteBtn.Name = "Delete Data";
            dgvDeleteBtn.Text = "Delete";
            dgvDeleteBtn.UseColumnTextForButtonValue = true;
            return dgvDeleteBtn;
        }
        


    }
    }

