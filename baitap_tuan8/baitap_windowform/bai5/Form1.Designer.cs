namespace bai5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnThoat = new Button();
            btnDangNhap = new Button();
            chkboxHienThiMatKhau = new CheckBox();
            txtMatKhau = new TextBox();
            label3 = new Label();
            txtTenDangNhap = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 457);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(328, 331);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(btnDangNhap);
            panel2.Controls.Add(chkboxHienThiMatKhau);
            panel2.Controls.Add(txtMatKhau);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtTenDangNhap);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(340, -4);
            panel2.Name = "panel2";
            panel2.Size = new Size(461, 457);
            panel2.TabIndex = 0;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.IndianRed;
            btnThoat.Location = new Point(281, 343);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 44);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.Green;
            btnDangNhap.Location = new Point(119, 343);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(88, 44);
            btnDangNhap.TabIndex = 4;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // chkboxHienThiMatKhau
            // 
            chkboxHienThiMatKhau.AutoSize = true;
            chkboxHienThiMatKhau.Location = new Point(207, 266);
            chkboxHienThiMatKhau.Name = "chkboxHienThiMatKhau";
            chkboxHienThiMatKhau.Size = new Size(121, 19);
            chkboxHienThiMatKhau.TabIndex = 3;
            chkboxHienThiMatKhau.Text = "Hiển thị mật khẩu";
            chkboxHienThiMatKhau.UseVisualStyleBackColor = true;
            chkboxHienThiMatKhau.CheckedChanged += chkboxHienThiMatKhau_CheckedChanged;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(210, 216);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(163, 23);
            txtMatKhau.TabIndex = 2;
            txtMatKhau.UseSystemPasswordChar = true;
            txtMatKhau.KeyPress += txtMatKhau_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 219);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 1;
            label3.Text = "Mật khẩu";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(210, 156);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(163, 23);
            txtTenDangNhap.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 159);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(119, 73);
            label1.Name = "label1";
            label1.Size = new Size(226, 30);
            label1.TabIndex = 0;
            label1.Text = "CỬA SỔ ĐĂNG NHẬP";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private CheckBox chkboxHienThiMatKhau;
        private TextBox txtMatKhau;
        private Label label3;
        private TextBox txtTenDangNhap;
        private Label label2;
        private Label label1;
        private Button btnThoat;
        private Button btnDangNhap;
    }
}
