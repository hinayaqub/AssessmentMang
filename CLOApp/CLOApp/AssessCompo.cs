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
    public partial class AssessCompo : Form
    {
        public AssessCompo()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AssessCompo_Load(object sender, EventArgs e)
        {
            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();
            String cmd1 = "SELECT Id From Rubric";
            //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
            SqlCommand cmd = new SqlCommand(cmd1, conn1);
            SqlDataReader sda = cmd.ExecuteReader();
            while (sda.Read())
            {
                comboBox2.Items.Add(sda[0]);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddAssComp();
        }

        public void AddAssComp()

        {

            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog = ProjectB ; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();
            String cmd1 = "insert into AssessmentComponent values ('" +comboBox1.Text + "','" +comboBox2.Text + "','" +comboBox3.Text + "','" +Convert.ToDateTime(dateTimePicker1.Text)+ "','" + Convert.ToDateTime(dateTimePicker1.Text) + "','" +MyClass.assess + "')";

            SqlCommand cmd = new SqlCommand(cmd1, conn1);
            int i = cmd.ExecuteNonQuery();
            conn1.Close();
            if (i != 0)
            {
                MessageBox.Show(i + "Record Has Been Saved");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
