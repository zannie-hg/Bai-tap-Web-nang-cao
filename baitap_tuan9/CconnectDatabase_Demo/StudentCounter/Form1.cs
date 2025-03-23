using System.Data;
using Microsoft.Data.SqlClient;
namespace StudentCounter
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
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (connection == null)
                connection = new SqlConnection(connectionString);
            if (connection.State == ConnectionState.Closed)
                connection.Open();

            SqlCommand command = new SqlCommand($"Select count(*) from STUDENT Where ClassID='{txtClassID.Text}'", connection);

            //Execute the sql command to return a value
            int result = (int)command.ExecuteScalar();
            txtNumber.Text = result.ToString();
            connection.Close();
        }
    }
}
