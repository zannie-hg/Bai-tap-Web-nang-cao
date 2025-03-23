namespace bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnNhapThongTin_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtHoVaTen.Text))

            {

                lstboxHienThi.Items.Add(txtHoVaTen.Text);

                txtHienThi.Text = lstboxHienThi.Items.Count.ToString();

                txtHoVaTen.Clear();

                txtHoVaTen.Focus();

            }

            else

                MessageBox.Show("Vui lòng điền đầy đủ thông tin !!!");
        }

        private void btnXoadangchon_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtHienThi.Text);

            if (lstboxHienThi.SelectedItems.Count != 0)

            {

                lstboxHienThi.Items.Remove(lstboxHienThi.SelectedItems[0]);

            }

            txtHienThi.Text = (a - 1).ToString();
        }

        private void btnXoadau_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtHienThi.Text);

            lstboxHienThi.Items.RemoveAt(0);

            txtHienThi.Text = (a - 1).ToString();
        }

        private void btnXoaCuoi_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtHienThi.Text);

            lstboxHienThi.Items.RemoveAt(lstboxHienThi.Items.Count - 1);

            txtHienThi.Text = (a - 1).ToString();
        }

        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            lstboxHienThi.Items.Clear();

            txtHienThi.Text = "0";
        }
    }
}
