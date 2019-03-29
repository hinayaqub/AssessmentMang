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
            String cmd1 = "insert into StudentResult values ('" + MyClass.Assstd+ "','" + MyClass.AssCompid + "','" +
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
        // Create Edit btn In datagridView
        public void Editbtn()
        {
            DataGridViewButtonColumn b1 = new DataGridViewButtonColumn();
            b1.HeaderText = "Edit Data";
            b1.Name = "Edit Data";
            b1.Text = "Edit";
            b1.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(b1);
        }

        // Create Delete btn in datagridview
        public void Deletebtn()
        {
            DataGridViewButtonColumn b1 = new DataGridViewButtonColumn();
            b1.HeaderText = "Delete Data";
            b1.Name = "Delete Data";
            b1.Text = "Delete";
            b1.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(b1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Showdata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selected_row = dataGridView1.Rows[index];
            string id = selected_row.Cells[0].Value.ToString();
            int x;
            Int32.TryParse(id, out x);
            MyClass.stdres = x;
            if (e.ColumnIndex == 4)
            {
                if (DialogResult.Yes == MessageBox.Show("Do you want to edit the row?", "", MessageBoxButtons.YesNo))
                {
                    EditStdDetail s2 = new EditStdDetail();
                    s2.Show();
                    this.Hide();
                }
            }
            else if (e.ColumnIndex == 5)
            {
                if (DialogResult.Yes == MessageBox.Show("Do you want to delete the row?", "", MessageBoxButtons.YesNo))
                {
                    String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
                    //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
                    SqlConnection conn1 = new SqlConnection(conURL1);
                    conn1.Open();

                    String cmd1 = "Delete FROM StudentResult Where StudentId = " + MyClass.stdres;
                    //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
                    SqlDataAdapter cmd = new SqlDataAdapter(cmd1, conn1);
                    cmd.SelectCommand.ExecuteNonQuery();
                    conn1.Close();
                    MessageBox.Show("Data Has been successfuly deleted");
                }
            }
        }

        private void re(object sender, EventArgs e)
        {

        }
    }
}