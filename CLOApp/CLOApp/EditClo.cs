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
    public partial class EditClo : Form
    {
        public EditClo()
        {
            InitializeComponent();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            SaveData();
            ManageCLO c1 = new ManageCLO();
            c1.Show();
            this.Hide();
        }
        // Edit Data of CLO
        public void SaveData()
        {
            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog = ProjectB ; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();
            DateTime localDate = DateTime.Now;
            DateTime Create = Convert.ToDateTime(dateTimePicker1.Text);
            String cmd1 = "update Clo set Name='" + comboBox1.Text + "', DateCreated= '" +Create + "', DateUpdated= '" + localDate+ "' Where  Clo.Id = '" + MyClass.CLOid + "'";

            SqlCommand cmd = new SqlCommand(cmd1, conn1);
            MessageBox.Show("Clo has been updated");

            try
            {
                cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " Record Has Been Updated ");
            }

        }

        private void EditClo_Load(object sender, EventArgs e)
        {
            EditData();

        }
        public void EditData()
        {

            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();

            String cmd1 = "SELECT * FROM Clo Where Clo.Id = " + MyClass.CLOid;
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
                comboBox1.Text = myReader.GetValue(1).ToString();
                dateTimePicker1.Value = Convert.ToDateTime(myReader.GetValue(2));
               
                


                cmd.Dispose();
                conn1.Close();


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
    }
}
