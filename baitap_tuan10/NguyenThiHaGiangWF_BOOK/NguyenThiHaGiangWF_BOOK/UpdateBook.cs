using System.Data;
using Microsoft.Data.SqlClient;

namespace NguyenThiHaGiangWF_BOOK
{
    public partial class UpdateBook : Form
    {
        public UpdateBook()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=.;Initial Catalog=LibraryManagementSystem;Integrated Security=True;Trust Server Certificate=True";
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        private void label5_Click(object sender, EventArgs e)
        {

        }
        int position = -1;
        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO BOOK (BOOK_ID, BOOKNAME, AUTHOR, PUBLICATION_YEAR) VALUES (@BOOK_ID, @BOOKNAME, @AUTHOR, @YEAR)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@BOOK_ID", txtBookID.Text);
                    cmd.Parameters.AddWithValue("@BOOKNAME", txtBookName.Text);
                    cmd.Parameters.AddWithValue("@AUTHOR", txtAuthor.Text);
                    cmd.Parameters.AddWithValue("@YEAR", int.Parse(txtPublicationYear.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Inserted Successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE BOOK SET BOOKNAME=@BOOKNAME, AUTHOR=@AUTHOR, PUBLICATION_YEAR=@YEAR WHERE BOOK_ID=@BOOK_ID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@BOOK_ID", txtBookID.Text);
                    cmd.Parameters.AddWithValue("@BOOKNAME", txtBookName.Text);
                    cmd.Parameters.AddWithValue("@AUTHOR", txtAuthor.Text);
                    cmd.Parameters.AddWithValue("@YEAR", int.Parse(txtPublicationYear.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM BOOK WHERE BOOK_ID=@BOOK_ID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@BOOK_ID", txtBookID.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted Successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
