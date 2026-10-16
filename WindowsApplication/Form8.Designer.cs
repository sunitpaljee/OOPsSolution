namespace WindowsApplication
{
    partial class Form8
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
            pictureBox1 = new PictureBox();
            colorDialog1 = new ColorDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            fontDialog1 = new FontDialog();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            btnChangeColor = new Button();
            btnChangeFont = new Button();
            btnLoadImage = new Button();
            btnSaveImage = new Button();
            btnShowMessageBox = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(855, 554);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnChangeColor
            // 
            btnChangeColor.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChangeColor.Location = new Point(372, 31);
            btnChangeColor.Name = "btnChangeColor";
            btnChangeColor.Size = new Size(416, 75);
            btnChangeColor.TabIndex = 1;
            btnChangeColor.Text = "Changes Color";
            btnChangeColor.UseVisualStyleBackColor = true;
            btnChangeColor.Click += btnChangeColor_Click;
            // 
            // btnChangeFont
            // 
            btnChangeFont.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChangeFont.Location = new Point(372, 112);
            btnChangeFont.Name = "btnChangeFont";
            btnChangeFont.Size = new Size(416, 75);
            btnChangeFont.TabIndex = 2;
            btnChangeFont.Text = "Changes Font";
            btnChangeFont.UseVisualStyleBackColor = true;
            btnChangeFont.Click += btnChangeFont_Click;
            // 
            // btnLoadImage
            // 
            btnLoadImage.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoadImage.Location = new Point(372, 203);
            btnLoadImage.Name = "btnLoadImage";
            btnLoadImage.Size = new Size(416, 75);
            btnLoadImage.TabIndex = 3;
            btnLoadImage.Text = "Load Image";
            btnLoadImage.UseVisualStyleBackColor = true;
            btnLoadImage.Click += btnLoadImage_Click;
            // 
            // btnSaveImage
            // 
            btnSaveImage.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveImage.Location = new Point(372, 295);
            btnSaveImage.Name = "btnSaveImage";
            btnSaveImage.Size = new Size(416, 75);
            btnSaveImage.TabIndex = 4;
            btnSaveImage.Text = "Save Image";
            btnSaveImage.UseVisualStyleBackColor = true;
            btnSaveImage.Click += btnSaveImage_Click;
            // 
            // btnShowMessageBox
            // 
            btnShowMessageBox.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowMessageBox.Location = new Point(0, 479);
            btnShowMessageBox.Name = "btnShowMessageBox";
            btnShowMessageBox.Size = new Size(855, 75);
            btnShowMessageBox.TabIndex = 5;
            btnShowMessageBox.Text = "Show Message Box";
            btnShowMessageBox.UseVisualStyleBackColor = true;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 554);
            Controls.Add(btnShowMessageBox);
            Controls.Add(btnSaveImage);
            Controls.Add(btnLoadImage);
            Controls.Add(btnChangeFont);
            Controls.Add(btnChangeColor);
            Controls.Add(pictureBox1);
            Name = "Form8";
            Text = "Form8";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private ColorDialog colorDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
        private FontDialog fontDialog1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button btnChangeColor;
        private Button btnChangeFont;
        private Button btnLoadImage;
        private Button btnSaveImage;
        private Button btnShowMessageBox;
    }
}