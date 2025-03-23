namespace Bai2
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
            label2 = new Label();
            txt_sothunhat = new TextBox();
            txt_sothuhai = new TextBox();
            btn_cong = new Button();
            btn_tru = new Button();
            btn_nha = new Button();
            chia = new Button();
            btn_xoa = new Button();
            label3 = new Label();
            txt_ketqua = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(153, 86);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 0;
            label1.Text = "Số thứ nhât";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 153);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 1;
            label2.Text = "Số thứ hai";
            // 
            // txt_sothunhat
            // 
            txt_sothunhat.Location = new Point(278, 79);
            txt_sothunhat.Name = "txt_sothunhat";
            txt_sothunhat.Size = new Size(272, 27);
            txt_sothunhat.TabIndex = 2;
            txt_sothunhat.KeyPress += txt_sothunhat_KeyPress;
            // 
            // txt_sothuhai
            // 
            txt_sothuhai.Location = new Point(278, 146);
            txt_sothuhai.Name = "txt_sothuhai";
            txt_sothuhai.Size = new Size(272, 27);
            txt_sothuhai.TabIndex = 3;
            txt_sothuhai.KeyPress += txt_sothuhai_KeyPress;
            // 
            // btn_cong
            // 
            btn_cong.Location = new Point(237, 254);
            btn_cong.Name = "btn_cong";
            btn_cong.Size = new Size(40, 29);
            btn_cong.TabIndex = 4;
            btn_cong.Text = "+";
            btn_cong.UseVisualStyleBackColor = true;
            btn_cong.Click += btn_cong_Click;
            // 
            // btn_tru
            // 
            btn_tru.Location = new Point(308, 254);
            btn_tru.Name = "btn_tru";
            btn_tru.Size = new Size(40, 29);
            btn_tru.TabIndex = 5;
            btn_tru.Text = "-";
            btn_tru.UseVisualStyleBackColor = true;
            btn_tru.Click += btn_tru_Click;
            // 
            // btn_nha
            // 
            btn_nha.Location = new Point(376, 254);
            btn_nha.Name = "btn_nha";
            btn_nha.Size = new Size(40, 29);
            btn_nha.TabIndex = 6;
            btn_nha.Text = "*";
            btn_nha.UseVisualStyleBackColor = true;
            btn_nha.Click += btn_nha_Click;
            // 
            // chia
            // 
            chia.Location = new Point(444, 254);
            chia.Name = "chia";
            chia.Size = new Size(40, 29);
            chia.TabIndex = 7;
            chia.Text = "/";
            chia.UseVisualStyleBackColor = true;
            chia.Click += chia_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(513, 254);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(94, 29);
            btn_xoa.TabIndex = 8;
            btn_xoa.Text = "Del";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(237, 352);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 9;
            label3.Text = "Kết quả";
            // 
            // txt_ketqua
            // 
            txt_ketqua.Location = new Point(322, 345);
            txt_ketqua.Name = "txt_ketqua";
            txt_ketqua.Size = new Size(216, 27);
            txt_ketqua.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_ketqua);
            Controls.Add(label3);
            Controls.Add(btn_xoa);
            Controls.Add(chia);
            Controls.Add(btn_nha);
            Controls.Add(btn_tru);
            Controls.Add(btn_cong);
            Controls.Add(txt_sothuhai);
            Controls.Add(txt_sothunhat);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_sothunhat;
        private TextBox txt_sothuhai;
        private Button btn_cong;
        private Button btn_tru;
        private Button btn_nha;
        private Button chia;
        private Button btn_xoa;
        private Label label3;
        private TextBox txt_ketqua;
    }
}
