namespace CRUDStudentClass
{
    partial class FormStudent
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
            dtgStudent = new DataGridView();
            groupBox1 = new GroupBox();
            txtClassID = new TextBox();
            label3 = new Label();
            txtStudentName = new TextBox();
            label2 = new Label();
            txtStudentID = new TextBox();
            label1 = new Label();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnLoad = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgStudent).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgStudent
            // 
            dtgStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgStudent.Location = new Point(16, 113);
            dtgStudent.Name = "dtgStudent";
            dtgStudent.ReadOnly = true;
            dtgStudent.Size = new Size(385, 273);
            dtgStudent.TabIndex = 0;
            dtgStudent.CellContentClick += dtgStudent_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtClassID);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtStudentName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtStudentID);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(423, 113);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(345, 190);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Infomation";
            // 
            // txtClassID
            // 
            txtClassID.Location = new Point(122, 148);
            txtClassID.Name = "txtClassID";
            txtClassID.Size = new Size(201, 23);
            txtClassID.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 151);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 0;
            label3.Text = "Class ID";
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(122, 92);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(201, 23);
            txtStudentName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 95);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 0;
            label2.Text = "Student Name";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(122, 37);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(201, 23);
            txtStudentID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 40);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Student ID";
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsert.Location = new Point(423, 332);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(101, 54);
            btnInsert.TabIndex = 2;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(545, 332);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(101, 54);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(667, 332);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(101, 54);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoad.Location = new Point(60, 27);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(236, 60);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "Load table Student";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(676, 27);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(92, 37);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // FormStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 404);
            Controls.Add(btnExit);
            Controls.Add(btnLoad);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(groupBox1);
            Controls.Add(dtgStudent);
            Name = "FormStudent";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgStudent).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgStudent;
        private GroupBox groupBox1;
        private TextBox txtStudentID;
        private Label label1;
        private TextBox txtClassID;
        private Label label3;
        private TextBox txtStudentName;
        private Label label2;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnLoad;
        private Button btnExit;
    }
}
