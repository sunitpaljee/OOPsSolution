using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WindowsApplication
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if(sender.GetType() == typeof(Button))
        //    {
        //        if (sender is Button button)
        //        {
        //            MessageBox.Show(button.Text + " clicked!");
        //        }
        //    }
        //    else if(sender.GetType() == typeof(Label))
        //    {
        //        if (sender is Label label)
        //        {
        //            MessageBox.Show(label.Text + " clicked!");
        //        }
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender.GetType().Name == "Button")
            {
                if (button1.Name == "button1")
                    MessageBox.Show("Button1 is clicked");
                else
                    MessageBox.Show("Button2 is clicked");
            }
            else if (sender.GetType().Name == "Label")
            {   
                if(label1.Name == "label1")
                    MessageBox.Show("Label1 is clicked");
                else
                    MessageBox.Show("Label2 is clicked");
            }
            else
                MessageBox.Show("Form2 is clicked");
        }
    }
}
