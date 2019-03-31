using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLOApp
{
    public partial class frmManageData : Form
    {
        public frmManageData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmManageCLO m1 = new  frmManageCLO();
            m1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmStudentsDetails s1 = new frmStudentsDetails();
            s1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAttendenceDetail ad = new frmAttendenceDetail();
            ad.Show();
            this.Hide();
        }

        private void ManageData_Load(object sender, EventArgs e)
        {
          

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmStudentResult r1 = new frmStudentResult();
            r1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmAddAssessment a1 = new frmAddAssessment();
            a1.Show();
            this.Hide();
        }
    }
}
