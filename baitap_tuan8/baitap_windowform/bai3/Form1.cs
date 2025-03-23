namespace bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }



        private void btnSoThich_Click(object sender, EventArgs e)
        {
            string str = "";
            if (chkboxMuaSam.Checked == true)

            {

                str = chkboxMuaSam.Text + "\n";

            }
            if (chkboxNgheNhac.Checked == true)

            {

                str = str + chkboxNgheNhac.Text + "\n";

            }
            if (chkboxChoiTheThao.Checked == true)

            {

                str = str + chkboxChoiTheThao.Text + "\n";

            }
            if (chkboxDiDuLich.Checked == true)

            {

                str = str + chkboxDiDuLich.Text + "\n";

            }
            if (chkboxXemPhim.Checked == true)

            {

                str = str + chkboxXemPhim.Text + "\n";

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

        private void btnMau_Click(object sender, EventArgs e)
        {
            string str = "";
            if (rdbtnDen.Checked == true)

            {

                str = rdbtnDen.Text + "\n";

            }
            if (rdbtnCam.Checked == true)

            {

                str = rdbtnCam.Text + "\n";

            }
            if (rdbtnDo.Checked == true)

            {

                str = rdbtnDo.Text + "\n";

            }
            if (rdbtnVang.Checked == true)

            {

                str = rdbtnVang.Text + "\n";

            }
            if (rdbtnXanh.Checked == true)

            {

                str = rdbtnXanh.Text + "\n";

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
