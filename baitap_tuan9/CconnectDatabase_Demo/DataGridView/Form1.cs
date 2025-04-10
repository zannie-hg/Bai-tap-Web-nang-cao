using System.Data;
using Microsoft.Data.SqlClient;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // chuỗi kết nối database
        string connectionString = "Data Source=.;Initial Catalog=STUDENT_MANAGEMENT;Integrated Security=True;Trust Server Certificate=True";
        // lớp hỗ trợ kết nối
        SqlConnection connection = null;
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        private void btnInsert_Click(object sender, EventArgs e)
        {
            int result = 0;
            // Create a new row
            DataRow row = ds.Tables[0].NewRow();
            row[0] = txtStudentID.Text;
            row["Name"] = txtStudentName.Text;
            row[2] = txtClassID.Text;
            // Add the row to DataSet
            ds.Tables[0].Rows.Add(row);
            // Update Adapter
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (position == -1)
            {
                MessageBox.Show("No row is selected");
                return;
            }

            // Get a selected row in dataset
            DataRow row = ds.Tables[0].Rows[position];

            // Edit the row
            row.BeginEdit();
            row[0] = txtStudentID.Text;
            row[1] = txtStudentName.Text;
            row[2] = txtClassID.Text;
            row.EndEdit();

            // Update adapter
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

        private void Form1_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("Select * from Student", connectionString);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            // Fill data from adapter to dataset
            adapter.Fill(ds, "Student");
            dtgStudent.DataSource = ds.Tables[0];
        }
        int position = -1;
        private void dtgStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            position = e.RowIndex;
            if (position == -1)
            {
                MessageBox.Show("No row is selected");
                return;
            }

            // Get selected row
            DataRow row = ds.Tables[0].Rows[position];
            txtStudentID.Text = row[0].ToString();
            txtStudentName.Text = row["Name"].ToString();
            txtClassID.Text = row[2].ToString();
        }
    }
}
