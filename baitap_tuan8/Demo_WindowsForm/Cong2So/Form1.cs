namespace Cong2So
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            double so1 = 0, so2 = 0;
            try
            {
                so1 = double.Parse(txtSoThuNhat.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Nhap so thu nhat khong dung \n" + ex.Message);
            }

            try
            {
                so2 = double.Parse(txtSoThuHai.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Nhap so thu hai khong dung \n" + ex.Message);
            }

            double tong = so1 + so2;
            txtTong.Text = tong.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSoThuNhat.Select();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtSoThuNhat.Text = "";
            txtSoThuHai.Text = "";
            txtTong.Text = "";
        }
    }
}
