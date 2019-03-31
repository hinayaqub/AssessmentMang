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
    public partial class frmAttendenceDetail : Form
    {
        public frmAttendenceDetail()
        {
            InitializeComponent();
        }

        private void dgvClassAttendence_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selected_row = dgvClassAttendence.Rows[index];
            string id = selected_row.Cells[0].Value.ToString();
            string id1 = selected_row.Cells[1].Value.ToString();
            int x;
            Int32.TryParse(id, out x);
            Int32.TryParse(id1, out MyClass.attstd);
            MyClass.attdid = x;
            if (e.ColumnIndex == 3)
            {
                if (DialogResult.Yes == MessageBox.Show("Do you want to edit the row?", "", MessageBoxButtons.YesNo))
                {
                    frmEditAttend s2 = new frmEditAttend();
                    s2.Show();
                    this.Hide();
                }
            }
            else if (e.ColumnIndex == 4)
            {
                if (DialogResult.Yes == MessageBox.Show("Do you want to delete the row?", "", MessageBoxButtons.YesNo))
                {
                    String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
                    //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
                    SqlConnection conn1 = new SqlConnection(conURL1);
                    conn1.Open();

                    String cmd1 = "Delete FROM StudentAttendance Where StudentAttendance.AttendanceId = " + MyClass.attdid;
                    //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
                    SqlDataAdapter cmd = new SqlDataAdapter(cmd1, conn1); 
                    cmd.SelectCommand.ExecuteNonQuery();
                    conn1.Close();
                    MessageBox.Show("Data Has been successfuly deleted");
                    dgvClassAttendence.Refresh();
                }
            }
        }

        private void AttendenceDetail_Load(object sender, EventArgs e)
        {
            ClassAttendence classAttendence = new ClassAttendence();
            dgvClassAttendence.DataSource = classAttendence.Showdata();
            dgvClassAttendence.Columns.Add(classAttendence.Editbtn());
            dgvClassAttendence.Columns.Add(classAttendence.Deletebtn());
            

        }
        

        public void AddAttendence()
        {

            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog = ProjectB ; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();
            String cmd1 = "insert into ClassAttendance values ('" + Convert.ToDateTime(dtpDate.Text) + "')";

            SqlCommand cmd = new SqlCommand(cmd1, conn1);
            int i = cmd.ExecuteNonQuery();
            conn1.Close();
            if (i != 0)
            {
                MessageBox.Show(i + "Record Has Been Saved");
            }
            frmStudentsDetails s1 = new frmStudentsDetails();


        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddAttendence();
            frmAddAttendence addAttendence = new frmAddAttendence();
            addAttendence.Show();
            this.Hide();

        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            frmStudentMangForm stdMang = new frmStudentMangForm();
            stdMang.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ClassAttendence classattend = new ClassAttendence();
            dgvClassAttendence.DataSource = classattend.Showdata();
        }
    }
}
