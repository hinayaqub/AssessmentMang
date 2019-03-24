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
    public partial class AddAssessment : Form
    {
        public AddAssessment()
        {
            InitializeComponent();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddAssesm();
        }

        public void AddAssesm()

        {

            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog = ProjectB ; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();
            int status;
            if (comboBox1.Text == "Active")
            {
                status = 5;
            }
            else
            {
                status = 6;
            }
            String cmd1 = "insert into Assessment values ('" + comboBox1.Text + "','" + Convert.ToDateTime(dateTimePicker1.Text)+ "','" + textBox1.Text + "','" +
            comboBox3.Text + "')";

            SqlCommand cmd = new SqlCommand(cmd1, conn1);
            int i = cmd.ExecuteNonQuery();
            conn1.Close();
            if (i != 0)
            {
                MessageBox.Show(i + "Record Has Been Saved");
            }
            StudentsDetails s1 = new StudentsDetails();
            s1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void AddAssessment_Load(object sender, EventArgs e)
        {
            Showdata();
            Editbtn();
            Deletebtn();
            AddAssCompbtn();
        }
        public void Showdata()
        {
            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();
            String cmd1 = "SELECT * FROM Assessment";
            //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
            SqlCommand cmd = new SqlCommand(cmd1, conn1);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn1.Close();
            dataGridView1.DataSource = dt;
        }
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

        // Add Assessment Component's Button
        public void AddAssCompbtn()
        {
            DataGridViewButtonColumn b1 = new DataGridViewButtonColumn();
            b1.HeaderText = "Add Assessment Component";
            b1.Name = "Add";
            b1.Text = "Add";
            b1.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(b1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selected_row = dataGridView1.Rows[index];
            string id = selected_row.Cells[0].Value.ToString();

            Int32.TryParse(id, out MyClass.assess);

            if (e.ColumnIndex == 5)
            {
                if (DialogResult.Yes == MessageBox.Show("Do you want to edit the row?", "", MessageBoxButtons.YesNo))
                {
                    Editrubric cl = new Editrubric();
                    cl.Show();
                    this.Hide();
                }
            }
            else if (e.ColumnIndex == 6)
            {
                if (DialogResult.Yes == MessageBox.Show("Do you want to delete the row?", "", MessageBoxButtons.YesNo))
                {
                    String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
                    //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
                    SqlConnection conn1 = new SqlConnection(conURL1);
                    conn1.Open();

                    String cmd1 = "Delete FROM Assessment Where Id = " + MyClass.assess;
                    //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
                    SqlDataAdapter cmd = new SqlDataAdapter(cmd1, conn1);
                    cmd.SelectCommand.ExecuteNonQuery();
                    conn1.Close();
                    MessageBox.Show("Data Has been successfuly deleted");
                }
            }
            else if (e.ColumnIndex == 7)
            {
                AssessCompo r1 = new AssessCompo();
                r1.Show();
                this.Hide();
            }
        }
    }
}
