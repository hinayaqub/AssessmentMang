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
    public partial class frmEditAssComp : Form
    {
        public frmEditAssComp()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Load Data from Database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Editasscomp_Load(object sender, EventArgs e)
        {
            EditData();
         }

        public void EditData()
        {

            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();
            String cmd2 = "SELECT Details From Rubric";
            //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
            SqlCommand cmd02 = new SqlCommand(cmd2, conn1);
            SqlDataReader sqlData = cmd02.ExecuteReader();
            while (sqlData.Read())
            {
                cboRubricId.Items.Add(sqlData[0]);

            }


            String cmd1 = "SELECT * FROM AssessmentComponent Where Id = " + MyClass.assmcomp;
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
                cboName.Text = myReader.GetValue(1).ToString();
                cboRubricId.Text = myReader.GetValue(2).ToString();
                txtTotalMarks.Text = myReader.GetValue(3).ToString();
                dtpDate.Text = myReader.GetValue(4).ToString();
                Rubric();
                cmd.Dispose();
                conn1.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        /// <summary>
        /// Select Detials from Given Rubric Level
        /// </summary>
        public void Rubric()
        {
            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();

            String cmd1 = "SELECT Details FROM Rubric Where Id = '" + cboRubricId.Text + "'";
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
                cboRubricId.Text = myReader.GetValue(0).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Select RubricId from Given Rubric Level
        /// </summary>

        public void RubricId()
        {
            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();

            String cmd1 = "SELECT Id FROM Rubric Where Details = '" + cboRubricId.Text + "'";
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
                MyClass.rubric = Convert.ToInt32(myReader.GetValue(0).ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Add Edit Data of form into Database
        /// </summary>
        public void AddAssComp()

        {

            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog = ProjectB ; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();
            DateTime localDate = DateTime.Now;
            
            String cmd1 = "update AssessmentComponent set Name='" + cboName.Text + "', RubricId = '"+MyClass.rubric+ "', TotalMarks = '" + txtTotalMarks.Text + "',DateCreated ='" + Convert.ToDateTime(dtpDate.Text) + "',  DateUpdated= '" + localDate + "' Where  AssessmentComponent.Id = '" + MyClass.assmcomp + "'";
            SqlCommand cmd = new SqlCommand(cmd1, conn1);
            int i = cmd.ExecuteNonQuery();
            conn1.Close();
            if (i != 0)
            {
                MessageBox.Show(i + "Record Has Been Saved");
            }
        }

        /// <summary>
        /// Validation of Input fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboName.Text))
            {
                e.Cancel = true;
                cboName.Focus();
                errorProvider1.SetError(cboName, "Field should not be left blank!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cboName, "");
            }
        }

        private void cboRubricId_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboRubricId.Text))
            {
                e.Cancel = true;
                cboRubricId.Focus();
                errorProvider1.SetError(cboRubricId, "Field should not be left blank!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cboRubricId, "");
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

        /// <summary>
        /// Save edit data into Database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboName.Text != "" && cboRubricId.Text != "" && txtTotalMarks.Text != "")
            {
                RubricId();
                AddAssComp();
                frmAssessComponent a1 = new frmAssessComponent();
                a1.Show();
                this.Hide();
            }
        }
    }
}

