namespace WindowsApplication
{
    partial class Form5
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPass = new TextBox();
            txtPhoneNo = new TextBox();
            txtAddress = new TextBox();
            btnSave = new Button();
            btnClear = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(522, 43);
            label1.Name = "label1";
            label1.Size = new Size(341, 48);
            label1.TabIndex = 0;
            label1.Text = "Registration Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 149);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 1;
            label2.Text = "User Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(148, 234);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 2;
            label3.Text = "Password :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(148, 318);
            label4.Name = "label4";
            label4.Size = new Size(129, 25);
            label4.TabIndex = 3;
            label4.Text = "Confirm Pass : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(148, 415);
            label5.Name = "label5";
            label5.Size = new Size(100, 25);
            label5.TabIndex = 4;
            label5.Text = "Phone No :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(148, 485);
            label6.Name = "label6";
            label6.Size = new Size(86, 25);
            label6.TabIndex = 5;
            label6.Text = "Address :";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(540, 149);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(414, 45);
            txtUserName.TabIndex = 6;
            txtUserName.Validating += textBox1_Validating;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(540, 214);
            txtPassword.MaxLength = 16;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(414, 45);
            txtPassword.TabIndex = 7;
            txtPassword.Validating += textBox1_Validating;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPass.Location = new Point(540, 298);
            txtConfirmPass.MaxLength = 16;
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.PasswordChar = '*';
            txtConfirmPass.Size = new Size(414, 45);
            txtConfirmPass.TabIndex = 8;
            txtConfirmPass.Validating += textBox1_Validating;
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneNo.Location = new Point(540, 401);
            txtPhoneNo.MaxLength = 10;
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.Size = new Size(414, 45);
            txtPhoneNo.TabIndex = 9;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(540, 485);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(414, 231);
            txtAddress.TabIndex = 10;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(148, 775);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(540, 775);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(842, 775);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 34);
            btnClose.TabIndex = 13;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 884);
            Controls.Add(btnClose);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(txtAddress);
            Controls.Add(txtPhoneNo);
            Controls.Add(txtConfirmPass);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private TextBox txtConfirmPass;
        private TextBox txtPhoneNo;
        private TextBox txtAddress;
        private Button btnSave;
        private Button btnClear;
        private Button btnClose;
    }
}