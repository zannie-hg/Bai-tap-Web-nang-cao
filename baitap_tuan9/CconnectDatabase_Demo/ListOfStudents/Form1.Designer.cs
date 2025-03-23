namespace ListOfStudents
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
            lsvStudent = new ListView();
            lsbClass = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(147, 110);
            label1.Name = "label1";
            label1.Size = new Size(114, 21);
            label1.TabIndex = 0;
            label1.Text = "List of Classes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(504, 110);
            label2.Name = "label2";
            label2.Size = new Size(127, 21);
            label2.TabIndex = 0;
            label2.Text = "List of Students";
            // 
            // lsvStudent
            // 
            lsvStudent.Location = new Point(395, 145);
            lsvStudent.Name = "lsvStudent";
            lsvStudent.Size = new Size(348, 250);
            lsvStudent.TabIndex = 1;
            lsvStudent.UseCompatibleStateImageBehavior = false;
            lsvStudent.SelectedIndexChanged += lsvStudent_SelectedIndexChanged;
            // 
            // lsbClass
            // 
            lsbClass.FormattingEnabled = true;
            lsbClass.ItemHeight = 15;
            lsbClass.Location = new Point(51, 148);
            lsbClass.Name = "lsbClass";
            lsbClass.Size = new Size(307, 244);
            lsbClass.TabIndex = 2;
            lsbClass.SelectedIndexChanged += lsbClass_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lsbClass);
            Controls.Add(lsvStudent);
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
        private ListView lsvStudent;
        private ListBox lsbClass;
    }
}
