using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnChangeColor.BackColor = colorDialog1.Color;
            }
            else
            {
                btnChangeColor.BackColor = Color.Red;
               // MessageBox.Show("You have not selected any color");
            }
            //colorDialog1.ShowDialog();
        }

        private void btnChangeFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                btnChangeFont.Font = fontDialog1.Font;
            }
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
          //  openFileDialog1.Filter = "Image Files (*.jpg) | *.jpg | Icon images (*.ico) | *.ico | All Files(*.*) | *.*;
            openFileDialog1.FileName = "";
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr != DialogResult.Cancel)
            {
                string imgPath = openFileDialog1.FileName;
                pictureBox1.ImageLocation = imgPath;
            }

            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            //}
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
           // saveFileDialog1.Filter = "Image Files (*.jpg) | *.jpg | Icon Images (*.ico) | *.ico | All Files(*.*) | *.* ”;
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr != DialogResult.Cancel)
            {
                string imgPath = saveFileDialog1.FileName;
                pictureBox1.Image.Save(imgPath);
            }
        }
    }
}
