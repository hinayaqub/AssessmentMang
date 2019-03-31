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
    class StudentResult
    {
        // Function to Show data in Grid View 
        // From database
        public DataTable Showdata()
        {
            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();
            String cmd1 = "SELECT * FROM StudentResult";
            //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
            SqlCommand cmd = new SqlCommand(cmd1, conn1);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            conn1.Close();
            return dataTable;
        }

        // Create Edit btn In datagridView
        public DataGridViewButtonColumn Editbtn()
        {
            DataGridViewButtonColumn Editcolmn = new DataGridViewButtonColumn();
            Editcolmn.HeaderText = "Edit Data";
            Editcolmn.Name = "Edit Data";
            Editcolmn.Text = "Edit";
            Editcolmn.UseColumnTextForButtonValue = true;
            return Editcolmn;
        }

        // Create Delete btn in datagridview
        public DataGridViewButtonColumn Deletebtn()
        {
            DataGridViewButtonColumn DeletColumn = new DataGridViewButtonColumn();
            DeletColumn.HeaderText = "Delete Data";
            DeletColumn.Name = "Delete Data";
            DeletColumn.Text = "Delete";
            DeletColumn.UseColumnTextForButtonValue = true;
            return DeletColumn;
        }
    }
}
