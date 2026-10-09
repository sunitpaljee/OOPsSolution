using System;
using System.Windows.Forms;
using System.Drawing;

public class Form2 : Form
{
	public Form2()
	{
		InisializeComponent();
	}
	void InisializeComponent()
	{
		this.Text = "Sunit Form";
		this.BackColor = Color.Blue;
		this.Size = new Size(600,600);
	}
	static void Main()
	{
		Form2 f = new Form2();
		Application.Run(f);
	}
} 