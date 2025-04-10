using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenThiHaGiangWF_BOOK
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateBook updateBook = new UpdateBook();
            updateBook.Show();
        }

        private void searchByBookNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchbyBookName searchbyBookName = new SearchbyBookName();
            searchbyBookName.Show();
        }
    }
}
