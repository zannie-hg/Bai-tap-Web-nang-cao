using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CRUDStudentClass
{
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=.;Initial Catalog=STUDENT_MANAGEMENT;Integrated Security=True;Trust Server Certificate=True";
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("Select * from Student", connectionString);
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
            try
            {
                if (position == -1)
                {
                    MessageBox.Show("No row is selected!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this record?",
                                                       "Confirm Delete",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Warning);
                if (confirm != DialogResult.Yes)
                    return;

                // Kiểm tra nếu ds hoặc bảng rỗng
                if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No data available!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DataRow row = ds.Tables[0].Rows[position];
                row.Delete();
                int result = adapter.Update(ds.Tables[0]);
                if (result > 0)
                {
                    MessageBox.Show("Delete successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Delete failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
