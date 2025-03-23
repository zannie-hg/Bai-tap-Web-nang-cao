namespace frmDataGridView
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
            dgvProducts = new DataGridView();
            btnDataTable = new Button();
            btnList_Click = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(63, 41);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(686, 236);
            dgvProducts.TabIndex = 0;
            // 
            // btnDataTable
            // 
            btnDataTable.Location = new Point(108, 359);
            btnDataTable.Name = "btnDataTable";
            btnDataTable.Size = new Size(219, 29);
            btnDataTable.TabIndex = 1;
            btnDataTable.Text = "Binding with DataTable";
            btnDataTable.UseVisualStyleBackColor = true;
            btnDataTable.Click += btnDataTable_Click;
            // 
            // btnList_Click
            // 
            btnList_Click.Location = new Point(431, 359);
            btnList_Click.Name = "btnList_Click";
            btnList_Click.Size = new Size(218, 29);
            btnList_Click.TabIndex = 2;
            btnList_Click.Text = "Binding with List";
            btnList_Click.UseVisualStyleBackColor = true;
            btnList_Click.Click += btnList_Click_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnList_Click);
            Controls.Add(btnDataTable);
            Controls.Add(dgvProducts);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProducts;
        private Button btnDataTable;
        private Button btnList_Click;
    }
}
