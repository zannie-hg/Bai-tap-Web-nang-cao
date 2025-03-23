namespace bai2
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
            txtSoThuNhat = new TextBox();
            label2 = new Label();
            txtSoThuHai = new TextBox();
            btnCong = new Button();
            btnTru = new Button();
            btnNhan = new Button();
            btnChia = new Button();
            btnDelete = new Button();
            label3 = new Label();
            txtKetQua = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(221, 121);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "Số thứ nhất";
            label1.Click += label1_Click;
            // 
            // txtSoThuNhat
            // 
            txtSoThuNhat.Location = new Point(348, 115);
            txtSoThuNhat.Name = "txtSoThuNhat";
            txtSoThuNhat.Size = new Size(192, 23);
            txtSoThuNhat.TabIndex = 1;
            txtSoThuNhat.Click += txtSoThuNhat_Click;
            txtSoThuNhat.KeyPress += txtSoThuNhat_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(221, 192);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 0;
            label2.Text = "Số thứ hai";
            label2.Click += label1_Click;
            // 
            // txtSoThuHai
            // 
            txtSoThuHai.Location = new Point(348, 186);
            txtSoThuHai.Name = "txtSoThuHai";
            txtSoThuHai.Size = new Size(192, 23);
            txtSoThuHai.TabIndex = 1;
            txtSoThuHai.KeyPress += txtSoThuHai_KeyPress;
            // 
            // btnCong
            // 
            btnCong.Location = new Point(144, 274);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(75, 23);
            btnCong.TabIndex = 2;
            btnCong.Text = "+";
            btnCong.UseVisualStyleBackColor = true;
            btnCong.Click += btnCong_Click;
            // 
            // btnTru
            // 
            btnTru.Location = new Point(252, 274);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(75, 23);
            btnTru.TabIndex = 2;
            btnTru.Text = "-";
            btnTru.UseVisualStyleBackColor = true;
            btnTru.Click += btnTru_Click;
            // 
            // btnNhan
            // 
            btnNhan.Location = new Point(361, 274);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(75, 23);
            btnNhan.TabIndex = 2;
            btnNhan.Text = "*";
            btnNhan.UseVisualStyleBackColor = true;
            btnNhan.Click += btnNhan_Click;
            // 
            // btnChia
            // 
            btnChia.Location = new Point(474, 274);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(75, 23);
            btnChia.TabIndex = 2;
            btnChia.Text = "/";
            btnChia.UseVisualStyleBackColor = true;
            btnChia.Click += btnChia_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(590, 274);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(221, 349);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 0;
            label3.Text = "Kết quả";
            label3.Click += label1_Click;
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(348, 343);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(192, 23);
            txtKetQua.TabIndex = 1;
            txtKetQua.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnChia);
            Controls.Add(btnNhan);
            Controls.Add(btnTru);
            Controls.Add(btnCong);
            Controls.Add(txtSoThuHai);
            Controls.Add(label2);
            Controls.Add(txtKetQua);
            Controls.Add(label3);
            Controls.Add(txtSoThuNhat);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSoThuNhat;
        private Label label2;
        private TextBox txtSoThuHai;
        private Button btnCong;
        private Button btnTru;
        private Button btnNhan;
        private Button btnChia;
        private Button btnDelete;
        private Label label3;
        private TextBox txtKetQua;
    }
}
