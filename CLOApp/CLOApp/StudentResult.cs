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
    public partial class StudentResult : Form
    {
        public StudentResult()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StudentResult_Load(object sender, EventArgs e)
        {
            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();
           

            String cmd2 = "SELECT Details From RubricLevel";
            //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
            SqlCommand cmd02 = new SqlCommand(cmd2, conn1);
            SqlDataReader sd = cmd02.ExecuteReader();
            while (sd.Read())
            {
                comboBox3.Items.Add(sd[0]);

            }

            String cmd3 = "SELECT RegistrationNumber From Student";
            //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
            SqlCommand cmd03 = new SqlCommand(cmd3, conn1);
            SqlDataReader nsd = cmd03.ExecuteReader();
            while (nsd.Read())
            {
                comboBox1.Items.Add(nsd[0]);

            }


            String cmd4 = "SELECT Title From Assessment";
            //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
            SqlCommand cmd04 = new SqlCommand(cmd4, conn1);
            SqlDataReader nad = cmd04.ExecuteReader();
            while (nad.Read())
            {
                comboBox4.Items.Add(nad[0]);

            }

            conn1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StdId();
            AssessmentId();
            AssessmentComp();
            Rubriclevel();
            AddStdRes();

        }


        public void AddStdRes()

        {

            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog = ProjectB ; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();
            String cmd1 = "insert into StudentResult values ('" + MyClass.Assstd+ "','" + MyClass.assmcomp + "','" +
            MyClass.rubriclvl + "','" + Convert.ToDateTime(dateTimePicker1.Text) + "')";

            SqlCommand cmd = new SqlCommand(cmd1, conn1);
            int i = cmd.ExecuteNonQuery();
            conn1.Close();
            if (i != 0)
            {
                MessageBox.Show(i + "Record Has Been Saved");
            }


        }

        // Function to Show data in Grid View 
        // From database
        public void Showdata()
        {
            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();
            String cmd1 = "SELECT * FROM StudentResult";
            //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
            SqlCommand cmd = new SqlCommand(cmd1, conn1);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridView1.DataSource = dt;
            conn1.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "")
            {
                MyClass.asscomp = comboBox4.Text;
                String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
                //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
                SqlConnection conn1 = new SqlConnection(conURL1);
                conn1.Open();

                String cmd1 = "SELECT Id FROM Assessment Where Title = '" + MyClass.asscomp + "'";
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
                    MyClass.assmcomp = Convert.ToInt32(myReader.GetValue(0).ToString());

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                string cmd6 = "SELECT Name From AssessmentComponent Where AssessmentId = " + MyClass.assmcomp;
                //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
                SqlCommand cmd06 = new SqlCommand(cmd6, conn1);
                SqlDataReader ass = cmd06.ExecuteReader();
                while (ass.Read())
                {
                    comboBox2.Items.Add(ass[0]);

                }
            }

        }

        public void StdId()
        {
            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();

            String cmd1 = "SELECT Id FROM Student Where RegistrationNumber = '" + comboBox1.Text+ "'";
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
                MyClass.Assstd = Convert.ToInt32(myReader.GetValue(0).ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void AssessmentId()
        {
            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();

            String cmd1 = "SELECT Id FROM Assessment Where Title = '" + comboBox4.Text + "'";
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
                MyClass.Assid = Convert.ToInt32(myReader.GetValue(0).ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// 
        /// </summary>

        public void AssessmentComp()
        {
            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();

            String cmd1 = "SELECT Id FROM AssessmentComponent Where Name = '" + comboBox2.Text + "'";
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
                MyClass.AssCompid = Convert.ToInt32(myReader.GetValue(0).ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        ////
        public void Rubriclevel()
        {
            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();

            String cmd1 = "SELECT Id FROM RubricLevel Where Details = '" + comboBox3.Text + "'";
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
                MyClass.rubriclvl = Convert.ToInt32(myReader.GetValue(0).ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
  
    }
}