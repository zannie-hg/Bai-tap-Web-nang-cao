using System.Data;
using Microsoft.Data.SqlClient;

namespace ListOfStudents
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
        private void Form1_Load(object sender, EventArgs e)
        {
            lsvStudent.View = View.Details;  // Hiển thị theo dạng chi tiết
            lsvStudent.Columns.Clear();
            lsvStudent.Columns.Add("Student ID", 100, HorizontalAlignment.Left);
            lsvStudent.Columns.Add("Name", 150, HorizontalAlignment.Left);
            lsvStudent.Columns.Add("Class ID", 100, HorizontalAlignment.Left);
            if (connection == null) connection = new SqlConnection(connectionString);
            if (connection.State == ConnectionState.Closed) connection.Open();
            SqlCommand command = new SqlCommand("Select * from Class", connection);

            // Execute SQL Command
            lsbClass.ClearSelected();
            SqlDataReader reader = command.ExecuteReader(); // Execute SQL Command
            while (reader.Read())
            {
                string classID = reader.GetString(0);
                string className = reader.GetString(1);
                int year = reader.GetInt32(2);
                string line = classID + "-" + className + "-" + year.ToString();
                lsbClass.Items.Add(line);
            }
            connection.Close();
        }

        private void lsvClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lsbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsvStudent.Items.Clear();
            if (lsbClass.SelectedIndex == -1) return;
            string line = lsbClass.SelectedItem.ToString();
            string[] array = line.Split('-');
            string classID = array[0];

            if (connection == null) connection = new SqlConnection(connectionString);
            if (connection.State == ConnectionState.Closed) connection.Open();
            SqlCommand command = new SqlCommand($"Select * from Student where ClassID='{classID}'", connection);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string studentID = reader.GetString(0);
                string name = reader.GetString(1);
                string classIDRow = reader.GetString(2);
                ListViewItem item = new ListViewItem(studentID);
                item.SubItems.Add(name);
                item.SubItems.Add(classIDRow);
                lsvStudent.Items.Add(item);
            }
            connection.Close();
        }

        private void lsvStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
