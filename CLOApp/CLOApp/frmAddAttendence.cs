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

namespace CLOApp
{
    public partial class frmAddAttendence : Form
    {
        public frmAddAttendence()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CreateAtte_Load(object sender, EventArgs e)
        {
          
            Showdata();
            comobox();
        }
        public void Showdata()
        {
            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();
            String cmd1 = "SELECT Id , RegistrationNumber FROM Student";
            //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
            SqlCommand cmd = new SqlCommand(cmd1, conn1);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn1.Close();
            dgvAttendence.DataSource = dt;

        }
        public void comobox()
        {
            DataGridViewComboBoxColumn b1 = new DataGridViewComboBoxColumn();
            b1.HeaderText = "Attendence Mark";
            b1.Name = "Attendence_Mark";
            b1.Items.AddRange("Present", "Absent", "Leave", "Late");
            dgvAttendence.Columns.Add(b1);
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {

            frmAttendenceDetail attendDetail= new frmAttendenceDetail();
            attendDetail.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog = ProjectB ; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();

            for (int i = 0; i < (dgvAttendence.Rows.Count - 1); i++)
            {
                string att = (string)dgvAttendence.Rows[i].Cells[2].Value;
                MyClass.regno = (int)dgvAttendence.Rows[i].Cells[0].Value;
                int j = 0;
                if (att == "Present")
                {
                    j = 1;
                }
                else if (att == "Absent")
                {
                    j = 2;
                }
                else if (att == "Leave")
                {
                    j = 3;
                }
                else
                {
                    j = 4;
                }

                /// Attendence Id
                String cmd1 = "SELECT TOP 1 Id FROM ClassAttendance ORDER BY Id DESC";
                //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
                SqlCommand cmd = new SqlCommand(cmd1, conn1);
                SqlDataReader myReader;
                myReader = cmd.ExecuteReader();
                if (!myReader.Read())
                {
                    MessageBox.Show("NewValue is not found");
                    return;
                }


                try
                {
                    MyClass.attd = myReader.GetValue(0).ToString();
                    cmd.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                /// Student Id
                String cmd2 = "Select Student.Id as StudentId From Student  Where Student.Id =" + MyClass.regno;
                //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
                SqlCommand cmd02 = new SqlCommand(cmd2, conn1);
                SqlDataReader myReader1;
                myReader1 = cmd02.ExecuteReader();
                if (!myReader1.Read())
                {
                    MessageBox.Show("NewValue is not found");
                    return;
                }


                try
                {
                    MyClass.std = myReader1.GetValue(0).ToString();
                    cmd02.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }



                String cmd3 = "SET IDENTITY_INSERT StudentAttendance ON insert into StudentAttendance( AttendanceId ,  StudentId , AttendanceStatus) Values ('" + Convert.ToInt32(MyClass.attd) + "' , '" + Convert.ToInt32(MyClass.std) + "' ,'" + j + "' ) SET IDENTITY_INSERT StudentAttendance OFF";
                SqlCommand cmd03 = new SqlCommand(cmd3, conn1);
                int n = cmd03.ExecuteNonQuery();





                /*  String cmd2 = "insert into StudentAttendance StudentId Select Student ('" + Convert.ToDateTime(dateTimePicker1.Text) + "')";
                  SqlCommand cmd02 = new SqlCommand(cmd2, conn1);
                  cmd02.ExecuteNonQuery();*/
            }
            MessageBox.Show("Data has been Saved");
            conn1.Close();

            frmAttendenceDetail attenDetail = new frmAttendenceDetail();
            attenDetail.Show();
            this.Hide();

        }

        // Function to Mark Attendence
        /* public void MarkAttendence()

         {

             String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog = ProjectB ; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
             SqlConnection conn1 = new SqlConnection(conURL1);
             conn1.Open();

             String cmd1 = "insert into Student values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" +
             textBox6.Text + "','" + textBox5.Text + "','" + status + "')";

             SqlCommand cmd = new SqlCommand(cmd1, conn1);
             int i = cmd.ExecuteNonQuery();
             conn1.Close();
             if (i != 0)
             {
                 MessageBox.Show(i + "Record Has Been Saved");
             }
             StudentsDetails s1 = new StudentsDetails();
             s1.Show();
             this.Hide();
         }*/
    }
}
