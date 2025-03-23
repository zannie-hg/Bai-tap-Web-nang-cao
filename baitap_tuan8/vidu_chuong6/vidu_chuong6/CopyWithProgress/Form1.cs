namespace CopyWithProgress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] filenames = { "File1.txt", "File2.txt", "File3.txt", "File4.txt", "File5.txt" };
            CopyWithProgress(filenames);
        }

        private void CopyWithProgress(string[] filenames)
        {
            pBMain.Minimum = 1;
            pBMain.Maximum = filenames.Length;
            pBMain.Value = 1;
            pBMain.Step = 1;
            for (int x = 1; x <= filenames.Length; x++)
            {
                if (CopyFile(filenames[x - 1]) == true)
                {
                    pBMain.PerformStep();
                }
            }
        }

        private bool CopyFile(string fileName)
        {
            return true;
        }
    }
}
