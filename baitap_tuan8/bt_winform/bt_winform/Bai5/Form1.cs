using System.Windows.Forms;

namespace Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_tendangnhap.Text) || !string.IsNullOrWhiteSpace(txt_matkhau.Text))

            {

                MessageBox.Show("Đăng nhập thành công !!!");

            }

            else

            {

                MessageBox.Show("Vui lòng điền đầy đủ thông tin !!!");

            }
        }

        private void txt_matkhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

                e.Handled = true;
        }

        private void chk_hienthi_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_hienthi.Checked == true)

            {

                txt_matkhau.PasswordChar = (char)0;

            }

            else

            {

                txt_matkhau.PasswordChar = '*';

            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn đóng chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dg == DialogResult.Yes)

            {

                Application.Exit();

            }
        }
    }
}
