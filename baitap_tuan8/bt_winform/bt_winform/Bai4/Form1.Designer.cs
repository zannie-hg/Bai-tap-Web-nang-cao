namespace Bai4
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btn_nhap = new Button();
            txt_nhap = new TextBox();
            label2 = new Label();
            lstBox_hienthi = new ListBox();
            label3 = new Label();
            txt_hienthi = new TextBox();
            btn_xoadangchon = new Button();
            btn_xoatatca = new Button();
            btn_xoadau = new Button();
            btn_xoacuoi = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SkyBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 120);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(221, 39);
            label1.Name = "label1";
            label1.Size = new Size(337, 38);
            label1.TabIndex = 0;
            label1.Text = "KHAI BÁO Y TẾ ĐIỆN TỬ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightBlue;
            panel2.Controls.Add(btn_nhap);
            panel2.Controls.Add(txt_nhap);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(1, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(257, 330);
            panel2.TabIndex = 1;
            // 
            // btn_nhap
            // 
            btn_nhap.BackColor = Color.LightBlue;
            btn_nhap.Location = new Point(49, 82);
            btn_nhap.Name = "btn_nhap";
            btn_nhap.Size = new Size(136, 29);
            btn_nhap.TabIndex = 2;
            btn_nhap.Text = "Nhập thông tin";
            btn_nhap.UseVisualStyleBackColor = false;
            btn_nhap.Click += btn_nhap_Click;
            // 
            // txt_nhap
            // 
            txt_nhap.Location = new Point(90, 27);
            txt_nhap.Name = "txt_nhap";
            txt_nhap.Size = new Size(148, 27);
            txt_nhap.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 30);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 0;
            label2.Text = "Họ và tên";
            // 
            // lstBox_hienthi
            // 
            lstBox_hienthi.FormattingEnabled = true;
            lstBox_hienthi.Location = new Point(265, 130);
            lstBox_hienthi.Name = "lstBox_hienthi";
            lstBox_hienthi.Size = new Size(523, 144);
            lstBox_hienthi.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(284, 292);
            label3.Name = "label3";
            label3.Size = new Size(187, 20);
            label3.TabIndex = 3;
            label3.Text = "Tổng số người đã khai báo";
            // 
            // txt_hienthi
            // 
            txt_hienthi.Location = new Point(477, 289);
            txt_hienthi.Name = "txt_hienthi";
            txt_hienthi.Size = new Size(271, 27);
            txt_hienthi.TabIndex = 0;
            // 
            // btn_xoadangchon
            // 
            btn_xoadangchon.BackColor = Color.LightBlue;
            btn_xoadangchon.Location = new Point(284, 349);
            btn_xoadangchon.Name = "btn_xoadangchon";
            btn_xoadangchon.Size = new Size(187, 29);
            btn_xoadangchon.TabIndex = 4;
            btn_xoadangchon.Text = "Xóa thông tin đang chọn";
            btn_xoadangchon.UseVisualStyleBackColor = false;
            btn_xoadangchon.Click += btn_xoadangchon_Click;
            // 
            // btn_xoatatca
            // 
            btn_xoatatca.BackColor = Color.LightBlue;
            btn_xoatatca.Location = new Point(284, 400);
            btn_xoatatca.Name = "btn_xoatatca";
            btn_xoatatca.Size = new Size(187, 29);
            btn_xoatatca.TabIndex = 5;
            btn_xoatatca.Text = "Xóa tất cả thông tin";
            btn_xoatatca.UseVisualStyleBackColor = false;
            btn_xoatatca.Click += btn_xoatatca_Click;
            // 
            // btn_xoadau
            // 
            btn_xoadau.BackColor = Color.LightBlue;
            btn_xoadau.Location = new Point(545, 349);
            btn_xoadau.Name = "btn_xoadau";
            btn_xoadau.Size = new Size(203, 29);
            btn_xoadau.TabIndex = 6;
            btn_xoadau.Text = "Xóa thông tin đầu";
            btn_xoadau.UseVisualStyleBackColor = false;
            btn_xoadau.Click += btn_xoadau_Click;
            // 
            // btn_xoacuoi
            // 
            btn_xoacuoi.BackColor = Color.LightBlue;
            btn_xoacuoi.Location = new Point(545, 400);
            btn_xoacuoi.Name = "btn_xoacuoi";
            btn_xoacuoi.Size = new Size(203, 29);
            btn_xoacuoi.TabIndex = 7;
            btn_xoacuoi.Text = "Xóa thông tin cuối";
            btn_xoacuoi.UseVisualStyleBackColor = false;
            btn_xoacuoi.Click += btn_xoacuoi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_xoacuoi);
            Controls.Add(btn_xoadau);
            Controls.Add(btn_xoatatca);
            Controls.Add(btn_xoadangchon);
            Controls.Add(txt_hienthi);
            Controls.Add(label3);
            Controls.Add(lstBox_hienthi);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TextBox txt_nhap;
        private Label label2;
        private ListBox lstBox_hienthi;
        private Label label3;
        private TextBox txt_hienthi;
        private Button btn_nhap;
        private Button btn_xoadangchon;
        private Button btn_xoatatca;
        private Button btn_xoadau;
        private Button btn_xoacuoi;
    }
}
