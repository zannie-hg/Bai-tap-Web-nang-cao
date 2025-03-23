namespace bai4
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
            label1 = new Label();
            txtHoVaTen = new TextBox();
            btnNhapThongTin = new Button();
            lstboxHienThi = new ListBox();
            label2 = new Label();
            txtHienThi = new TextBox();
            btnXoadangchon = new Button();
            btnXoaTatCa = new Button();
            btnXoadau = new Button();
            btnXoaCuoi = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 142);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên";
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(117, 139);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(185, 23);
            txtHoVaTen.TabIndex = 1;
            // 
            // btnNhapThongTin
            // 
            btnNhapThongTin.FlatStyle = FlatStyle.System;
            btnNhapThongTin.Location = new Point(96, 219);
            btnNhapThongTin.Name = "btnNhapThongTin";
            btnNhapThongTin.Size = new Size(140, 23);
            btnNhapThongTin.TabIndex = 2;
            btnNhapThongTin.Text = "Nhập thông tin";
            btnNhapThongTin.UseVisualStyleBackColor = true;
            btnNhapThongTin.Click += btnNhapThongTin_Click;
            // 
            // lstboxHienThi
            // 
            lstboxHienThi.FormattingEnabled = true;
            lstboxHienThi.ItemHeight = 15;
            lstboxHienThi.Location = new Point(11, 22);
            lstboxHienThi.Name = "lstboxHienThi";
            lstboxHienThi.Size = new Size(427, 169);
            lstboxHienThi.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(348, 301);
            label2.Name = "label2";
            label2.Size = new Size(147, 15);
            label2.TabIndex = 4;
            label2.Text = "Tổng số người đã khai báo";
            // 
            // txtHienThi
            // 
            txtHienThi.Location = new Point(526, 298);
            txtHienThi.Name = "txtHienThi";
            txtHienThi.Size = new Size(204, 23);
            txtHienThi.TabIndex = 5;
            // 
            // btnXoadangchon
            // 
            btnXoadangchon.Location = new Point(355, 365);
            btnXoadangchon.Name = "btnXoadangchon";
            btnXoadangchon.Size = new Size(156, 23);
            btnXoadangchon.TabIndex = 2;
            btnXoadangchon.Text = "Xóa thông tin đang chọn";
            btnXoadangchon.UseVisualStyleBackColor = true;
            btnXoadangchon.Click += btnXoadangchon_Click;
            // 
            // btnXoaTatCa
            // 
            btnXoaTatCa.Location = new Point(355, 404);
            btnXoaTatCa.Name = "btnXoaTatCa";
            btnXoaTatCa.Size = new Size(156, 23);
            btnXoaTatCa.TabIndex = 2;
            btnXoaTatCa.Text = "Xóa tất cả thông tin";
            btnXoaTatCa.UseVisualStyleBackColor = true;
            btnXoaTatCa.Click += btnXoaTatCa_Click;
            // 
            // btnXoadau
            // 
            btnXoadau.Location = new Point(558, 365);
            btnXoadau.Name = "btnXoadau";
            btnXoadau.Size = new Size(156, 23);
            btnXoadau.TabIndex = 2;
            btnXoadau.Text = "Xóa thông tin đầu";
            btnXoadau.UseVisualStyleBackColor = true;
            btnXoadau.Click += btnXoadau_Click;
            // 
            // btnXoaCuoi
            // 
            btnXoaCuoi.Location = new Point(558, 404);
            btnXoaCuoi.Name = "btnXoaCuoi";
            btnXoaCuoi.Size = new Size(156, 23);
            btnXoaCuoi.TabIndex = 2;
            btnXoaCuoi.Text = "Xóa thông tin cuối";
            btnXoaCuoi.UseVisualStyleBackColor = true;
            btnXoaCuoi.Click += btnXoaCuoi_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(224, 224, 224);
            groupBox1.Controls.Add(lstboxHienThi);
            groupBox1.Location = new Point(337, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(451, 345);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(305, 29);
            label3.Name = "label3";
            label3.Size = new Size(190, 21);
            label3.TabIndex = 7;
            label3.Text = "KHAI BÁO Y TẾ ĐIỆN TỬ";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(txtHienThi);
            Controls.Add(label2);
            Controls.Add(btnXoaTatCa);
            Controls.Add(btnXoaCuoi);
            Controls.Add(btnXoadau);
            Controls.Add(btnXoadangchon);
            Controls.Add(btnNhapThongTin);
            Controls.Add(txtHoVaTen);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtHoVaTen;
        private Button btnNhapThongTin;
        private ListBox lstboxHienThi;
        private Label label2;
        private TextBox txtHienThi;
        private Button btnXoadangchon;
        private Button btnXoaTatCa;
        private Button btnXoadau;
        private Button btnXoaCuoi;
        private GroupBox groupBox1;
        private Label label3;
    }
}
