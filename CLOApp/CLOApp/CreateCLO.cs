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
    public partial class CreateCLO : Form
    {
        public CreateCLO()
        {
            InitializeComponent();
        }

        private void ManageCLO_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RubricsLevel1 r1 = new RubricsLevel1();
            r1.Show();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog = ProjectB ; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();
            DateTime localDate = DateTime.Now;
            String cmd1 = "insert into Clo values ('" + comboBox1.Text + "','" + localDate + "','" + localDate + "')";
            MyClass.Details = richTextBox1.Text;
            SqlCommand cmd = new SqlCommand(cmd1, conn1);
            int i = cmd.ExecuteNonQuery();
            conn1.Close();
            if (i != 0)
            {
                MessageBox.Show(i + "Record Has Been Saved");
            }
            ManageCLO cl = new ManageCLO();
            cl.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
