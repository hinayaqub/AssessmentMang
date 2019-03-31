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
    public partial class frmAssessComponent : Form
    {
        public frmAssessComponent()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Load Data from DataBase
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AssessCompo_Load(object sender, EventArgs e)
        {

            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();


            String cmd2 = "SELECT Details From Rubric";
            //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
            SqlCommand cmd02 = new SqlCommand(cmd2, conn1);
            SqlDataReader sd = cmd02.ExecuteReader();
            while (sd.Read())
            {
                cboRubricId.Items.Add(sd[0]);

            }
            AssessmentComponent assessComp = new AssessmentComponent();
            dgvAssessmentComponent.DataSource = assessComp.Showdata();
            dgvAssessmentComponent.Columns.Add(assessComp.Editbtn());
            dgvAssessmentComponent.Columns.Add(assessComp.Deletebtn());
        }


     
        /// <summary>
        /// Insert Data of Datagridview in Table
        /// </summary>
        public void AddAssComp()

        {

            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog = ProjectB ; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();
            String cmd1 = "insert into AssessmentComponent values ('" +cboName.Text + "','" +MyClass.rubric + "','" +txtTotalMarks.Text + "','" +Convert.ToDateTime(dtpDate.Text)+ "','" + Convert.ToDateTime(dtpDate.Text) + "','" +MyClass.assess + "')";

            SqlCommand cmd = new SqlCommand(cmd1, conn1);
            int i = cmd.ExecuteNonQuery();
            conn1.Close();
            if (i != 0)
            {
                MessageBox.Show(i + "Record Has Been Saved");
            }
        }
        /// <summary>
        /// Select Rubric Id Corresspond to Rubric Detail
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selected_row = dgvAssessmentComponent.Rows[index];
            string id = selected_row.Cells[0].Value.ToString();

            Int32.TryParse(id, out MyClass.assmcomp);

            if (e.ColumnIndex == 7)
            {
                if (DialogResult.Yes == MessageBox.Show("Do you want to edit the row?", "", MessageBoxButtons.YesNo))
                {
                    frmEditAssComp c1 = new frmEditAssComp();
                    c1.Show();
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
                    String cmd2 = "Delete FROM StudentResult Where AssessmentComponentId = " + MyClass.assmcomp;
                    SqlDataAdapter cmd02 = new SqlDataAdapter(cmd2, conn1);
                    cmd02.SelectCommand.ExecuteNonQuery();
                    
                    /////
                    String cmd1 = "Delete FROM AssessmentComponent Where Id = "+MyClass.assmcomp;
                    //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
                    SqlDataAdapter cmd = new SqlDataAdapter(cmd1, conn1);
                    cmd.SelectCommand.ExecuteNonQuery();
                    conn1.Close();
                    MessageBox.Show("Data Has been successfuly deleted");
                }
            }
           
        }

       
        /// <summary>
        /// Validating of Fields
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
                cboRubricId .Focus();
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
                errorProvider1.SetError(txtTotalMarks, "Name should not be left blank!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtTotalMarks, "");
            }
        }



        private void tblLyoutPanelAssess_Paint(object sender, PaintEventArgs e)
        {

        }
        /// <summary>
        /// Insert Data from Form into Database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            RubricId();
            AddAssComp();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AssessmentComponent assessComp = new AssessmentComponent();
            dgvAssessmentComponent.DataSource = assessComp.Showdata();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAddAssessment addAssessment = new frmAddAssessment();
            addAssessment.Show();
            this.Hide();
        }

        
    }
}
