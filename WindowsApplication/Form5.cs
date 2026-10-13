using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter a value.");
                e.Cancel = true;
                return;
            }
            if (tb.Name == "txtUserName")
            {
                if (tb.Text.Trim().Length < 8)
                {
                    MessageBox.Show("Name must be at least 8 characters long.");
                    e.Cancel = true;
                    return;
                }
            }
            if (tb.Name == "txtPassword")
            {
                if (tb.Text.Trim().Length < 8)
                {
                    MessageBox.Show("Password must be at least 8 characters long.");
                    e.Cancel = true;
                    return;
                }
            }
            if (tb.Name == "txtConfirmPass")
            {
                if (tb.Text.Trim() != txtPassword.Text.Trim())
                {
                    MessageBox.Show("Confirm Password must match Password.");
                    e.Cancel = true;
                    return;
                }
                btnSave.Enabled = true;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
