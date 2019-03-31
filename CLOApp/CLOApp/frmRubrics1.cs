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
    public partial class frmRubrics1 : Form
    {
        public frmRubrics1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Addtextboxes(sender, e);
        }
        public void Addtextboxes(object sender, EventArgs e)
        {
            try
            {
                int txtno = int.Parse(comboBox3.Text);
                // For Rubric's Level
                int PointX3 = 86;
                int PointY3 = 234;


                // For label of rubric's Details
                int PointX1 = 86;
                int PointY1 = 296;

                // For RicherTextBox
                int pointX = 253;
                int pointY = 275;

                // For txtBoxes
                int PointX2 = 253;
                int PointY2 = 370;
                // For Measeurements
                int PointX4 = 66;
                int PointY4 = 377;

                for (int i = 0; i < txtno; i++)
                {

                    // Label
                    Label l = new Label();
                    l.Location = new Point(PointX3, PointY3);
                    l.Size = new Size(76, 13);

                    l.Text = "Rubric " + (i);

                    Label l1 = new Label();
                    l1.Size = new Size(76, 13);
                    l1.Location = new Point(PointX1, PointY1);
                    l1.Text = "Rubric' Detail" + (i);

                    // Richer Text Boxes
                    RichTextBox r1 = new RichTextBox();
                    r1.Size = new Size(154, 65);
                    r1.Location = new Point(pointX, pointY);


                    this.Controls.Add(l);
                    this.Controls.Add(l1);
                    this.Controls.Add(r1);














                    this.Show();
                    PointY3 += 157;
                    pointY += 174;
                    PointY1 += 156;
                    PointY2 += 196;
                    PointY4 += 192;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Showdata();
            
        }
        public void  Showdata()
        {
            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog = ProjectB ; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();
            int z = MyClass.CLOid;
           

            foreach (Control c in Controls)
            {
                
                if (c is RichTextBox)
                {
                    RichTextBox txt = (RichTextBox)c;
                    //string str = txt.Text;
                    //MessageBox.Show(str);
                    String cmd1 = "insert into Rubric values ('" + txt.Text + "', '" + z + "')";

                    SqlCommand cmd = new SqlCommand(cmd1, conn1);
                    int i = cmd.ExecuteNonQuery();

                    if (i != 0)
                    {
                        MessageBox.Show(i + "Record Has Been Saved");
                    }
                }
            }
            conn1.Close();

        }

       /* public void Addrubriclvl()
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
            String cmd1 = "insert into Student values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" +
            textBox6.Text + "','" + textBox5.Text + "','" + status + "')";

            SqlCommand cmd = new SqlCommand(cmd1, conn1);
            int i = cmd.ExecuteNonQuery();
            conn1.Close();
            if (i != 0)
            {
                MessageBox.Show(i + "Record Has Been Saved");
            }
        }*/

        private void Rubrics1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmRubricDetails rd = new frmRubricDetails();
            rd.Show();
            this.Hide();
        }
    }
}
