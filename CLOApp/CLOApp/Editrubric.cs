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
    public partial class Editrubric : Form
    {
        public Editrubric()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Editrubric_Load(object sender, EventArgs e)
        {
            EditData();
        }
        public void EditData()
        {

            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();

            String cmd1 = "SELECT * FROM Rubric Where Rubric.Id = " + MyClass.rubricId;
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
                richTextBox1.Text = myReader.GetValue(1).ToString();
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
            RubricDetails rd = new RubricDetails();
            rd.Show();
            this.Hide();
        }
        public void SaveData()
        {
            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog = ProjectB ; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();
            
            String cmd1 = "update Rubric set Details='" + richTextBox1.Text + "' Where  Rubric.Id = '" + MyClass.rubricId + "'";

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
    }
}
