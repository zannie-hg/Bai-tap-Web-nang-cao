namespace ViewListOfStudents
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
            txtEnterClassID = new TextBox();
            btnViewClass = new Button();
            label2 = new Label();
            txtClassID = new TextBox();
            label3 = new Label();
            txtClassName = new TextBox();
            label4 = new Label();
            txtYear = new TextBox();
            btnViewStudent = new Button();
            lsvStudents = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 91);
            label1.Name = "label1";
            label1.Size = new Size(105, 21);
            label1.TabIndex = 0;
            label1.Text = "Enter Class ID";
            // 
            // txtEnterClassID
            // 
            txtEnterClassID.Location = new Point(142, 90);
            txtEnterClassID.Name = "txtEnterClassID";
            txtEnterClassID.Size = new Size(223, 23);
            txtEnterClassID.TabIndex = 1;
            // 
            // btnViewClass
            // 
            btnViewClass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewClass.Location = new Point(142, 156);
            btnViewClass.Name = "btnViewClass";
            btnViewClass.Size = new Size(221, 36);
            btnViewClass.TabIndex = 2;
            btnViewClass.Text = "View in detail";
            btnViewClass.UseVisualStyleBackColor = true;
            btnViewClass.Click += btnViewClass_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 218);
            label2.Name = "label2";
            label2.Size = new Size(65, 21);
            label2.TabIndex = 0;
            label2.Text = "Class ID";
            // 
            // txtClassID
            // 
            txtClassID.Location = new Point(142, 217);
            txtClassID.Name = "txtClassID";
            txtClassID.Size = new Size(223, 23);
            txtClassID.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 271);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 0;
            label3.Text = "Class Name";
            // 
            // txtClassName
            // 
            txtClassName.Location = new Point(142, 270);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(223, 23);
            txtClassName.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 325);
            label4.Name = "label4";
            label4.Size = new Size(40, 21);
            label4.TabIndex = 0;
            label4.Text = "Year";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(142, 324);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(223, 23);
            txtYear.TabIndex = 1;
            // 
            // btnViewStudent
            // 
            btnViewStudent.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewStudent.Location = new Point(400, 156);
            btnViewStudent.Name = "btnViewStudent";
            btnViewStudent.Size = new Size(388, 36);
            btnViewStudent.TabIndex = 2;
            btnViewStudent.Text = "View List of Students";
            btnViewStudent.UseVisualStyleBackColor = true;
            btnViewStudent.Click += btnViewStudent_Click;
            // 
            // lsvStudents
            // 
            lsvStudents.Location = new Point(400, 217);
            lsvStudents.Name = "lsvStudents";
            lsvStudents.Size = new Size(388, 172);
            lsvStudents.TabIndex = 3;
            lsvStudents.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lsvStudents);
            Controls.Add(btnViewStudent);
            Controls.Add(btnViewClass);
            Controls.Add(txtYear);
            Controls.Add(label4);
            Controls.Add(txtClassName);
            Controls.Add(label3);
            Controls.Add(txtClassID);
            Controls.Add(label2);
            Controls.Add(txtEnterClassID);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEnterClassID;
        private Button btnViewClass;
        private Label label2;
        private TextBox txtClassID;
        private Label label3;
        private TextBox txtClassName;
        private Label label4;
        private TextBox txtYear;
        private Button btnViewStudent;
        private ListView lsvStudents;
    }
}
