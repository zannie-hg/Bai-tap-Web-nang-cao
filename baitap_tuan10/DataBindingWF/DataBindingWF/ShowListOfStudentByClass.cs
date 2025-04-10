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

namespace DataBindingWF
{
    public partial class ShowListOfStudentByClass : Form
    {
        public ShowListOfStudentByClass()
        {
            InitializeComponent();
        }
        //get Connection String
        string conn = global::DataBindingWF.Properties.Settings.Default.STUDENT_MANAGEMENTConnectionString;
        DataSet ds = null;
        SqlDataAdapter adapter = null;
        string str;
        private void cLASSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cLASSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sTUDENT_MANAGEMENTDataSet);

        }

        private void cLASSBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.cLASSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sTUDENT_MANAGEMENTDataSet);

        }

        private void ShowListOfStudentByClass_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sTUDENT_MANAGEMENTDataSet.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter.Fill(this.sTUDENT_MANAGEMENTDataSet.STUDENT);
            // TODO: This line of code loads data into the 'sTUDENT_MANAGEMENTDataSet.CLASS' table. You can move, or remove it, as needed.
            this.cLASSTableAdapter.Fill(this.sTUDENT_MANAGEMENTDataSet.CLASS);

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            str = $"Select * from Student where ClassID='{cboClassID.Text}'";
            adapter = new SqlDataAdapter(str, conn);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchByStudentName searchByStudentName = new SearchByStudentName(); // Tạo một instance của ShowListOfStudentByClass
            searchByStudentName.Show(); // Hiển thị ShowListOfStudentByClass
        }
    }
}
