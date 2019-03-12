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
    public partial class CreateAtte : Form
    {
        public CreateAtte()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CreateAtte_Load(object sender, EventArgs e)
        {
          
            Showdata();
            checkbox();
        }
        public void Showdata()
        {
            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();
            String cmd1 = "SELECT RegistrationNumber FROM Student";
            //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
            SqlCommand cmd = new SqlCommand(cmd1, conn1);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn1.Close();
            dataGridView1.DataSource = dt;

        }
        public void checkbox()
        {
            DataGridViewCheckBoxColumn b1 = new DataGridViewCheckBoxColumn();
            b1.HeaderText = "Attendence Mark";
            b1.Name = "Attendence_Mark";
            b1.ThreeState = false;

           
           
            dataGridView1.Columns.Add(b1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                bool isCellChecked = (bool)dataGridView1.Rows[i].Cells[1].Value;
                if (isCellChecked == true)
                {
                    MessageBox.Show("Is Checked");
                }
                else
                {
                    MessageBox.Show("Is Not Chiked");
                }
            }
        }
    }
}
