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
            int status = 0;
            if (comboBox1.Text == "Active")
            {
                status = 1;
            }
            else
            {
                status = 0;
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
        }
    }
}
