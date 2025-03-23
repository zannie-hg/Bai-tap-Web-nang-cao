namespace Student_Infomation
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
            lsvStudent = new ListView();
            label1 = new Label();
            label2 = new Label();
            txtStudentID = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label4 = new Label();
            txtClassID = new TextBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // lsvStudent
            // 
            lsvStudent.Location = new Point(21, 72);
            lsvStudent.Name = "lsvStudent";
            lsvStudent.Size = new Size(323, 345);
            lsvStudent.TabIndex = 0;
            lsvStudent.UseCompatibleStateImageBehavior = false;
            lsvStudent.SelectedIndexChanged += lsvStudent_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(416, 126);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 1;
            label1.Text = "Student ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(416, 72);
            label2.Name = "label2";
            label2.Size = new Size(188, 25);
            label2.TabIndex = 2;
            label2.Text = "Student Infomation";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(520, 123);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(175, 23);
            txtStudentID.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(416, 184);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 1;
            label3.Text = "Full Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(520, 181);
            txtName.Name = "txtName";
            txtName.Size = new Size(175, 23);
            txtName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(416, 242);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 1;
            label4.Text = "Class ID";
            // 
            // txtClassID
            // 
            txtClassID.Location = new Point(520, 239);
            txtClassID.Name = "txtClassID";
            txtClassID.Size = new Size(175, 23);
            txtClassID.TabIndex = 3;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnInsert.Location = new Point(387, 319);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(95, 43);
            btnInsert.TabIndex = 4;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(520, 319);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(95, 43);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(656, 319);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 43);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(txtClassID);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(txtStudentID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lsvStudent);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lsvStudent;
        private Label label1;
        private Label label2;
        private TextBox txtStudentID;
        private Label label3;
        private TextBox txtName;
        private Label label4;
        private TextBox txtClassID;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
    }
}
