﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLOApp
{
    class AssessmentComponent
    {
        /// <summary>
        /// Bind data ofdatabase with datagridview  
        /// </summary>
        public DataTable Showdata()
        {
            String conURL1 = "Data Source = DESKTOP-RPO4Q5R\\PARVEEN; Initial Catalog =ProjectB; User ID = mohsin; Password = mohsin123; MultipleActiveResultSets = True";
            //String conURL =   "Data Source = (local); Initial Catalog = MedicalEncyclopedia; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn1 = new SqlConnection(conURL1);
            conn1.Open();
            String cmd1 = "SELECT * FROM AssessmentComponent";
            //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
            SqlCommand cmd = new SqlCommand(cmd1, conn1);
            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);
            conn1.Close();
            return dataTable;
            
        }
        public DataGridViewButtonColumn Editbtn()
        {
            DataGridViewButtonColumn EditColumn = new DataGridViewButtonColumn();
            EditColumn.HeaderText = "Edit Data";
            EditColumn.Name = "Edit Data";
            EditColumn.Text = "Edit";
            EditColumn.UseColumnTextForButtonValue = true;
            return EditColumn;
         
        }

        // Create Delete btn in datagridview
        public DataGridViewButtonColumn Deletebtn()
        {
            DataGridViewButtonColumn DeleteColumn = new DataGridViewButtonColumn();
            DeleteColumn.HeaderText = "Delete Data";
            DeleteColumn.Name = "Delete Data";
            DeleteColumn.Text = "Delete";
            DeleteColumn.UseColumnTextForButtonValue = true;
            return DeleteColumn;
           
        }

    }
}
