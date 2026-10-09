using System.Windows.Forms;
using System.Drawing;
public class Form3 : Form
{
	Button button1;
	Button button2;
	Button button3;
	public Form3()
	{
		
		IC();
	}
	void IC()
	{
		this.Text = "Swathi Form";
		this.BackColor = Color.Green;
		this.Size = new Size(600,500);
		button1 = new Button();
		button1.Text = "Click Me!";
		button1.Size = new Size(100,50);
		button1.BackColor = Color.Red;
		button1.ForeColor = Color.White;
		button1.Location = new Point(200,100);
		
		button2 = new Button();
		button2.Text = "Button 3";
		button2.Size = new Size(100,50);
		button2.BackColor = Color.Blue;
		button2.ForeColor = Color.White;
		button2.Location = new Point(200,200);

		button3 = new Button();
		button3.Text = "B3 Click";
		button3.Size = new Size(100,50);
		button3.BackColor = Color.Brown;
		button3.ForeColor = Color.White;
		button3.Location = new Point(200,300);
		Controls.Add(button1);
		Controls.Add(button2);
		Controls.Add(button3);
	}
	static void Main()
	{
		Application.Run(new Form3());
	}
} 