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
    public partial class EditStdDetail : Form
    {
        public EditStdDetail()
        {
            InitializeComponent();
        }

        private void EditStdDetail_Load(object sender, EventArgs e)
        {
            EditData();
        }
        public void EditData()
        {
            
            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();
            
            String cmd1 = "SELECT * FROM Student Where Student.Id = "+  MyClass.count;
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
                textBox1.Text = myReader.GetValue(1).ToString();
                textBox2.Text = myReader.GetValue(2).ToString();
                textBox3.Text = myReader.GetValue(3).ToString();
                textBox6.Text = myReader.GetValue(4).ToString();
                textBox5.Text = myReader.GetValue(5).ToString();
                string status = myReader.GetValue(6).ToString();
                int x = 0;
                Int32.TryParse(status, out x);
                if (x == 1)
                {
                    comboBox1.Text = "Active";
                }
                else
                {
                    comboBox1.Text = "InActive";
                }


                cmd.Dispose();
                conn1.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }
        // Edit Data of Student
        public void SaveData()
        {
            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog = ProjectB ; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();
            int status = 0;
            if (comboBox1.Text == "Active")
            {
                status = 1;
            }
            else
            {
                status = 0;
            }
            String cmd1 = "update Student set FirstName='" + textBox1.Text + "', LastName= '" + textBox2.Text + "', Contact= '" + textBox3.Text + "',Email='" +
            textBox6.Text + "', RegistrationNumber='" + textBox5.Text + "',Status='" + status + "' Where  Student.Id = '" + MyClass.count + "'";

            SqlCommand cmd = new SqlCommand(cmd1, conn1);
            
            try
            {
                cmd.ExecuteReader();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex + " Record Has Been Updated ");
            }
            
        }
          
        private void button1_Click(object sender, EventArgs e)
        {
            SaveData();
        }
    }
}
