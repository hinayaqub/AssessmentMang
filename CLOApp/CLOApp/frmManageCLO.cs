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
    public partial class frmManageCLO : Form
    {
        public frmManageCLO()
        {
            InitializeComponent();
        }


        
       
       
        private void ManageCLO_Load(object sender, EventArgs e)
        {
            CLO clo = new CLO();
            dgvCLO.DataSource = clo.Showdata();
            dgvCLO.Columns.Add(clo.Editbtn());
            dgvCLO.Columns.Add(clo.Deletebtn());
            dgvCLO.Columns.Add(clo.AddRubricbtn());


        }



        public void AddCLo()
        {
            if ((cboTitle.Text != "") && (rtbDescription.Text != ""))
            {
                String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog = ProjectB ; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
                SqlConnection conn1 = new SqlConnection(conURL1);
                conn1.Open();
                DateTime localDate = DateTime.Now;
                String cmd1 = "insert into Clo values ('" + cboTitle.Text + "','" + localDate + "','" + localDate + "')";
                MyClass.Details = rtbDescription.Text;
                SqlCommand cmd = new SqlCommand(cmd1, conn1);
                int i = cmd.ExecuteNonQuery();
                conn1.Close();
                if (i != 0)
                {
                    MessageBox.Show(i + "Record Has Been Saved");
                }
            }
        }

        

       
        /// <summary>
        /// Fetch Data from Database at Form Loading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CLO clo = new CLO();
            dgvCLO.DataSource = clo.Showdata();
        }
        /// <summary>
        /// On click Edit , Delete and Update Data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCLO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selected_row = dgvCLO.Rows[index];
            string id = selected_row.Cells[0].Value.ToString();
            Int32.TryParse(id, out MyClass.CLOid);
            CLO clo = new CLO();
            if (e.ColumnIndex == 4)
            {
                clo.EditCLO();
                this.Hide();
            }
            else if (e.ColumnIndex == 5)
            {
                clo.DeleteCLO();
            }
            else if (e.ColumnIndex == 6)
            {
                frmRubrics1 r1 = new frmRubrics1();
                r1.Show();
                this.Hide();
            }
        }

        private void lblCLO_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmStudentMangForm stdMang = new frmStudentMangForm();
            stdMang.Show();
            this.Hide();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            AddCLo();
        }
        /// <summary>
        /// Validation of comobox
        /// and richerTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboTitle.Text))
            {
                e.Cancel = true;
                cboTitle.Focus();
                errorProvider1.SetError(cboTitle, "Field should not be left blank!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cboTitle, "");
            }
        }

        private void rtbDesvription_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                e.Cancel = true;
                rtbDescription.Focus();
                errorProvider1.SetError(rtbDescription, "Field should not be left blank!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(rtbDescription, "");
            }
        }
    }
}
