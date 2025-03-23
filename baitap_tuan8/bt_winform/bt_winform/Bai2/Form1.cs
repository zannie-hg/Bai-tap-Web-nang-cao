namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_sothunhat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

            {

                e.Handled = true;

            }
        }

        private void txt_sothuhai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

            {

                e.Handled = true;

            }
        }

        private void btn_cong_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(txt_sothunhat.Text) + Convert.ToInt32(txt_sothuhai.Text);

            txt_ketqua.Text = result.ToString();
        }

        private void btn_tru_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(txt_sothunhat.Text) - Convert.ToInt32(txt_sothuhai.Text);

            txt_ketqua.Text = result.ToString();
        }

        private void btn_nha_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(txt_sothunhat.Text) * Convert.ToInt32(txt_sothuhai.Text);

            txt_ketqua.Text = result.ToString();
        }

        private void chia_Click(object sender, EventArgs e)
        {
            Double result = Convert.ToDouble(txt_sothunhat.Text) / Convert.ToDouble(txt_sothuhai.Text);

            txt_ketqua.Text = result.ToString();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            txt_sothunhat.Clear();

            txt_sothuhai.Clear();

            txt_ketqua.Clear();
        }
    }
}
