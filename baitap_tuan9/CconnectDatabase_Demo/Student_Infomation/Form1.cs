using System.Data;
using Microsoft.Data.SqlClient;

namespace Student_Infomation
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
        int result = -1;
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (connection == null) connection = new SqlConnection(connectionString);
            if (connection.State == ConnectionState.Closed) connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = "insert into Student(StudentID, Name, ClassID) " +
                                  "values(@StudentID, @Name, @ClassID)";

            SqlParameter parameter1 = new SqlParameter("@StudentID", txtStudentID.Text);
            command.Parameters.Add(parameter1);
            SqlParameter parameter2 = new SqlParameter("@Name", txtName.Text);
            command.Parameters.Add(parameter2);
            SqlParameter parameter3 = new SqlParameter("@ClassID", txtClassID.Text);
            command.Parameters.Add(parameter3);

            try
            {
                result = command.ExecuteNonQuery();
                // using ExecuteNonQuery if SQL command=insert, update or delete
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nInsert a record failed!!!!!!");
            }

            if (result > 0)
            {
                ViewListofStudent();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ViewListofStudent();
            lsvStudent.View = View.Details;  // Hiển thị theo dạng chi tiết
            lsvStudent.Columns.Clear();
            lsvStudent.Columns.Add("Student ID", 100, HorizontalAlignment.Left);
            lsvStudent.Columns.Add("Name", 150, HorizontalAlignment.Left);
            lsvStudent.Columns.Add("Class ID", 100, HorizontalAlignment.Left);
        }

        private void ViewListofStudent()
        {
            lsvStudent.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Student", conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string masv = reader.GetString(0);
                            string hoten = reader.GetString(1);
                            string malop = reader.GetString(2);

                            ListViewItem item = new ListViewItem(masv);
                            item.SubItems.Add(hoten);
                            item.SubItems.Add(malop);
                            lsvStudent.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void lsvStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvStudent.SelectedItems.Count > 0)
            {
                txtStudentID.Text = lsvStudent.SelectedItems[0].SubItems[0].Text;
                txtName.Text = lsvStudent.SelectedItems[0].SubItems[1].Text;
                txtClassID.Text = lsvStudent.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (connection == null) connection = new SqlConnection(connectionString);
            if (connection.State == ConnectionState.Closed) connection.Open();

            SqlCommand command = new SqlCommand($"update Student set Name='{txtName.Text}', ClassID='{txtClassID.Text}' " +
                                                $"where StudentID='{txtStudentID.Text}'", connection);

            try
            {
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nUpdate failed!!!!!!");
            }

            if (result > 0)
            {
                ViewListofStudent();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (connection == null) connection = new SqlConnection(connectionString);
            if (connection.State == ConnectionState.Closed) connection.Open();

            SqlCommand command = new SqlCommand($"delete from Student where StudentID='{txtStudentID.Text}'", connection);

            try
            {
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nDelete failed");
            }

            if (result > 0)
            {
                ViewListofStudent();
                txtStudentID.Text = "";
                txtName.Text = "";
                txtClassID.Text = "";
            }
        }
    }
}
