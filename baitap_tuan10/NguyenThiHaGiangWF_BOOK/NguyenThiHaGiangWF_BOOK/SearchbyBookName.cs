using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace NguyenThiHaGiangWF_BOOK
{
    public partial class SearchbyBookName : Form
    {
        public SearchbyBookName()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=.;Initial Catalog=LibraryManagementSystem;Integrated Security=True;Trust Server Certificate=True";
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM BOOK WHERE BOOKNAME LIKE @BOOKNAME";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@BOOKNAME", "%" + txtSearch.Text + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dtgBook.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        int position = -1;

        private void dtgBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
