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
    public partial class Editasscomp : Form
    {
        public Editasscomp()
        {
            InitializeComponent();
        }

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
            SqlDataReader sd = cmd02.ExecuteReader();
            while (sd.Read())
            {
                comboBox2.Items.Add(sd[0]);

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
                comboBox1.Text = myReader.GetValue(1).ToString();
                comboBox2.Text = myReader.GetValue(2).ToString();
                comboBox3.Text = myReader.GetValue(3).ToString();
                dateTimePicker1.Text = myReader.GetValue(4).ToString();
                Rubric();
                cmd.Dispose();
                conn1.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        ///
        public void Rubric()
        {
            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();

            String cmd1 = "SELECT Details FROM Rubric Where Id = '" + comboBox2.Text + "'";
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
                comboBox2.Text = myReader.GetValue(0).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "")
            {
                RubricId();
                AddAssComp();
                AssessCompo a1 = new AssessCompo();
                a1.Show();
                this.Hide();
            }
        }

        public void RubricId()
        {
            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();

            String cmd1 = "SELECT Id FROM Rubric Where Details = '" + comboBox2.Text + "'";
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
        public void AddAssComp()

        {

            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog = ProjectB ; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();
            DateTime localDate = DateTime.Now;
            
            String cmd1 = "update AssessmentComponent set Name='" + comboBox1.Text + "', RubricId = '"+MyClass.rubric+ "', TotalMarks = '" + comboBox3.Text + "',DateCreated ='" + Convert.ToDateTime(dateTimePicker1.Text) + "',  DateUpdated= '" + localDate + "' Where  AssessmentComponent.Id = '" + MyClass.assmcomp + "'";
            SqlCommand cmd = new SqlCommand(cmd1, conn1);
            int i = cmd.ExecuteNonQuery();
            conn1.Close();
            if (i != 0)
            {
                MessageBox.Show(i + "Record Has Been Saved");
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

        private void comboBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox2.Text))
            {
                e.Cancel = true;
                comboBox2.Focus();
                errorProvider1.SetError(comboBox2, "Field should not be left blank!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(comboBox2, "");
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

