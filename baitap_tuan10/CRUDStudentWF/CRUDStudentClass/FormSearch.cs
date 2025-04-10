using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CRUDStudentClass
{
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=.;Initial Catalog=STUDENT_MANAGEMENT;Integrated Security=True;Trust Server Certificate=True";
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter($"select * from student where name like '%{txtSearch.Text}%'", connectionString);
            ds = new DataSet();
            adapter.Fill(ds);
            dtgStudent.DataSource = ds.Tables[0];
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    //CREATE DATABASE Qdsd;
    //    GO
    //    USE qdsd;
    //    GO
    //create table kh (
    //    ID INT identity (1,1) 
    //...
    //    )
}
