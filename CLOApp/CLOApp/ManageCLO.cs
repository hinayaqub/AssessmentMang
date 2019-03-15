﻿using System;
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
    public partial class ManageCLO : Form
    {
        public ManageCLO()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateCLO c1 = new CreateCLO();
            c1.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selected_row = dataGridView1.Rows[index];
            string id = selected_row.Cells[0].Value.ToString();
            
            Int32.TryParse(id, out MyClass.CLOid);
           
            if (e.ColumnIndex == 4)
            {
                if (DialogResult.Yes == MessageBox.Show("Do you want to edit the row?", "", MessageBoxButtons.YesNo))
                {
                    EditClo cl = new EditClo();
                    cl.Show();
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

                    String cmd1 = "Delete FROM  Clo Where Clo.Id = " + MyClass.CLOid;
                    //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
                    SqlDataAdapter cmd = new SqlDataAdapter(cmd1, conn1);
                    cmd.SelectCommand.ExecuteNonQuery();
                    conn1.Close();
                    MessageBox.Show("Data Has been successfuly deleted");
                }
            }
            else if (e.ColumnIndex == 6)
            {
                Rubrics1 r1 = new Rubrics1();
                r1.Show();
                this.Hide();
            }
        }

        public void Showdata()
        {
            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();
            String cmd1 = "SELECT * FROM Clo";
            //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
            SqlCommand cmd = new SqlCommand(cmd1, conn1);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn1.Close();
            dataGridView1.DataSource = dt;
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

        // Create Add rubrics btn in datagridview
        public void AddRubricbtn()
        {
            DataGridViewButtonColumn b1 = new DataGridViewButtonColumn();
            b1.HeaderText = "Add Rubrics";
            b1.Name = "Add_Rubrics";
            b1.Text = "Add Rubrics";
            b1.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(b1);
        }
        private void ManageCLO_Load(object sender, EventArgs e)
        {
            Showdata();
            Editbtn();
            Deletebtn();
            AddRubricbtn();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageData f1 = new ManageData();
            f1.Show();
            this.Hide();
        }
    }
}
