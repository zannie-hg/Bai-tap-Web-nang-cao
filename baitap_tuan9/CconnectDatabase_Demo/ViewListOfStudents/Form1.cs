using Microsoft.Data.SqlClient;
using System.Data;

namespace ViewListOfStudents
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

        private void btnViewClass_Click(object sender, EventArgs e)
        {
            txtClassID.Text = "";
            txtClassName.Text = "";
            txtYear.Text = "";

            if (connection == null)
                connection = new SqlConnection(connectionString);
            if (connection.State == ConnectionState.Closed)
                connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = $"SELECT * FROM Class WHERE ClassID='{txtEnterClassID.Text}'";
            command.Connection = connection;

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                txtClassID.Text = reader.GetString(0);
                txtClassName.Text = reader.GetString(1);
                txtYear.Text = reader.GetInt32(2).ToString();
            }

            connection.Close();
        }

        private void btnViewStudent_Click(object sender, EventArgs e)
        {
            lsvStudents.Items.Clear();

            if (connection == null) connection = new SqlConnection(connectionString);
            if (connection.State == ConnectionState.Closed) connection.Open();

            SqlCommand command = new SqlCommand($"SELECT * FROM STUDENT WHERE ClassID='{txtEnterClassID.Text}'", connection);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string studentID = reader.GetString(0);
                string name = reader.GetString(1);
                string classID = reader.GetString(2);

                ListViewItem item = new ListViewItem(studentID);
                item.SubItems.Add(name);
                item.SubItems.Add(classID);
                lsvStudents.Items.Add(item);
            }

            connection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lsvStudents.View = View.Details;  // Hiển thị theo dạng chi tiết
            lsvStudents.Columns.Clear();
            lsvStudents.Columns.Add("Student ID", 100, HorizontalAlignment.Left);
            lsvStudents.Columns.Add("Name", 150, HorizontalAlignment.Left);
            lsvStudents.Columns.Add("Class ID", 100, HorizontalAlignment.Left);
        }
    }
}
