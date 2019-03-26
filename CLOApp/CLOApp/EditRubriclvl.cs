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
    public partial class EditRubriclvl : Form
    {
        public EditRubriclvl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && richTextBox1.Text != "")
            {
                SaveData();
                RubricLevelDetail r1 = new RubricLevelDetail();
                r1.Show();
                this.Hide();
            }
        }

        private void EditRubriclvl_Load(object sender, EventArgs e)
        {
            EditData();
        }

        public void EditData()
        {

            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();

            String cmd1 = "SELECT * FROM RubricLevel Where RubricLevel.Id = " + MyClass.rubriclevelId;
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
                richTextBox1.Text = myReader.GetValue(2).ToString();
                comboBox1.Text = myReader.GetValue(3).ToString();
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
            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog = ProjectB ; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();

            String cmd1 = "update RubricLevel set Details='" + richTextBox1.Text + "' , MeasurementLevel='"+comboBox1.Text+"'  Where  RubricLevel.Id = '" + MyClass.rubriclevelId + "'";

            SqlCommand cmd = new SqlCommand(cmd1, conn1);
            MessageBox.Show("Rubric has been Updated");

            try
            {
                cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " Record Has Been Updated ");
            }

        }

        private void richTextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                e.Cancel = true;
                richTextBox1.Focus();
                errorProvider1.SetError(richTextBox1, "Field should not be left blank!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(richTextBox1, "");
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
    }
}
