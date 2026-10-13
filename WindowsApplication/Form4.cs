using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication
{
    public partial class Form4 : Form
    {
        int Count = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void chkC_CheckedChanged(object sender, EventArgs e)
        {
            radioNormal.Checked = true;
            int amt = int.Parse(txtFees.Text);
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
            {
                Count += 1;
                //amt += Convert.ToInt32(cb.Tag);
                amt = amt + Convert.ToInt32(cb.Tag);
            }
            else
            {
                Count -= 1;
                amt -= Convert.ToInt32(cb.Tag);
            }
            txtFees.Text = amt.ToString();
        }

        private void radioNormal_CheckedChanged(object sender, EventArgs e)
        {
            int amt = int.Parse(txtFees.Text);
            RadioButton rb = sender as RadioButton;
            //RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
                amt += (Convert.ToInt32(rb.Tag) * Count);
            else
                amt -= (Convert.ToInt32(rb.Tag) * Count);
            txtFees.Text = amt.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            foreach (Control ctrl in groupBox1.Controls)
            {
                CheckBox cb = ctrl as CheckBox;
                cb.Checked = false;
                txtFees.Text = "0";
                txtName.Focus();
            }
        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
