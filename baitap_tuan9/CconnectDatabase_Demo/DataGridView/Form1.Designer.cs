namespace DataGridView
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
            dtgStudent = new System.Windows.Forms.DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtStudentID = new TextBox();
            btnInsert = new Button();
            label3 = new Label();
            txtStudentName = new TextBox();
            label4 = new Label();
            txtClassID = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgStudent).BeginInit();
            SuspendLayout();
            // 
            // dtgStudent
            // 
            dtgStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgStudent.Location = new Point(12, 56);
            dtgStudent.Name = "dtgStudent";
            dtgStudent.RowHeadersWidth = 51;
            dtgStudent.Size = new Size(382, 382);
            dtgStudent.TabIndex = 0;
            dtgStudent.CellContentClick += dtgStudent_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(431, 70);
            label1.Name = "label1";
            label1.Size = new Size(190, 28);
            label1.TabIndex = 1;
            label1.Text = "Student Infomation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(418, 139);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 2;
            label2.Text = "Student ID";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(530, 137);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(224, 27);
            txtStudentID.TabIndex = 3;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnInsert.Location = new Point(421, 363);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(93, 40);
            btnInsert.TabIndex = 4;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(400, 200);
            label3.Name = "label3";
            label3.Size = new Size(125, 25);
            label3.TabIndex = 2;
            label3.Text = "Student Name";
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(530, 198);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(224, 27);
            txtStudentName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(418, 268);
            label4.Name = "label4";
            label4.Size = new Size(75, 25);
            label4.TabIndex = 2;
            label4.Text = "Class ID";
            // 
            // txtClassID
            // 
            txtClassID.Location = new Point(530, 266);
            txtClassID.Name = "txtClassID";
            txtClassID.Size = new Size(224, 27);
            txtClassID.TabIndex = 3;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(550, 363);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(93, 40);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(679, 363);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(93, 40);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(txtClassID);
            Controls.Add(label4);
            Controls.Add(txtStudentName);
            Controls.Add(label3);
            Controls.Add(txtStudentID);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtgStudent);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dtgStudent;
        private Label label1;
        private Label label2;
        private TextBox txtStudentID;
        private Button btnInsert;
        private Label label3;
        private TextBox txtStudentName;
        private Label label4;
        private TextBox txtClassID;
        private Button btnUpdate;
        private Button btnDelete;
    }
}
