namespace CRUDStudentClass
{
    partial class FormSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtSearch = new TextBox();
            dtgStudent = new DataGridView();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgStudent).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 116);
            label1.Name = "label1";
            label1.Size = new Size(237, 28);
            label1.TabIndex = 0;
            label1.Text = "Search By Student Name";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(281, 116);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(199, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dtgStudent
            // 
            dtgStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgStudent.Location = new Point(56, 208);
            dtgStudent.Margin = new Padding(3, 4, 3, 4);
            dtgStudent.Name = "dtgStudent";
            dtgStudent.ReadOnly = true;
            dtgStudent.RowHeadersWidth = 51;
            dtgStudent.Size = new Size(424, 364);
            dtgStudent.TabIndex = 2;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(371, 37);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(91, 43);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // FormSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 622);
            Controls.Add(btnExit);
            Controls.Add(dtgStudent);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormSearch";
            Text = "frmSearchByStudentName";
            ((System.ComponentModel.ISupportInitialize)dtgStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearch;
        private DataGridView dtgStudent;
        private Button btnExit;
    }
}