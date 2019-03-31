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
    public partial class frmAddAssessment : Form
    {
        public frmAddAssessment()
        {
            InitializeComponent();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Add Data from User to Database
        /// </summary>
        public void AddAssesm()

        {
            if (cboTitle.Text != "" && cboTotalWeightsge.Text != "" && txtTotalMarks.Text != "")
            {
                String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog = ProjectB ; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
                SqlConnection conn1 = new SqlConnection(conURL1);
                conn1.Open();
                String cmd1 = "insert into Assessment values ('" + cboTitle.Text + "','" + Convert.ToDateTime(dtpDate.Text) + "','" + txtTotalMarks.Text + "','" +
                cboTotalWeightsge.Text + "')";

                SqlCommand cmd = new SqlCommand(cmd1, conn1);
                int i = cmd.ExecuteNonQuery();
                conn1.Close();
                if (i != 0)
                {
                    MessageBox.Show(i + "Record Has Been Saved");
                }
            }
        }

       
        /// <summary>
        /// Bind Datagridview with data of database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAssessment_Load(object sender, EventArgs e)
        {
            Assessment assessment = new Assessment();
            dgvAssessment.DataSource = assessment.Showdata();
            dgvAssessment.Columns.Add(assessment.Editbtn());
            dgvAssessment.Columns.Add(assessment.Deletebtn());
            dgvAssessment.Columns.Add(assessment.AddAssCompbtn());
        }
       
       

        

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddAssesm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Assessment assessment = new Assessment();
            dgvAssessment.DataSource = assessment.Showdata();
        }

        private void dgvAssessment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selected_row = dgvAssessment.Rows[index];
            string id = selected_row.Cells[0].Value.ToString();

            Int32.TryParse(id, out MyClass.assess);

            if (e.ColumnIndex == 5)
            {
                if (DialogResult.Yes == MessageBox.Show("Do you want to edit the row?", "", MessageBoxButtons.YesNo))
                {
                    frmEditAssess c1 = new frmEditAssess();
                    c1.Show();
                    this.Hide();
                }
            }
            else if (e.ColumnIndex == 6)
            {
                if (DialogResult.Yes == MessageBox.Show("Do you want to delete the row?", "", MessageBoxButtons.YesNo))
                {
                    String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
                    //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
                    SqlConnection conn1 = new SqlConnection(conURL1);
                    conn1.Open();
                    ////
                    String asscompId = "SELECT Id FROM AssessmentComponent Where AssessmentId = " + MyClass.assess;
                    SqlCommand sqlCmd = new SqlCommand(asscompId, conn1);
                    SqlDataReader myReader;
                    myReader = sqlCmd.ExecuteReader();
                    if (!myReader.Read())
                    {
                        int i = 0;
                    }
                    else
                    {

                        try
                        {

                            MyClass.AssCompid = Convert.ToInt32(myReader.GetValue(0).ToString());
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }

                    /// To delete Assessment First Of all delete It from All
                    /// Entities where it is used as Foreign Key
                    String stdres = "Delete FROM StudentResult Where AssessmentComponentId = " + MyClass.AssCompid;
                    SqlDataAdapter sqlDatadapt = new SqlDataAdapter(stdres, conn1);
                    sqlDatadapt.SelectCommand.ExecuteNonQuery();

                    String asscom = "Delete FROM AssessmentComponent Where AssessmentId = " + MyClass.assess;
                    SqlDataAdapter sqlDataadapt = new SqlDataAdapter(asscom, conn1);
                    sqlDataadapt.SelectCommand.ExecuteNonQuery();

                    String cmd1 = "Delete FROM Assessment Where Id = " + MyClass.assess;
                    SqlDataAdapter cmd = new SqlDataAdapter(cmd1, conn1);
                    cmd.SelectCommand.ExecuteNonQuery();
                    conn1.Close();
                    MessageBox.Show("Data Has been successfuly deleted");
                }
            }
            else if (e.ColumnIndex == 7)
            {
                frmAssessComponent AssessCmp = new frmAssessComponent();
                AssessCmp.Show();
                this.Hide();
            }
        }
        /// <summary>
        /// Valaidating Of User Enterd Data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboTitle.Text))
            {
                e.Cancel = true;
                cboTitle.Focus();
                errorProvider1.SetError(cboTitle, "Field should not be left blank!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cboTitle, "");
            }
        }

        private void txtTotalMarks_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTotalMarks.Text))
            {
                e.Cancel = true;
                txtTotalMarks.Focus();
                errorProvider1.SetError(txtTotalMarks, "Field should not be left blank!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtTotalMarks, "");
            }
        }

        private void cboTotalWeightage_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboTotalWeightsge.Text))
            {
                e.Cancel = true;
                cboTotalWeightsge.Focus();
                errorProvider1.SetError(cboTotalWeightsge, "Field should not be left blank!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cboTotalWeightsge, "");
            }
        }

        private void btnBacak_Click(object sender, EventArgs e)
        {
            frmStudentMangForm stdData = new frmStudentMangForm();
            stdData.Show();
            this.Hide();
        }
    }
}
