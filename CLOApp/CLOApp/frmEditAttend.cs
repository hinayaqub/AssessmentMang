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
    public partial class frmEditAttend : Form
    {
        public frmEditAttend()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Bind Data Of Database with DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            dgvAttendenceData.DataSource = dt;
           

        }
        public void SaveData()
        {
            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog = ProjectB ; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            
            
            using (SqlConnection conn1 = new SqlConnection(conURL1))
            {
                using (SqlCommand comm = new SqlCommand())

                {
                    conn1.Open();
                    for (int i = 0; i < dgvAttendenceData.Rows.Count - 1; i++)
                    {

                        String cmd1 = "update StudentAttendance set  AttendanceStatus= '" + dgvAttendenceData.Rows[i].Cells["AttendanceStatus"].Value + "' Where  AttendanceId= '" + MyClass.attdid + "' AND StudentId = '"+dgvAttendenceData.Rows[i].Cells["StudentId"].Value+"'";
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

        /// <summary>
        /// Save Data into Database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
            MessageBox.Show("Data has been updated");
            frmAttendenceDetail ad = new frmAttendenceDetail();
            ad.Show();
            this.Hide();
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            
            frmAttendenceDetail ad = new frmAttendenceDetail();
            ad.Show();
            this.Hide();
        }
    }
}
