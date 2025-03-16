namespace Cong2So
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
            btnNhapLai = new Button();
            label1 = new Label();
            label = new Label();
            txtSoThuNhat = new TextBox();
            label3 = new Label();
            txtSoThuHai = new TextBox();
            label4 = new Label();
            txtTong = new TextBox();
            btnTinhTong = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // btnNhapLai
            // 
            btnNhapLai.BackColor = SystemColors.HotTrack;
            btnNhapLai.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNhapLai.ForeColor = SystemColors.Window;
            btnNhapLai.Location = new Point(342, 305);
            btnNhapLai.Name = "btnNhapLai";
            btnNhapLai.Size = new Size(117, 52);
            btnNhapLai.TabIndex = 0;
            btnNhapLai.Text = "Nhập lại";
            btnNhapLai.UseVisualStyleBackColor = false;
            btnNhapLai.Click += btnNhapLai_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(261, 31);
            label1.Name = "label1";
            label1.Size = new Size(282, 28);
            label1.TabIndex = 1;
            label1.Text = "CHƯƠNG TRÌNH CỘNG 2 SỐ";
            label1.Click += label1_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = SystemColors.ActiveCaption;
            label.Location = new Point(156, 121);
            label.Name = "label";
            label.Size = new Size(85, 20);
            label.TabIndex = 2;
            label.Text = "Số thứ nhất";
            label.Click += label2_Click;
            // 
            // txtSoThuNhat
            // 
            txtSoThuNhat.Location = new Point(307, 118);
            txtSoThuNhat.Name = "txtSoThuNhat";
            txtSoThuNhat.Size = new Size(236, 27);
            txtSoThuNhat.TabIndex = 3;
            txtSoThuNhat.TextChanged += txt_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Location = new Point(156, 178);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 4;
            label3.Text = "Số thứ hai";
            label3.Click += label3_Click_1;
            // 
            // txtSoThuHai
            // 
            txtSoThuHai.Location = new Point(307, 177);
            txtSoThuHai.Name = "txtSoThuHai";
            txtSoThuHai.Size = new Size(236, 27);
            txtSoThuHai.TabIndex = 5;
            txtSoThuHai.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(156, 238);
            label4.Name = "label4";
            label4.Size = new Size(83, 28);
            label4.TabIndex = 4;
            label4.Text = "Tổng là";
            label4.Click += label3_Click_1;
            // 
            // txtTong
            // 
            txtTong.Location = new Point(307, 237);
            txtTong.Name = "txtTong";
            txtTong.ReadOnly = true;
            txtTong.Size = new Size(236, 27);
            txtTong.TabIndex = 5;
            txtTong.TextChanged += textBox2_TextChanged;
            // 
            // btnTinhTong
            // 
            btnTinhTong.BackColor = SystemColors.HotTrack;
            btnTinhTong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTinhTong.ForeColor = SystemColors.Window;
            btnTinhTong.Location = new Point(142, 305);
            btnTinhTong.Name = "btnTinhTong";
            btnTinhTong.Size = new Size(118, 52);
            btnTinhTong.TabIndex = 0;
            btnTinhTong.Text = "Tính Tổng";
            btnTinhTong.UseVisualStyleBackColor = false;
            btnTinhTong.Click += btnTinhTong_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.HotTrack;
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = SystemColors.Window;
            btnThoat.Location = new Point(542, 305);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(113, 52);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(820, 449);
            Controls.Add(txtTong);
            Controls.Add(label4);
            Controls.Add(txtSoThuHai);
            Controls.Add(label3);
            Controls.Add(txtSoThuNhat);
            Controls.Add(label);
            Controls.Add(label1);
            Controls.Add(btnThoat);
            Controls.Add(btnTinhTong);
            Controls.Add(btnNhapLai);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNhapLai;
        private Label label1;
        private Label label;
        private TextBox txtSoThuNhat;
        private Label label3;
        private TextBox txtSoThuHai;
        private Label label4;
        private TextBox txtTong;
        private Button btnThoat;
        private Button btnTinhTong;
    }
}
