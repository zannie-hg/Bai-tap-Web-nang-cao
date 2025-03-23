namespace bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoThuNhat_Click(object sender, EventArgs e)
        {

        }

        private void txtSoThuNhat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

            {

                e.Handled = true;

            }
        }

        private void txtSoThuHai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

            {

                e.Handled = true;

            }
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(txtSoThuNhat.Text) + Convert.ToInt32(txtSoThuHai.Text);

            txtKetQua.Text = result.ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(txtSoThuNhat.Text) - Convert.ToInt32(txtSoThuHai.Text);

            txtKetQua.Text = result.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(txtSoThuNhat.Text) * Convert.ToInt32(txtSoThuHai.Text);

            txtKetQua.Text = result.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            Double result = Convert.ToDouble(txtSoThuNhat.Text) / Convert.ToDouble(txtSoThuHai.Text);

            txtKetQua.Text = result.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtSoThuNhat.Clear();

            txtSoThuHai.Clear();

            txtKetQua.Clear();
        }
    }
}
