namespace WindowsApplication
{
    partial class Form7
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
            cmbQuater = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cmbMonths = new ComboBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmbQuater
            // 
            cmbQuater.FormattingEnabled = true;
            cmbQuater.Location = new Point(62, 141);
            cmbQuater.Name = "cmbQuater";
            cmbQuater.Size = new Size(182, 33);
            cmbQuater.TabIndex = 0;
            cmbQuater.SelectedIndexChanged += cmbQuater_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(65, 70);
            label1.Name = "label1";
            label1.Size = new Size(119, 38);
            label1.TabIndex = 1;
            label1.Text = "Quaters";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(464, 81);
            label2.Name = "label2";
            label2.Size = new Size(118, 38);
            label2.TabIndex = 2;
            label2.Text = "Months";
            // 
            // cmbMonths
            // 
            cmbMonths.FormattingEnabled = true;
            cmbMonths.Location = new Point(464, 141);
            cmbMonths.Name = "cmbMonths";
            cmbMonths.Size = new Size(182, 33);
            cmbMonths.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(250, 209);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(275, 168);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(cmbMonths);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbQuater);
            Name = "Form7";
            Text = "Form7";
            Load += Form7_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbQuater;
        private Label label1;
        private Label label2;
        private ComboBox cmbMonths;
        private PictureBox pictureBox1;
    }
}