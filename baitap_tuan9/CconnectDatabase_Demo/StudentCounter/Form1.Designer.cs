namespace StudentCounter
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
            txtClassID = new TextBox();
            label2 = new Label();
            txtNumber = new TextBox();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(172, 103);
            label1.Name = "label1";
            label1.Size = new Size(101, 21);
            label1.TabIndex = 0;
            label1.Text = "Enter ClassID";
            // 
            // txtClassID
            // 
            txtClassID.Location = new Point(328, 101);
            txtClassID.Name = "txtClassID";
            txtClassID.Size = new Size(245, 23);
            txtClassID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(172, 165);
            label2.Name = "label2";
            label2.Size = new Size(150, 21);
            label2.TabIndex = 0;
            label2.Text = "Number of Students";
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(328, 163);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(245, 23);
            txtNumber.TabIndex = 1;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(258, 247);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(257, 47);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Calculate Number of Students";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalculate);
            Controls.Add(txtNumber);
            Controls.Add(label2);
            Controls.Add(txtClassID);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtClassID;
        private Label label2;
        private TextBox txtNumber;
        private Button btnCalculate;
    }
}
