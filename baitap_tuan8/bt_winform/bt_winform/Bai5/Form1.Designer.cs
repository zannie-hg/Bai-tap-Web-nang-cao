namespace Bai5
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btn_thoat = new Button();
            btn_dangnhap = new Button();
            chk_hienthi = new CheckBox();
            txt_matkhau = new TextBox();
            txt_tendangnhap = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-28, -3);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(312, 334);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(btn_thoat);
            panel1.Controls.Add(btn_dangnhap);
            panel1.Controls.Add(chk_hienthi);
            panel1.Controls.Add(txt_matkhau);
            panel1.Controls.Add(txt_tendangnhap);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(312, -3);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(388, 334);
            panel1.TabIndex = 1;
            // 
            // btn_thoat
            // 
            btn_thoat.Location = new Point(240, 240);
            btn_thoat.Margin = new Padding(3, 2, 3, 2);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(94, 24);
            btn_thoat.TabIndex = 7;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // btn_dangnhap
            // 
            btn_dangnhap.Location = new Point(85, 242);
            btn_dangnhap.Margin = new Padding(3, 2, 3, 2);
            btn_dangnhap.Name = "btn_dangnhap";
            btn_dangnhap.Size = new Size(94, 22);
            btn_dangnhap.TabIndex = 6;
            btn_dangnhap.Text = "Đăng nhập";
            btn_dangnhap.UseVisualStyleBackColor = true;
            btn_dangnhap.Click += btn_dangnhap_Click;
            // 
            // chk_hienthi
            // 
            chk_hienthi.AutoSize = true;
            chk_hienthi.Location = new Point(138, 184);
            chk_hienthi.Margin = new Padding(3, 2, 3, 2);
            chk_hienthi.Name = "chk_hienthi";
            chk_hienthi.Size = new Size(121, 19);
            chk_hienthi.TabIndex = 5;
            chk_hienthi.Text = "Hiển thị mật khẩu";
            chk_hienthi.UseVisualStyleBackColor = true;
            chk_hienthi.CheckedChanged += chk_hienthi_CheckedChanged;
            // 
            // txt_matkhau
            // 
            txt_matkhau.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_matkhau.Location = new Point(138, 148);
            txt_matkhau.Margin = new Padding(3, 2, 3, 2);
            txt_matkhau.Name = "txt_matkhau";
            txt_matkhau.Size = new Size(196, 27);
            txt_matkhau.TabIndex = 4;
            txt_matkhau.KeyPress += txt_matkhau_KeyPress;
            // 
            // txt_tendangnhap
            // 
            txt_tendangnhap.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_tendangnhap.Location = new Point(138, 100);
            txt_tendangnhap.Margin = new Padding(3, 2, 3, 2);
            txt_tendangnhap.Name = "txt_tendangnhap";
            txt_tendangnhap.Size = new Size(196, 27);
            txt_tendangnhap.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 152);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 105);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(71, 30);
            label1.Name = "label1";
            label1.Size = new Size(233, 30);
            label1.TabIndex = 0;
            label1.Text = "CỬA SỔ ĐĂNG NHẬP";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(700, 328);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox txt_tendangnhap;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_matkhau;
        private Button btn_thoat;
        private Button btn_dangnhap;
        private CheckBox chk_hienthi;
    }
}
