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
    public partial class AddStudents : Form
    {
        public AddStudents()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        // Add Student Data using Function AddStd
        private void button1_Click(object sender, EventArgs e)
        {
            AddStd();

        }

        // Function to add Student
        public void AddStd()

        {
            
            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog = ProjectB ; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();
            int status;
            if (comboBox1.Text == "Active")
            {
                status = 5;
            }
            else
            {
                status = 6;
            }
            String cmd1 = "insert into Student values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" +
            textBox6.Text + "','" + textBox5.Text + "','" + status + "')";

            SqlCommand cmd = new SqlCommand(cmd1, conn1);
            int i = cmd.ExecuteNonQuery();
            conn1.Close();
            if (i != 0)
            {
                MessageBox.Show(i + "Record Has Been Saved");
            }
            StudentsDetails s1 = new StudentsDetails();
            s1.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, "");
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                e.Cancel = true;
                textBox2.Focus();
                errorProvider1.SetError(textBox2, "Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox2, "");
            }
        }

        public void Validation()
        {
            
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(textBox1.Text, "Demo App - Message!");

            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                e.Cancel = true;
                textBox3.Focus();
                errorProvider1.SetError(textBox3, "Contact Number should not be left blank!");
                return;
            }
            else
            {
                int ContactNo;
                textBox3.MaxLength = 11;
                if (!int.TryParse(textBox3.Text, out ContactNo))
                {

                    e.Cancel = true;
                    textBox3.Focus();
                    errorProvider1.SetError(textBox3, "Contact Number should numbers!");
                    return;
                }

                
                else if (textBox3.TextLength!=textBox3.MaxLength)
                {
                    e.Cancel = true;
                    textBox3.Focus();
                    errorProvider1.SetError(textBox3, "Contact Number should be 11 digits!");
                    return;
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(textBox3, "");
                }
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(textBox6.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else {
                errorProvider1.SetError(this.textBox6, "Please Enter Valid Email");
                return;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {

            string pattern = "^([0-9]{4})([A-Z]{2})([0-9]{3})$";
            if (Regex.IsMatch(textBox5.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.textBox5, "Please Enter Registration Number In e.g. 2016CS352 Format");
                return;
            }

        }

        private void AddStudents_Load(object sender, EventArgs e)
        {

        }
    }
}
