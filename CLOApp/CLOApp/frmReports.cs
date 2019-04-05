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
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAssessmentReport assreport = new frmAssessmentReport();
            assreport.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCLOReport cloreport = new frmCLOReport();
            cloreport.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmStudentMangForm stdmang = new frmStudentMangForm();
            stdmang.Show();
            this.Hide();
        }
    }
}
