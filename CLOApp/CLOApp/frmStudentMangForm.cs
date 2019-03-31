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
    public partial class frmStudentMangForm : Form
    {
        public frmStudentMangForm()
        {
            InitializeComponent();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Buttons used for diffrent form
        /// apperance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCLO_Click(object sender, EventArgs e)
        {
            frmManageCLO mangCLO = new frmManageCLO();
            mangCLO.Show();
            this.Hide();
        }

        private void btnAttMang_Click(object sender, EventArgs e)
        {
            frmAttendenceDetail attDetail = new frmAttendenceDetail();
            attDetail.Show();
            this.Hide();
        }

        private void btnStdMang_Click(object sender, EventArgs e)
        {
            frmAddStudents addStd = new frmAddStudents();
            addStd.Show();
            this.Hide();
        }

        private void btnAssessMang_Click(object sender, EventArgs e)
        {
            frmAddAssessment addAssess = new frmAddAssessment();
            addAssess.Show();
            this.Hide();
        }

        private void btnResMang_Click(object sender, EventArgs e)
        {
            frmStudentResult stuRes = new frmStudentResult();
            stuRes.Show();
            this.Hide();
        }

        public static implicit operator frmStudentMangForm(frmManageData v)
        {
            throw new NotImplementedException();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmReports reports = new frmReports();
            reports.Show();
            this.Hide();
        }
    }
}
