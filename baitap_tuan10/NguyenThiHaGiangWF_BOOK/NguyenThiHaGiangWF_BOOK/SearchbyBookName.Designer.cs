﻿namespace NguyenThiHaGiangWF_BOOK
{
    partial class SearchbyBookName
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
            label2 = new Label();
            dtgBook = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgBook).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 51);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter Book Name";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(258, 44);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(299, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 83);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 0;
            label2.Text = "Result";
            // 
            // dtgBook
            // 
            dtgBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgBook.Location = new Point(82, 106);
            dtgBook.Name = "dtgBook";
            dtgBook.RowHeadersWidth = 51;
            dtgBook.Size = new Size(559, 326);
            dtgBook.TabIndex = 2;
            dtgBook.CellContentClick += dtgBook_CellContentClick;
            // 
            // SearchbyBookName
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 484);
            Controls.Add(dtgBook);
            Controls.Add(txtSearch);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SearchbyBookName";
            Text = "FormSearch";
            ((System.ComponentModel.ISupportInitialize)dtgBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearch;
        private Label label2;
        private DataGridView dtgBook;
    }
}