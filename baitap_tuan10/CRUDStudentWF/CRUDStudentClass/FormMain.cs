using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDStudentClass
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void formStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStudent studentForm = new FormStudent(); // Tạo instance của Form1
            studentForm.Show(); // Hiển thị Form1
        }

        private void formSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSearch searchForm = new FormSearch();
            searchForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ứng dụng quản lý sinh viên \nVersion 1.0\nTác giả: Nhóm của bạn", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    
}
