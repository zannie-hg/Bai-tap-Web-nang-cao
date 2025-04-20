namespace DemoEFCore
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txtTim = new TextBox();
            btnTim = new Button();
            btnThem = new Button();
            btnTaiLai = new Button();
            btnCapNhat = new Button();
            btnXoa = new Button();
            label2 = new Label();
            txtStudentID = new TextBox();
            label3 = new Label();
            txtStudentName = new TextBox();
            label4 = new Label();
            txtClassID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(471, 283);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 44);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 1;
            label1.Text = "Tìm theo tên";
            // 
            // txtTim
            // 
            txtTim.Location = new Point(113, 41);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(296, 23);
            txtTim.TabIndex = 2;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(432, 41);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(75, 23);
            btnTim.TabIndex = 3;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(550, 300);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnTaiLai
            // 
            btnTaiLai.Location = new Point(669, 100);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(75, 23);
            btnTaiLai.TabIndex = 4;
            btnTaiLai.Text = "Tải lại";
            btnTaiLai.UseVisualStyleBackColor = true;
            btnTaiLai.Click += btnTaiLai_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(669, 300);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(75, 23);
            btnCapNhat.TabIndex = 4;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(782, 300);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(542, 154);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 5;
            label2.Text = "Student ID";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(642, 146);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(168, 23);
            txtStudentID.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(542, 201);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 5;
            label3.Text = "Student Name";
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(642, 193);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(168, 23);
            txtStudentName.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(542, 252);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 5;
            label4.Text = "Class ID";
            // 
            // txtClassID
            // 
            txtClassID.Location = new Point(642, 244);
            txtClassID.Name = "txtClassID";
            txtClassID.Size = new Size(168, 23);
            txtClassID.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 431);
            Controls.Add(txtClassID);
            Controls.Add(label4);
            Controls.Add(txtStudentName);
            Controls.Add(label3);
            Controls.Add(txtStudentID);
            Controls.Add(label2);
            Controls.Add(btnTaiLai);
            Controls.Add(btnXoa);
            Controls.Add(btnCapNhat);
            Controls.Add(btnThem);
            Controls.Add(btnTim);
            Controls.Add(txtTim);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtTim;
        private Button btnTim;
        private Button btnThem;
        private Button btnTaiLai;
        private Button btnCapNhat;
        private Button btnXoa;
        private Label label2;
        private TextBox txtStudentID;
        private Label label3;
        private TextBox txtStudentName;
        private Label label4;
        private TextBox txtClassID;
    }
}
