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
using System.Text.RegularExpressions;
namespace CLOApp
{
    public partial class frmEditStdDetail : Form
    {
        public frmEditStdDetail()
        {
            InitializeComponent();
        }

        private void EditStdDetail_Load(object sender, EventArgs e)
        {
            EditData();
        }
        /// <summary>
        /// Load Data At Click Event
        /// </summary>
        public void EditData()
        {
            
            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();
            
            String cmd1 = "SELECT * FROM Student Where Student.Id = "+  MyClass.count;
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
                txtFirstName.Text = myReader.GetValue(1).ToString();
                txtLsrName.Text = myReader.GetValue(2).ToString();
                txtContact.Text = myReader.GetValue(3).ToString();
                txtEmail.Text = myReader.GetValue(4).ToString();
                txtRegNo.Text = myReader.GetValue(5).ToString();
                string status = myReader.GetValue(6).ToString();
                int x = 0;
                Int32.TryParse(status, out x);
                if (x == 1)
                {
                    cboStatus.Text = "Active";
                }
                else
                {
                    cboStatus.Text = "InActive";
                }


                cmd.Dispose();
                conn1.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }
        /// <summary>
        /// Save Data Of Form After Editing
        /// </summary>
        public void SaveData()
        {
            if ((txtFirstName.Text != "") && (txtLsrName.Text != "") && (txtRegNo.Text != "") && (txtContact.Text != "") && (txtEmail.Text != "") && (cboStatus.Text != ""))
            {
                String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog = ProjectB ; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
                SqlConnection conn1 = new SqlConnection(conURL1);
                conn1.Open();
                int status = 0;
                if (cboStatus.Text == "Active")
                {
                    status = 5;
                }
                else
                {
                    status = 6;
                }
                String cmd1 = "update Student set FirstName='" + txtFirstName.Text + "', LastName= '" + txtLsrName.Text + "', Contact= '" + txtContact.Text + "',Email='" +
                txtEmail.Text + "', RegistrationNumber='" + txtRegNo.Text + "',Status='" + status + "' Where  Student.Id = '" + MyClass.count + "'";

                SqlCommand cmd = new SqlCommand(cmd1, conn1);
                MessageBox.Show("The Record Of Studdent Has been updated");
                try
                {
                    cmd.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + " Record Has Been Updated ");
                }
                frmAddStudents addStd = new frmAddStudents();
                addStd.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("All field should be field");
            }
        }
          
        /// <summary>
        /// Validation For Textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                e.Cancel = true;
                txtFirstName.Focus();
                errorProvider1.SetError(txtFirstName, "Name should not be left blank!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFirstName, "");
            }
        }

        private void txtLsrName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLsrName.Text))
            {
                e.Cancel = true;
                txtLsrName.Focus();
                errorProvider1.SetError(txtLsrName, "Name should not be left blank!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLsrName, "");
            }
        }

        private void txtContact_Validating(object sender, CancelEventArgs e)
        {
            //int ContactNo = 0;

            txtContact.MaxLength = 11;
            //Regex re = new Regex("^9[0-9]{11}");
            if (string.IsNullOrWhiteSpace(txtContact.Text))
            {
                e.Cancel = true;
                txtContact.Focus();
                errorProvider1.SetError(txtContact, "Contact Number should not be left blank!");
                return;
            }

            else if (txtContact.Text.Length > 12)
            {

                txtContact.Focus();
                errorProvider1.SetError(txtContact, "Contact Number conatin digits and  length is 11!");
                
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtContact, "");

            }


        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(txtEmail.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.txtEmail, "Please Enter Valid Email");
                return;
            }
        }

        private void txtRegNo_Validating(object sender, CancelEventArgs e)
        {
            string pattern = "^([0-9]{4})([A-Z]{2})([0-9]{3})$";
            if (Regex.IsMatch(txtRegNo.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.txtRegNo, "Please Enter Registration Number In e.g. 2016CS352 Format");
                return;
            }
        }

        private void cboStatus_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboStatus.Text))
            {
                e.Cancel = true;
                cboStatus.Focus();
                errorProvider1.SetError(cboStatus, "Field should not be left blank!");
                return;
            }
        }

       

        

        private void txtRegNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }
    }
}
