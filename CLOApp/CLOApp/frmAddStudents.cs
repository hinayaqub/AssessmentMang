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
    public partial class frmAddStudents : Form
    {
        public frmAddStudents()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        // Add Student Data using Function AddStd
        private void btnSave_Click(object sender, EventArgs e)
        {
            AddStd();
            
        }

    // Function to add Student
    public void AddStd()
    {
        if ((txtFirstName.Text != "") && (txtLsrName.Text != "") && (txtContact.Text != "") && (txtRegNo.Text != "") && (txtEmail.Text != "") && (cboStatus.Text != ""))
        {
            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog = ProjectB ; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();
            int status;
            if (cboStatus.Text == "Active")
            {
                status = 5;
            }
            else
            {
                status = 6;
            }
            String cmd1 = "insert into Student values ('" + txtFirstName.Text + "','" + txtLsrName.Text + "','" + txtContact.Text + "','" +
            txtEmail.Text + "','" + txtRegNo.Text + "','" + status + "')";

            SqlCommand cmd = new SqlCommand(cmd1, conn1);
            int i = cmd.ExecuteNonQuery();
            conn1.Close();
            if (i != 0)
            {
                MessageBox.Show(i + "Record Has Been Saved");
            }
                txtFirstName.Text = "";
                txtLsrName.Text = "";
                txtRegNo.Text = "";
                txtContact.Text = "";
                txtEmail.Text = "";
                cboStatus.Text = "";
            }
            
            else
            {
                MessageBox.Show("Fields Shold not Eempty!");
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

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

        public void Validation()
        {

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(txtFirstName.Text, "Demo App - Message!");

            }
        }

        public void Validation1()
        {

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(txtLsrName.Text, "Demo App - Message!");

            }
        }

        public void Validation2()
        {

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(txtContact.Text, "Demo App - Message!");

            }
        }

        public void Validation3()
        {

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(txtRegNo.Text, "Demo App - Message!");

            }
        }


        private void txtContact_Validating(object sender, CancelEventArgs e)
        {
            //int ContactNo=0;

            txtContact.MaxLength = 11;
            Regex re = new Regex("^9[0-9]{11}");
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
            /*
              else if (!int.TryParse(textBox3.Text.Trim(), out ContactNo))
              {

                  e.Cancel = true;
                  textBox3.Focus();
                  errorProvider1.SetError(textBox3, "Contact Number should numbers!");
                  return;
              }/*
              else if (textBox3.TextLength != textBox3.MaxLength)
              {
                  e.Cancel = true;
                  textBox3.Focus();
                  errorProvider1.SetError(textBox3, "Contact Number should be 11 digits!");
                  return;
              }*/

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtContact, "");

            }






        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
           
        }

        private void txtRegNo_Leave(object sender, EventArgs e)
        {

           

        }

        private void AddStudents_Load(object sender, EventArgs e)
        {
            StudentInfo stdInfo = new StudentInfo();
            dgvStdInfo.DataSource = stdInfo.Showdata();
            dgvStdInfo.Columns.Add(stdInfo.Editbtn());
            dgvStdInfo.Columns.Add(stdInfo.Deletebtn());
        }

        private void cboStatus_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboStatus.Text))
            {
                e.Cancel = true;
                cboStatus.Focus();
                errorProvider1.SetError(cboStatus, "Contact Number should not be left blank!");
                return;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmStudentMangForm mangData = new frmStudentMangForm();
            mangData.Show();
            this.Hide();
        }

        private void dgvStdInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selected_row = dgvStdInfo.Rows[index];
            string id = selected_row.Cells[0].Value.ToString();
            int x;
            Int32.TryParse(id, out x);
            MyClass.count = x;
            StudentInfo stdInfo = new StudentInfo();
            if (e.ColumnIndex == 7)
            {
                stdInfo.EditStdData();
                this.Hide();
            }
            else if (e.ColumnIndex == 8)
            {
                stdInfo.DeleteStdData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            StudentInfo stdInfo = new StudentInfo();
            dgvStdInfo.DataSource = stdInfo.Showdata();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click_1(object sender, EventArgs e)
        {

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

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
