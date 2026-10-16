using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            string[] queters = { "Quater1", "Quater2", "Quater3", "Quarter4" };
            cmbQuater.Items.AddRange(queters);
        }

        private void cmbQuater_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] quater1 = { "January", "February", "March" };
            string quater2 = "April, May, June";
            string quater3 = "July, August, September";
            string quater4 = "October, November, December";
            cmbMonths.Items.Clear();
            switch(cmbQuater.SelectedIndex)
            {
                case 0:
                    cmbMonths.Items.AddRange(quater1);
                    break;
                case 1:
                    cmbMonths.Items.AddRange(quater2.Split(','));
                    break;
                case 2:
                    cmbMonths.Items.AddRange(quater3.Split(','));
                    break;
                case 3:
                    cmbMonths.Items.AddRange(quater4.Split(','));
                    break;
            }
        }
    }
}
