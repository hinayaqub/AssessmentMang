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
    public partial class frmRubricDetails : Form
    {
        public frmRubricDetails()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selected_row = dataGridView1.Rows[index];
            string id = selected_row.Cells[1].Value.ToString();

            Int32.TryParse(id, out MyClass.rubricId);

            if (e.ColumnIndex == 3)
            {
                if (DialogResult.Yes == MessageBox.Show("Do you want to edit the row?", "", MessageBoxButtons.YesNo))
                {
                    frmEditRubric cl = new frmEditRubric();
                    cl.Show();
                    this.Hide();
                }
            }
            else if (e.ColumnIndex == 4)
            {
                if (DialogResult.Yes == MessageBox.Show("Do you want to delete the row?", "", MessageBoxButtons.YesNo))
                {
                    String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
                    //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
                    SqlConnection conn1 = new SqlConnection(conURL1);
                    conn1.Open();
                    ////
                    String asscompId = "SELECT Id FROM RubricLevel Where RubricId = " + MyClass.rubricId;
                    SqlCommand sqlCmd = new SqlCommand(asscompId, conn1);
                    SqlDataReader myReader;
                    myReader = sqlCmd.ExecuteReader();
                    if (!myReader.Read())
                    {
                        int i = 0;
                    }
                    else
                    {

                        try
                        {

                            MyClass.rubriclevelId = Convert.ToInt32(myReader.GetValue(0).ToString());
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }

                    String std = "Delete FROM  StudentResult Where RubricMeasurementId = " + MyClass.rubriclevelId;
                    //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
                    SqlDataAdapter sqlDataAdap = new SqlDataAdapter(std, conn1);
                    sqlDataAdap.SelectCommand.ExecuteNonQuery();

                    String asscomp = "Delete FROM  AssessmentComponent Where RubricId = " + MyClass.rubricId;
                    //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
                    SqlDataAdapter sqlData = new SqlDataAdapter(asscomp, conn1);
                    sqlData.SelectCommand.ExecuteNonQuery();

                    String rublvl = "Delete FROM RubricLevel Where RubricId = "+ MyClass.rubricId;
                    //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
                    SqlDataAdapter sqlDataAdapt = new SqlDataAdapter(rublvl, conn1);
                    sqlDataAdapt.SelectCommand.ExecuteNonQuery();

                    String cmd1 = "Delete FROM Rubric Where Rubric.Id = " + MyClass.rubricId;
                    //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
                    SqlDataAdapter cmd = new SqlDataAdapter(cmd1, conn1);
                    cmd.SelectCommand.ExecuteNonQuery();
                    conn1.Close();
                    MessageBox.Show("Data Has been successfuly deleted");
                }
            }
            else if (e.ColumnIndex == 5)
            {
             frmAddRubricLevel r1 = new frmAddRubricLevel();
                r1.Show();
                this.Hide();
            }
        }

        private void RubricDetails_Load(object sender, EventArgs e)
        {
            Showdata();
            Editbtn();
            Deletebtn();
            AddRubriclvlbtn();
        }
        public void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //I suppose the group column is column at index 0
            if (e.ColumnIndex == 0 && e.RowIndex > 0)
            {
                if (dataGridView1[0, e.RowIndex].Value == dataGridView1[0, e.RowIndex - 1].Value)
                    e.Value = "";
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
            String cmd1 = "SELECT CloId , Id as RubricId , Details FROM Rubric";
            //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
            SqlCommand cmd = new SqlCommand(cmd1, conn1);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            this.dataGridView1.DataSource = dt;
            //this.dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Ascending);
            foreach (DataGridViewColumn column in this.dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            this.dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            conn1.Close();
            //dataGridView1.DataSource = dt;
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
        // Add Rubric's Level's Button
        public void AddRubriclvlbtn()
        {
            DataGridViewButtonColumn b1 = new DataGridViewButtonColumn();
            b1.HeaderText = "Rubric'sLevel";
            b1.Name = "AddRubric'sLevel";
            b1.Text = "AddRubric'sLevel";
            b1.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(b1);
        }

        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Showdata();
           

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmRubrics1 rubric = new frmRubrics1();
            rubric.Show();
            this.Hide();
        }
    }
}
        
