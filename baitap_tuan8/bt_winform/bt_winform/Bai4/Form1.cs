namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_nhap_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_nhap.Text))

            {

                lstBox_hienthi.Items.Add(txt_nhap.Text);

                txt_hienthi.Text = lstBox_hienthi.Items.Count.ToString();

                txt_nhap.Clear();

                txt_nhap.Focus();

            }

            else

                MessageBox.Show("Vui lòng điền đầy đủ thông tin !!!");
        }

        private void btn_xoadangchon_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt_hienthi.Text);

            if (lstBox_hienthi.SelectedItems.Count != 0)

            {

                lstBox_hienthi.Items.Remove(lstBox_hienthi.SelectedItems[0]);

            }

            txt_hienthi.Text = (a - 1).ToString();
        }

        private void btn_xoadau_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt_hienthi.Text);

            lstBox_hienthi.Items.RemoveAt(0);

            txt_hienthi.Text = (a - 1).ToString();
        }

        private void btn_xoacuoi_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt_hienthi.Text);

            lstBox_hienthi.Items.RemoveAt(lstBox_hienthi.Items.Count - 1);

            txt_hienthi.Text = (a - 1).ToString();
        }

        private void btn_xoatatca_Click(object sender, EventArgs e)
        {
            lstBox_hienthi.Items.Clear();

            txt_hienthi.Text = "0";
        }
    }
}
