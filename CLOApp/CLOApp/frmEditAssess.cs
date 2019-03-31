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
    public partial class frmEditAssess : Form
    {
        public frmEditAssess()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fetch Data from Database in form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Editassess_Load(object sender, EventArgs e)
        {
            EditData();
        }
        public void EditData()
        {

            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();

            String cmd1 = "SELECT * FROM Assessment Where Id = " + MyClass.assess;
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
                cboTitle.Text = myReader.GetValue(1).ToString();
                dtpDate.Text = myReader.GetValue(2).ToString();
                txtTotalMarks.Text = myReader.GetValue(3).ToString();
                cboTotalWeightsge.Text = myReader.GetValue(4).ToString();
                cmd.Dispose();
                conn1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }


        public void SaveData()
        {
            if ((txtTotalMarks.Text != "") && (cboTitle.Text != "") && (cboTotalWeightsge.Text != ""))
            {
                String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog = ProjectB ; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
                SqlConnection conn1 = new SqlConnection(conURL1);
                conn1.Open();
                
                String cmd1 = "update Assessment set Title='" +cboTitle.Text + "', DateCreated= '" +Convert.ToDateTime(dtpDate.Text)+ "',TotalMarks= '" + txtTotalMarks.Text + "',TotalWeightage='" +
                cboTotalWeightsge.Text + "' Where Id = '" + MyClass.assess + "'";

                SqlCommand cmd = new SqlCommand(cmd1, conn1);
                MessageBox.Show("The Record Of Assessment Has been updated");
                try
                {
                    cmd.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + " Record Has Been Updated ");
                }
                frmAddAssessment d1 = new frmAddAssessment();
                d1.Show();
                this.Hide();

            }

            
            else
            {
                MessageBox.Show("All field should be field");
            }
        }

        private void cboTitle_Validating(object sender, CancelEventArgs e)
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

        private void cboTotalWeightsge_Validating(object sender, CancelEventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }
    }
    }
