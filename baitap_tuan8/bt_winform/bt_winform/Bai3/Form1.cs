namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sothich_Click(object sender, EventArgs e)
        {
            string str = "";

            if (chkbox_muasam.Checked == true)

            {

                str = chkbox_muasam.Text + "\n";

            }

            if (chkbox_nghenhac.Checked == true)

            {

                str = str + chkbox_nghenhac.Text + "\n";

            }

            if (chkbox_thethao.Checked == true)

            {

                str = str + chkbox_thethao.Text + "\n";

            }

            if (chkbox_xemphim.Checked == true)

            {

                str = str + chkbox_xemphim.Text + "\n";

            }

            if (chkbox_dulich.Checked == true)

            {

                str = str + chkbox_dulich.Text;

            }



            if (str.Length > 0)

            {

                MessageBox.Show("Sở thích của bạn là: \n" + str);

            }

            else

            {

                MessageBox.Show("Không có sở thích nào bạn chọn!!");

            }
        }

        private void btn_mauthich_Click(object sender, EventArgs e)
        {
            string str = "";

            if (rdbtn_do.Checked == true)

            {

                str = rdbtn_do.Text + "\n";

            }
            if (rdbtn_den.Checked == true)

            {

                str = rdbtn_den.Text + "\n";

            }
            if (rdbtn_xanhla.Checked == true)

            {

                str = rdbtn_xanhla.Text + "\n";

            }
            if (rdbtn_xanhduong.Checked == true)

            {

                str = rdbtn_xanhduong.Text + "\n";

            }
            if (rdbtn_hong.Checked == true)

            {

                str = rdbtn_hong.Text + "\n";

            }
            if (rdbtn_trang.Checked == true)

            {

                str = rdbtn_trang.Text + "\n";

            }
            if (str.Length > 0)

            {

                MessageBox.Show("Màu bạn thích là: \n" + str);

            }

            else

            {

                MessageBox.Show("Không có màu nào bạn chọn!!");

            }
        }
    }
}
