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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageCLO m1 = new ManageCLO();
            m1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentsDetails s1 = new StudentsDetails();
            s1.Show();
            this.Hide();
        }
    }
}
