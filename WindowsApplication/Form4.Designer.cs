namespace WindowsApplication
{
    partial class Form4
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
            label2 = new Label();
            txtName = new TextBox();
            txtFees = new TextBox();
            groupBox1 = new GroupBox();
            chkC = new CheckBox();
            chkCPP = new CheckBox();
            chkJava = new CheckBox();
            chkASP = new CheckBox();
            chkCSharp = new CheckBox();
            chkVB = new CheckBox();
            chkWPF = new CheckBox();
            chkMSSQL = new CheckBox();
            chkOracle = new CheckBox();
            groupBox2 = new GroupBox();
            radioNormal = new RadioButton();
            radioFast = new RadioButton();
            radioSuperFast = new RadioButton();
            btnReset = new Button();
            btnClose = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(84, 53);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 0;
            label1.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(559, 53);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 1;
            label2.Text = "Total Fees :";
            // 
            // txtName
            // 
            txtName.Location = new Point(220, 47);
            txtName.Name = "txtName";
            txtName.Size = new Size(287, 31);
            txtName.TabIndex = 2;
            // 
            // txtFees
            // 
            txtFees.Enabled = false;
            txtFees.Location = new Point(749, 53);
            txtFees.Name = "txtFees";
            txtFees.Size = new Size(307, 31);
            txtFees.TabIndex = 3;
            txtFees.Text = "0";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkWPF);
            groupBox1.Controls.Add(chkMSSQL);
            groupBox1.Controls.Add(chkOracle);
            groupBox1.Controls.Add(chkASP);
            groupBox1.Controls.Add(chkCSharp);
            groupBox1.Controls.Add(chkVB);
            groupBox1.Controls.Add(chkJava);
            groupBox1.Controls.Add(chkCPP);
            groupBox1.Controls.Add(chkC);
            groupBox1.Location = new Point(220, 191);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(836, 310);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Course Offered";
            // 
            // chkC
            // 
            chkC.AutoSize = true;
            chkC.Location = new Point(82, 53);
            chkC.Name = "chkC";
            chkC.Size = new Size(94, 29);
            chkC.TabIndex = 0;
            chkC.Tag = "750";
            chkC.Text = "C (750)";
            chkC.UseVisualStyleBackColor = true;
            chkC.CheckedChanged += chkC_CheckedChanged;
            // 
            // chkCPP
            // 
            chkCPP.AutoSize = true;
            chkCPP.Location = new Point(82, 146);
            chkCPP.Name = "chkCPP";
            chkCPP.Size = new Size(124, 29);
            chkCPP.TabIndex = 1;
            chkCPP.Tag = "1000";
            chkCPP.Text = "CPP (1000)";
            chkCPP.UseVisualStyleBackColor = true;
            chkCPP.CheckedChanged += chkC_CheckedChanged;
            // 
            // chkJava
            // 
            chkJava.AutoSize = true;
            chkJava.Location = new Point(82, 238);
            chkJava.Name = "chkJava";
            chkJava.Size = new Size(126, 29);
            chkJava.TabIndex = 2;
            chkJava.Tag = "4000";
            chkJava.Text = "Java (4000)";
            chkJava.UseVisualStyleBackColor = true;
            chkJava.CheckedChanged += chkC_CheckedChanged;
            // 
            // chkASP
            // 
            chkASP.AutoSize = true;
            chkASP.Location = new Point(355, 233);
            chkASP.Name = "chkASP";
            chkASP.Size = new Size(160, 29);
            chkASP.TabIndex = 5;
            chkASP.Tag = "1500";
            chkASP.Text = "ASP.NET (1500)";
            chkASP.UseVisualStyleBackColor = true;
            chkASP.CheckedChanged += chkC_CheckedChanged;
            // 
            // chkCSharp
            // 
            chkCSharp.AutoSize = true;
            chkCSharp.Location = new Point(355, 141);
            chkCSharp.Name = "chkCSharp";
            chkCSharp.Size = new Size(150, 29);
            chkCSharp.TabIndex = 4;
            chkCSharp.Tag = "1500";
            chkCSharp.Text = "C#.NET (1500)";
            chkCSharp.UseVisualStyleBackColor = true;
            chkCSharp.CheckedChanged += chkC_CheckedChanged;
            // 
            // chkVB
            // 
            chkVB.AutoSize = true;
            chkVB.Location = new Point(355, 48);
            chkVB.Name = "chkVB";
            chkVB.Size = new Size(154, 29);
            chkVB.TabIndex = 3;
            chkVB.Tag = "1000";
            chkVB.Text = "VB ,NET (1000)";
            chkVB.UseVisualStyleBackColor = true;
            chkVB.CheckedChanged += chkC_CheckedChanged;
            // 
            // chkWPF
            // 
            chkWPF.AutoSize = true;
            chkWPF.Location = new Point(639, 233);
            chkWPF.Name = "chkWPF";
            chkWPF.Size = new Size(119, 29);
            chkWPF.TabIndex = 8;
            chkWPF.Tag = "600";
            chkWPF.Text = "WPF (600)";
            chkWPF.UseVisualStyleBackColor = true;
            chkWPF.CheckedChanged += chkC_CheckedChanged;
            // 
            // chkMSSQL
            // 
            chkMSSQL.AutoSize = true;
            chkMSSQL.Location = new Point(639, 141);
            chkMSSQL.Name = "chkMSSQL";
            chkMSSQL.Size = new Size(146, 29);
            chkMSSQL.TabIndex = 7;
            chkMSSQL.Tag = "500";
            chkMSSQL.Text = "MS SQL (500)";
            chkMSSQL.UseVisualStyleBackColor = true;
            chkMSSQL.CheckedChanged += chkC_CheckedChanged;
            // 
            // chkOracle
            // 
            chkOracle.AutoSize = true;
            chkOracle.Location = new Point(639, 48);
            chkOracle.Name = "chkOracle";
            chkOracle.Size = new Size(143, 29);
            chkOracle.TabIndex = 6;
            chkOracle.Tag = "1000";
            chkOracle.Text = "Oracle (1000)";
            chkOracle.UseVisualStyleBackColor = true;
            chkOracle.CheckedChanged += chkC_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioSuperFast);
            groupBox2.Controls.Add(radioFast);
            groupBox2.Controls.Add(radioNormal);
            groupBox2.Location = new Point(220, 566);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(836, 150);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Track";
            // 
            // radioNormal
            // 
            radioNormal.AutoSize = true;
            radioNormal.Location = new Point(145, 55);
            radioNormal.Name = "radioNormal";
            radioNormal.Size = new Size(96, 29);
            radioNormal.TabIndex = 0;
            radioNormal.TabStop = true;
            radioNormal.Tag = "0";
            radioNormal.Text = "Normal";
            radioNormal.UseVisualStyleBackColor = true;
            radioNormal.CheckedChanged += radioNormal_CheckedChanged;
            // 
            // radioFast
            // 
            radioFast.AutoSize = true;
            radioFast.Location = new Point(374, 55);
            radioFast.Name = "radioFast";
            radioFast.Size = new Size(103, 29);
            radioFast.TabIndex = 1;
            radioFast.TabStop = true;
            radioFast.Tag = "50";
            radioFast.Text = "Fast (50)";
            radioFast.UseVisualStyleBackColor = true;
            radioFast.CheckedChanged += radioNormal_CheckedChanged;
            // 
            // radioSuperFast
            // 
            radioSuperFast.AutoSize = true;
            radioSuperFast.Location = new Point(639, 55);
            radioSuperFast.Name = "radioSuperFast";
            radioSuperFast.Size = new Size(164, 29);
            radioSuperFast.TabIndex = 2;
            radioSuperFast.TabStop = true;
            radioSuperFast.Tag = "100";
            radioSuperFast.Text = "Super Fast (100)";
            radioSuperFast.UseVisualStyleBackColor = true;
            radioSuperFast.CheckedChanged += radioNormal_CheckedChanged;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(302, 777);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(112, 34);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(859, 791);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 34);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 866);
            Controls.Add(btnClose);
            Controls.Add(btnReset);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtFees);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtFees;
        private GroupBox groupBox1;
        private CheckBox chkJava;
        private CheckBox chkCPP;
        private CheckBox chkC;
        private CheckBox chkWPF;
        private CheckBox chkMSSQL;
        private CheckBox chkOracle;
        private CheckBox chkASP;
        private CheckBox chkCSharp;
        private CheckBox chkVB;
        private GroupBox groupBox2;
        private RadioButton radioSuperFast;
        private RadioButton radioFast;
        private RadioButton radioNormal;
        private Button btnReset;
        private Button btnClose;
    }
}