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

namespace CRUDStudentWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string conn = global::CRUDStudentWF.Properties.Settings.Default.STUDENT_MANAGEMENTConnectionString;
        DataSet ds = null;
        SqlDataAdapter adapter = null;
        private void sTUDENTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sTUDENTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sTUDENT_MANAGEMENTDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sTUDENT_MANAGEMENTDataSet.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter.Fill(this.sTUDENT_MANAGEMENTDataSet.STUDENT);
            adapter = new SqlDataAdapter("Select * from Student", conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            //fill data from adapter to dataset
            adapter.Fill(ds, "Student");
            //dtgStudent.DataSource = ds.Tables[0];

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int result = 0;
            //Create a new row
            DataRow row = ds.Tables[0].NewRow();
            row[0] = txtStudentID.Text;
            row["Name"] = txtStudentName.Text;
            row[2] = txtClassID.Text;
            //add the row to DataSet
            ds.Tables[0].Rows.Add(row);
            //Update Adapter
            try
            {
                adapter.Update(ds, "Student");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert failed \n" + ex.Message);
            }
            if (result > 0) MessageBox.Show("Insert Successfully");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dtgStudent.DataSource = ds.Tables[0];
        }
        //Display a selected row on textboxes
        int position = -1; // there is no selected row.
        private void dtgStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            position = e.RowIndex;
            if (position == -1)
            {
                MessageBox.Show("No row is selected");
                return;
            }

            //get selected row
            DataRow row = ds.Tables[0].Rows[position];
            txtStudentID.Text = row[0].ToString();
            txtStudentName.Text = row["Name"].ToString();
            txtClassID.Text = row[2].ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (position == -1)
            {
                MessageBox.Show("No row is selected");
                return;
            }

            //get a selected row in dataset
            DataRow row = ds.Tables[0].Rows[position];
            //edit the row
            row.BeginEdit();
            row[0] = txtStudentID.Text;
            row[1] = txtStudentName.Text;
            row[2] = txtClassID.Text;
            row.EndEdit();
            //update adapter
            int result = adapter.Update(ds.Tables[0]);
            if (result > 0)
            {
                MessageBox.Show("Update successfully!!!");
            }
            else
            {
                MessageBox.Show("Update failed!!!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (position == -1) return;

            // Get a selected row
            DataRow row = ds.Tables[0].Rows[position];
            row.Delete();

            int result = adapter.Update(ds.Tables[0]);
            if (result > 0)
            {
                MessageBox.Show("Delete successfully!!!");
            }
            else
            {
                MessageBox.Show("Delete failed!!!");
            }
        }
    }
}
