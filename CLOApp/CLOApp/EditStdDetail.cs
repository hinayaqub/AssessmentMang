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
    public partial class EditStdDetail : Form
    {
        public EditStdDetail()
        {
            InitializeComponent();
        }

        private void EditStdDetail_Load(object sender, EventArgs e)
        {
            EditData();
        }
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
                textBox1.Text = myReader.GetValue(1).ToString();
                textBox2.Text = myReader.GetValue(2).ToString();
                textBox3.Text = myReader.GetValue(3).ToString();
                textBox6.Text = myReader.GetValue(4).ToString();
                textBox5.Text = myReader.GetValue(5).ToString();
                string status = myReader.GetValue(6).ToString();
                int x = 0;
                Int32.TryParse(status, out x);
                if (x == 1)
                {
                    comboBox1.Text = "Active";
                }
                else
                {
                    comboBox1.Text = "InActive";
                }


                cmd.Dispose();
                conn1.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }
        // Edit Data of Student
        public void SaveData()
        {
            if ((textBox1.Text != "") && (textBox2.Text != "") && (textBox3.Text != "") && (textBox5.Text != "") && (textBox6.Text != "") && (comboBox1.Text != ""))
            {
                String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog = ProjectB ; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
                SqlConnection conn1 = new SqlConnection(conURL1);
                conn1.Open();
                int status = 0;
                if (comboBox1.Text == "Active")
                {
                    status = 5;
                }
                else
                {
                    status = 6;
                }
                String cmd1 = "update Student set FirstName='" + textBox1.Text + "', LastName= '" + textBox2.Text + "', Contact= '" + textBox3.Text + "',Email='" +
                textBox6.Text + "', RegistrationNumber='" + textBox5.Text + "',Status='" + status + "' Where  Student.Id = '" + MyClass.count + "'";

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
                StudentsDetails d1 = new StudentsDetails();
                d1.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("All field should be field");
            }
        }
          
        private void button1_Click(object sender, EventArgs e)
        {
            SaveData();
          
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Name should not be left blank!");
                return;
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
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox2, "");
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            //int ContactNo = 0;

            textBox3.MaxLength = 11;
            //Regex re = new Regex("^9[0-9]{11}");
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                e.Cancel = true;
                textBox3.Focus();
                errorProvider1.SetError(textBox3, "Contact Number should not be left blank!");
                return;
            }

            else if (textBox3.Text.Length > 12)
            {

                textBox3.Focus();
                errorProvider1.SetError(textBox3, "Contact Number conatin digits and  length is 11!");
                
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox3, "");

            }


        }

        private void textBox6_Validating(object sender, CancelEventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(textBox6.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.textBox6, "Please Enter Valid Email");
                return;
            }
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
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

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                e.Cancel = true;
                textBox3.Focus();
                errorProvider1.SetError(comboBox1, "Field should not be left blank!");
                return;
            }
        }
    }
}
