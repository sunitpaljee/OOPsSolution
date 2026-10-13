using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                MessageBox.Show("RadioButton 1 is selected.");
            }
            else if (radioButton2.Checked)
            {
                MessageBox.Show("RadioButton 2 is selected.");
            }
            else if (radioButton3.Checked)
            {
                MessageBox.Show("RadioButton 3 is selected.");
            }            
            if (checkBox1.Checked)
            {
                MessageBox.Show("CheckBox 1 is checked.");
            }
            else if (checkBox2.Checked)
            {
                MessageBox.Show("CheckBox 2 is checked.");
            }
            else if (checkBox3.Checked)
            {
                MessageBox.Show("CheckBox 3 is checked.");
            }

        }
    }
}
