using System.Data;
using Microsoft.Data.SqlClient;

namespace Test_ConnecttoDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // chuỗi kết nối database
        string connectionString = "Data Source=.;Integrated Security=True;Trust Server Certificate=True";
        // lớp hỗ trợ kết nối
        SqlConnection connection = null;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                MessageBox.Show("Successfull Connection");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to server" + ex.Message);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if(connection != null && connection.State==ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Successfull Disconnection !!!");
            }
        }
    }
}
