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
    public partial class Editassess : Form
    {
        public Editassess()
        {
            InitializeComponent();
        }

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
                comboBox1.Text = myReader.GetValue(1).ToString();
                dateTimePicker1.Text = myReader.GetValue(2).ToString();
                textBox1.Text = myReader.GetValue(3).ToString();
                comboBox3.Text = myReader.GetValue(4).ToString();


                cmd.Dispose();
                conn1.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        public void SaveData()
        {
            if ((textBox1.Text != "") && (comboBox1.Text != "") && (comboBox3.Text != ""))
            {
                String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog = ProjectB ; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
                SqlConnection conn1 = new SqlConnection(conURL1);
                conn1.Open();
                
                String cmd1 = "update Assessment set Title='" +comboBox1.Text + "', DateCreated= '" +Convert.ToDateTime(dateTimePicker1.Text)+ "',TotalMarks= '" + textBox1.Text + "',TotalWeightage='" +
                comboBox3.Text + "' Where Id = '" + MyClass.assess + "'";

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
                AddAssessment d1 = new AddAssessment();
                d1.Show();
                this.Hide();

            }

            
            else
            {
                MessageBox.Show("All field should be field");
            }
        }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                e.Cancel = true;
                comboBox1.Focus();
                errorProvider1.SetError(comboBox1, "Field should not be left blank!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(comboBox1, "");
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Field should not be left blank!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, "");
            }
        }

        private void comboBox3_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox3.Text))
            {
                e.Cancel = true;
                comboBox3.Focus();
                errorProvider1.SetError(comboBox3, "Field should not be left blank!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(comboBox3, "");
            }
        }
    }
    }
