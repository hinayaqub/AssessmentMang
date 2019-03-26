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
    public partial class AddRubricLevel : Form
    {
        public AddRubricLevel()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "" && comboBox4.Text != "" && richTextBox1.Text != "" &&
                richTextBox2.Text != "" && richTextBox3.Text != "" && richTextBox4.Text != "")
            {
                AddRubricLevels();
            }
        }


        // Function to add Student
        public void AddRubricLevels()

        {
            int z = MyClass.rubricId;
            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog = ProjectB ; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();
            String cmd1 = "insert into RubricLevel values ('"+z+"','" + richTextBox1.Text + "','" + comboBox1.Text + "')";
            String cmd2 = "insert into RubricLevel values ('" + z + "','" + richTextBox2.Text + "','" + comboBox2.Text + "')";
            String cmd3 = "insert into RubricLevel values ('" + z + "','" + richTextBox3.Text + "','" + comboBox3.Text + "')";
            String cmd4 = "insert into RubricLevel values ('" + z + "','" + richTextBox4.Text + "','" + comboBox4.Text + "')";
            SqlCommand cmd01 = new SqlCommand(cmd1, conn1);
            SqlCommand cmd02 = new SqlCommand(cmd2, conn1);
            SqlCommand cmd03 = new SqlCommand(cmd3, conn1);
            SqlCommand cmd04 = new SqlCommand(cmd4, conn1);
            int i = cmd01.ExecuteNonQuery();
            cmd02.ExecuteNonQuery();
            cmd03.ExecuteNonQuery();
            cmd04.ExecuteNonQuery();
            conn1.Close();
            if (i != 0)
            {
                MessageBox.Show(i + "Record Has Been Saved");
            }
            RubricLevelDetail s1 = new RubricLevelDetail();
            s1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RubricLevelDetail r1 = new RubricLevelDetail();
            r1.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

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

        private void richTextBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(richTextBox2.Text))
            {
                e.Cancel = true;
                richTextBox2.Focus();
                errorProvider1.SetError(richTextBox2, "Field should not be left blank!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(richTextBox2, "");
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

        private void richTextBox3_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(richTextBox3.Text))
            {
                e.Cancel = true;
                richTextBox3.Focus();
                errorProvider1.SetError(richTextBox3, "Field should not be left blank!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(richTextBox3, "");
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

        private void richTextBox4_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(richTextBox4.Text))
            {
                e.Cancel = true;
                richTextBox4.Focus();
                errorProvider1.SetError(richTextBox4, "Field should not be left blank!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(richTextBox4, "");
            }
        }

        private void comboBox4_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox4.Text))
            {
                e.Cancel = true;
                comboBox4.Focus();
                errorProvider1.SetError(comboBox4, "Field should not be left blank!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(comboBox4, "");
            }
        }
    }
}