namespace WindowsApplication
{
    partial class Form6
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
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            checkedListBox1 = new CheckedListBox();
            btnCountry = new Button();
            btnState = new Button();
            btnCity = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "India", "USA", "Japan", "Germany", "UK" });
            comboBox1.Location = new Point(64, 44);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Punjab", "Delhi", "Karntka", "Orisha", "UP", "Bihar" });
            listBox1.Location = new Point(312, 44);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(180, 129);
            listBox1.TabIndex = 1;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Bangalore", "Mysuru", "Mandia", "Delhi", "Kolkata", "Hyderabad" });
            checkedListBox1.Location = new Point(569, 44);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(180, 144);
            checkedListBox1.TabIndex = 2;
            // 
            // btnCountry
            // 
            btnCountry.AllowDrop = true;
            btnCountry.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCountry.Location = new Point(64, 302);
            btnCountry.Name = "btnCountry";
            btnCountry.Size = new Size(216, 111);
            btnCountry.TabIndex = 3;
            btnCountry.Text = "Show Selected Country";
            btnCountry.UseVisualStyleBackColor = true;
            btnCountry.Click += btnCountry_Click;
            // 
            // btnState
            // 
            btnState.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnState.Location = new Point(312, 302);
            btnState.Name = "btnState";
            btnState.Size = new Size(213, 111);
            btnState.TabIndex = 4;
            btnState.Text = "Show Selected State";
            btnState.UseVisualStyleBackColor = true;
            btnState.Click += btnState_Click;
            // 
            // btnCity
            // 
            btnCity.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCity.Location = new Point(559, 302);
            btnCity.Name = "btnCity";
            btnCity.Size = new Size(217, 111);
            btnCity.TabIndex = 5;
            btnCity.Text = "Show Selected City";
            btnCity.UseVisualStyleBackColor = true;
            btnCity.Click += btnCity_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCity);
            Controls.Add(btnState);
            Controls.Add(btnCountry);
            Controls.Add(checkedListBox1);
            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private ListBox listBox1;
        private CheckedListBox checkedListBox1;
        private Button btnCountry;
        private Button btnState;
        private Button btnCity;
    }
}