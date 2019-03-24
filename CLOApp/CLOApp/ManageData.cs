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
    public partial class ManageData : Form
    {
        public ManageData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageCLO m1 = new  ManageCLO();
            m1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentsDetails s1 = new StudentsDetails();
            s1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AttendenceDetail ad = new AttendenceDetail();
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
            StudentResult r1 = new StudentResult();
            r1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddAssessment a1 = new AddAssessment();
            a1.Show();
            this.Hide();
        }
    }
}
