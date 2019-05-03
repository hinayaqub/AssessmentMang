using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLOApp
{
    class CLO
    {
        int[] cloarr;
        /// <summary>
        /// Bind Data from Database to Datagridview
        /// </summary>
        /// <returns>DataTable Containing Data</returns>
        public DataTable Showdata()
        {
            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();
            String cmd1 = "SELECT * FROM Clo";
            //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
            SqlCommand cmd = new SqlCommand(cmd1, conn1);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            conn1.Close();
            return dataTable;
        }
        /// <summary>
        ///Show Form Of Clo 
        /// </summary>
        public void EditCLO()
        {
            if (DialogResult.Yes == MessageBox.Show("Do you want to edit the row?", "", MessageBoxButtons.YesNo))
            {
                frmEditClo editCLO = new frmEditClo();
                editCLO.Show();
            }
        }
        /// <summary>
        /// Delete CLO
        /// </summary>
        public void DeleteCLO()
        {
            if (DialogResult.Yes == MessageBox.Show("Do you want to delete the row?", "", MessageBoxButtons.YesNo))
            {
                String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
                //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
                SqlConnection conn1 = new SqlConnection(conURL1);
                conn1.Open();
                String RubricId = "SELECT Id FROM Rubric Where CloId = "+MyClass.CLOid;
                //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
                SqlCommand sqlCmd = new SqlCommand(RubricId, conn1);
                SqlDataReader myReader;
                myReader = sqlCmd.ExecuteReader();
                if (!myReader.Read())
                {
                    int j = 0;
                    
                }

                else
                {
                    try
                    {

                        MyClass.RubricId = Convert.ToInt32(myReader.GetValue(0).ToString());
                    }


                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                ///////
                String asscompId = "SELECT Id FROM RubricLevel Where RubricId = " + MyClass.RubricId;
                SqlCommand sqlcmd = new SqlCommand(asscompId, conn1);
                SqlDataReader ReadData;
                ReadData = sqlcmd.ExecuteReader();
                if (!ReadData.Read())
                {
                    int i = 0;
                }
                else
                {

                    try
                    {

                        MyClass.rubriclevelId = Convert.ToInt32(ReadData.GetValue(0).ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }

                String std = "Delete FROM  StudentResult Where RubricMeasurementId = " + MyClass.rubriclevelId;
                //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(std, conn1);
                sqlDataAdap.SelectCommand.ExecuteNonQuery();

                String asscomp = "Delete FROM  AssessmentComponent Where RubricId = " + MyClass.RubricId;
                //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
                SqlDataAdapter sqlData = new SqlDataAdapter(asscomp, conn1);
                sqlData.SelectCommand.ExecuteNonQuery();

                String rublvl = "Delete FROM RubricLevel Where RubricId = " + MyClass.RubricId;
                //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
                SqlDataAdapter sqlDataAdapt = new SqlDataAdapter(rublvl, conn1);
                sqlDataAdapt.SelectCommand.ExecuteNonQuery();

                String cmd1 = "Delete FROM Rubric Where CloId = " + MyClass.CLOid;
                //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
                SqlDataAdapter cmd = new SqlDataAdapter(cmd1, conn1);
                cmd.SelectCommand.ExecuteNonQuery();



                ////////
               
                       
                

                

              

                String delclo = "Delete FROM  Clo Where Clo.Id = " + MyClass.CLOid;
                SqlDataAdapter Command = new SqlDataAdapter(delclo, conn1);
                Command.SelectCommand.ExecuteNonQuery();

                conn1.Close();
                MessageBox.Show("Data Has been successfuly deleted");
            }
        }


        /// <summary>
        ///  Create Edit btn In datagridView
        /// </summary>
        /// <returns>Edit button column</returns>
        public DataGridViewButtonColumn Editbtn()
        {
            DataGridViewButtonColumn editBtn = new DataGridViewButtonColumn();
            editBtn.HeaderText = "Edit Data";
            editBtn.Name = "Edit Data";
            editBtn.Text = "Edit";
            editBtn.UseColumnTextForButtonValue = true;
            return editBtn;
            
        }

        /// <summary>
        /// Add Delete Button Column
        /// </summary>
        /// <returns>Delete button Column</returns>
        public DataGridViewButtonColumn Deletebtn()
        {
            DataGridViewButtonColumn deletebtn = new DataGridViewButtonColumn();
            deletebtn.HeaderText = "Delete Data";
            deletebtn.Name = "Delete Data";
            deletebtn.Text = "Delete";
            deletebtn.UseColumnTextForButtonValue = true;
            return deletebtn;
            
        }

        /// <summary>
        /// Add Rubric Button Column
        /// </summary>
        /// <returns>Return Button of rubric</returns>
        public DataGridViewButtonColumn AddRubricbtn()
        {
            DataGridViewButtonColumn AddRubricbtn = new DataGridViewButtonColumn();
            AddRubricbtn.HeaderText = "Add Rubrics";
            AddRubricbtn.Name = "Add_Rubrics";
            AddRubricbtn.Text = "Add Rubrics";
            AddRubricbtn.UseColumnTextForButtonValue = true;
            return AddRubricbtn;
            
        }
    }
}
