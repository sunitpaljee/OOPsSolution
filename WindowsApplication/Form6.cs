using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            string[] states = { "Andhra Pradesh", "Arunachal Pradesh", "Assam", "Bihar", "Chhattisgarh", "Goa", "Gujarat", "Haryana", "Himachal Pradesh", "Jharkhand", "Karnataka", "Kerala", "Madhya Pradesh", "Maharashtra", "Manipur", "Meghalaya", "Mizoram", "Nagaland", "Odisha", "Punjab", "Rajasthan", "Sikkim", "Tamil Nadu", "Telangana", "Tripura", "Uttar Pradesh", "Uttarakhand", "West Bengal" };
            foreach (string state in states)
            {
                listBox1.Items.Add(state);
            }
        }

        private void btnCountry_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem.ToString());
        }

        private void btnState_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedItem.ToString());
        }

        private void btnCity_Click(object sender, EventArgs e)
        {
            string str = null;
            foreach (object obj in checkedListBox1.CheckedItems)
            {
                str += obj.ToString() + " ,";
            }
            str = str.Substring(0, str.Length - 2);
            int pos = str.LastIndexOf(",");
            if (pos != -1)
            {
                str = str.Remove(pos, 1);
                str = str.Insert(pos, "and ");
            }
            MessageBox.Show(str);
        }
    }
}
