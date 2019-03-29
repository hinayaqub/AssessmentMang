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
    public partial class Editattend : Form
    {
        public Editattend()
        {
            InitializeComponent();
        }

        private void Editattend_Load(object sender, EventArgs e)
        {
            EditData();
        }
        public void EditData()
        {

            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();

            String cmd1 = "SELECT * FROM StudentAttendance Where AttendanceId = " + MyClass.attdid;
            //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
            SqlCommand cmd = new SqlCommand(cmd1, conn1);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn1.Close();
            dataGridView1.DataSource = dt;
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveData();
            MessageBox.Show("Data has been updated");
            AttendenceDetail ad = new AttendenceDetail();
            ad.Show();
            this.Hide();

        }
        public void SaveData()
        {
            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog = ProjectB ; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            
            
            using (SqlConnection conn1 = new SqlConnection(conURL1))
            {
                using (SqlCommand comm = new SqlCommand())

                {
                    conn1.Open();
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {

                        String cmd1 = "update StudentAttendance set  AttendanceStatus= '" + dataGridView1.Rows[i].Cells["AttendanceStatus"].Value + "' Where  AttendanceId= '" + MyClass.attdid + "' AND StudentId = '"+dataGridView1.Rows[i].Cells["StudentId"].Value+"'";
                        SqlCommand cmd = new SqlCommand(cmd1, conn1);
                        try
                        {
                            cmd.ExecuteReader();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex + " Record Has Been Updated ");
                        }
                    }

                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
    }
}
