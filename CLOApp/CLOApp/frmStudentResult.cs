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
    public partial class frmStudentResult : Form
    {
        public frmStudentResult()
        {
            InitializeComponent();
        }





        private void StudentResult_Load(object sender, EventArgs e)
        {

        }

        public void AddStdRes()

        {
            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog = ProjectB ; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();
            String cmd1 = "insert into StudentResult values ('" + MyClass.Assstd + "','" + MyClass.AssCompid + "','" +
            MyClass.rubriclvl + "','" + Convert.ToDateTime(dtpDateEval.Text) + "')";

            SqlCommand cmd = new SqlCommand(cmd1, conn1);
            int i = cmd.ExecuteNonQuery();
            conn1.Close();
            if (i != 0)
            {
                MessageBox.Show(i + "Record Has Been Saved");
            }        
   }

       

     

        private void cboAssessComp_Click(object sender, EventArgs e)
        {
            if (cboAssessComp.Text == "")
            {
                MyClass.asscomp = cboAssessment.Text;
                String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
                //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
                SqlConnection conn1 = new SqlConnection(conURL1);
                conn1.Open();

                String cmd1 = "SELECT Id FROM Assessment Where Title = '" + MyClass.asscomp + "'";
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
                    MyClass.assmcomp = Convert.ToInt32(myReader.GetValue(0).ToString());

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                string cmd6 = "SELECT Name From AssessmentComponent Where AssessmentId = " + MyClass.assmcomp;
                //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
                SqlCommand cmd06 = new SqlCommand(cmd6, conn1);
                SqlDataReader ass = cmd06.ExecuteReader();
                while (ass.Read())
                {
                    cboAssessComp.Items.Add(ass[0]);

                }
            }

        }

        public void StdId()
        {
            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();

            String cmd1 = "SELECT Id FROM Student Where RegistrationNumber = '" + cboStdId.Text+ "'";
            //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
            SqlCommand cmd = new SqlCommand(cmd1, conn1);
            SqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            if (!myReader.Read())
            {
                int i = 0;
                MessageBox.Show("NewValue is not found");
                
            }

            else
            {
                try
                {
                    MyClass.Assstd = Convert.ToInt32(myReader.GetValue(0).ToString());

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        public void AssessmentId()
        {
            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();

            String cmd1 = "SELECT Id FROM Assessment Where Title = '" + cboAssessment.Text + "'";
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
                MyClass.Assid = Convert.ToInt32(myReader.GetValue(0).ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// 
        /// </summary>

        public void AssessmentComp()
        {
            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();

            String cmd1 = "SELECT Id FROM AssessmentComponent Where Name = '" + cboAssessComp.Text + "'";
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
                MyClass.AssCompid = Convert.ToInt32(myReader.GetValue(0).ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        ////
        public void Rubriclevel()
        {
            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();

            String cmd1 = "SELECT Id FROM RubricLevel Where Details = '" + cboRubriclvl.Text + "'";
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
                MyClass.rubriclvl = Convert.ToInt32(myReader.GetValue(0).ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cboStdId_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboStdId.Text))
            {
                e.Cancel = true;
                cboStdId.Focus();
                errorProvider1.SetError(cboStdId, "Field should not be left blank!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cboStdId, "");
            }
        }

        private void cboAssessment_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboAssessment.Text))
            {
                e.Cancel = true;
                cboAssessment.Focus();
                errorProvider1.SetError(cboAssessment, "Field should not be left blank!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cboAssessment, "");
            }
        }

        private void cboAssessComp_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboAssessComp.Text))
            {
                e.Cancel = true;
                cboAssessComp.Focus();
                errorProvider1.SetError(cboAssessComp, "Field should not be left blank!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cboAssessComp, "");
            }
        }

        private void cboRubriclvl_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboRubriclvl.Text))
            {
                e.Cancel = true;
                cboRubriclvl.Focus();
                errorProvider1.SetError(cboRubriclvl, "Field should not be left blank!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cboRubriclvl, "");
            }
        }
        



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selected_row = dgvStdres.Rows[index];
            string id = selected_row.Cells[0].Value.ToString();
            int x;
            Int32.TryParse(id, out x);
            MyClass.stdres = x;
            if (e.ColumnIndex == 4)
            {
                if (DialogResult.Yes == MessageBox.Show("Do you want to edit the row?", "", MessageBoxButtons.YesNo))
                {
                    frmEditStdResult stdresult = new frmEditStdResult();
                    stdresult.Show();
                    this.Hide();
                }
            }
            else if (e.ColumnIndex == 5)
            {
                if (DialogResult.Yes == MessageBox.Show("Do you want to delete the row?", "", MessageBoxButtons.YesNo))
                {
                    String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
                    //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
                    SqlConnection conn1 = new SqlConnection(conURL1);
                    conn1.Open();

                    String cmd1 = "Delete FROM StudentResult Where StudentId = " + MyClass.stdres;
                    //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
                    SqlDataAdapter cmd = new SqlDataAdapter(cmd1, conn1);
                    cmd.SelectCommand.ExecuteNonQuery();
                    conn1.Close();
                    MessageBox.Show("Data Has been successfuly deleted");
                }
            }
        }

        private void re(object sender, EventArgs e)
        {
            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();


            String cmd2 = "SELECT RegistrationNumber From Student";
            //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
            SqlCommand cmd02 = new SqlCommand(cmd2, conn1);
            SqlDataReader sd = cmd02.ExecuteReader();
            while (sd.Read())
            {
                cboStdId.Items.Add(sd[0]);

            }
            ////Load Tiltles of Assessment
            String assess = "SELECT Title From Assessment";
            //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
            SqlCommand sqlcmd = new SqlCommand(assess, conn1);
            SqlDataReader sqldata = sqlcmd.ExecuteReader();
            while (sqldata.Read())
            {
                cboAssessment.Items.Add(sqldata[0]);

            }
            /// Load Details into Rubriclvlcomobox
            String rubriclvl = "SELECT Details From RubricLevel";
            //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
            SqlCommand sqlcommand = new SqlCommand(rubriclvl, conn1);
            SqlDataReader sqldataread = sqlcommand.ExecuteReader();
            while (sqldataread.Read())
            {
                cboRubriclvl.Items.Add(sqldataread[0]);

            }

            StudentResult stdResult = new StudentResult();
            dgvStdres.DataSource = stdResult.Showdata();
            dgvStdres.Columns.Add(stdResult.Editbtn());
            dgvStdres.Columns.Add(stdResult.Deletebtn());
            
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (cboAssessComp.Text != "" && cboRubriclvl.Text != "" && cboStdId.Text != "" && cboAssessment.Text != "")
            {

                StdId();
                AssessmentId();
                AssessmentComp();
                Rubriclevel();
                AddStdRes();

            }
            else
            {
                MessageBox.Show("Fields Should not Empty");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            StudentResult stdResult = new StudentResult();
            dgvStdres.DataSource = stdResult.Showdata();
        }

        private void cboAssessComp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}