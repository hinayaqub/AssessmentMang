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
    public partial class CreateAtte : Form
    {
        public CreateAtte()
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
            String cmd1 = "SELECT RegistrationNumber FROM Student";
            //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
            SqlCommand cmd = new SqlCommand(cmd1, conn1);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn1.Close();
            dataGridView1.DataSource = dt;

        }
        public void comobox()
        {
            DataGridViewComboBoxColumn b1 = new DataGridViewComboBoxColumn();
            b1.HeaderText = "Attendence Mark";
            b1.Name = "Attendence_Mark";
            b1.Items.AddRange("Present", "Absent", "Leave", "Late");
            dataGridView1.Columns.Add(b1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog = ProjectB ; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string att = (string)dataGridView1.Rows[i].Cells[0].Value;
                string regno = (string)dataGridView1.Rows[i].Cells[1].Value;
                int j = 0;
                if(att== "Present")
                {
                    j = 1;
                }
                else if(att== "Absent")
                {
                    j = 2;
                }
                else if (att== "Leave")
                {
                    j = 3;
                }
                else
                {
                    j = 4;
                }
                String cmd1 = "insert into ClassAttendance values ('" + Convert.ToDateTime(dateTimePicker1.Text) + "')";
                SqlCommand cmd = new SqlCommand(cmd1, conn1);
                cmd.ExecuteNonQuery();

                String cmd2 = "insert into StudentAttendance values ('" + Convert.ToDateTime(dateTimePicker1.Text) + "')";
                SqlCommand cmd02 = new SqlCommand(cmd2, conn1);
                cmd02.ExecuteNonQuery();



                conn1.Close();
                bool isCellChecked = (bool)dataGridView1.Rows[i].Cells[1].Value;
                if (isCellChecked == true)
                {
                    MessageBox.Show("Is Checked");
                }
                else
                {
                    MessageBox.Show("Is Not Chiked");
                }
            }
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
