namespace NguyenThiHaGiangWF_BOOK
{
    partial class UpdateBook
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
            txtBookID = new TextBox();
            btnInsert = new Button();
            label3 = new Label();
            txtBookName = new TextBox();
            label4 = new Label();
            txtAuthor = new TextBox();
            label5 = new Label();
            txtPublicationYear = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(309, 104);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 0;
            label1.Text = "UPDATE BOOK";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(152, 171);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "BOOK ID";
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(259, 168);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(263, 27);
            txtBookID.TabIndex = 2;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(104, 383);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 3;
            btnInsert.Text = "INSERT";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(152, 225);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 1;
            label3.Text = "BOOK NAME";
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(259, 222);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(263, 27);
            txtBookName.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(152, 278);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 1;
            label4.Text = "AUTHOR";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(259, 275);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(263, 27);
            txtAuthor.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(104, 328);
            label5.Name = "label5";
            label5.Size = new Size(147, 20);
            label5.TabIndex = 1;
            label5.Text = "PUBLICCATION YEAR";
            label5.Click += label5_Click;
            // 
            // txtPublicationYear
            // 
            txtPublicationYear.Location = new Point(259, 325);
            txtPublicationYear.Name = "txtPublicationYear";
            txtPublicationYear.Size = new Size(263, 27);
            txtPublicationYear.TabIndex = 2;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(244, 383);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(382, 383);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(516, 383);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 3;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // UpdateBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 447);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(txtPublicationYear);
            Controls.Add(label5);
            Controls.Add(txtAuthor);
            Controls.Add(label4);
            Controls.Add(txtBookName);
            Controls.Add(label3);
            Controls.Add(txtBookID);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateBook";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtBookID;
        private Button btnInsert;
        private Label label3;
        private TextBox txtBookName;
        private Label label4;
        private TextBox txtAuthor;
        private Label label5;
        private TextBox txtPublicationYear;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnExit;
    }
}
