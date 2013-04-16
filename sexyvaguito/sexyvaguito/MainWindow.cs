using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnBoton1Clicked (object sender, EventArgs e)
	{   


		int a = int.Parse(this.barra1.Text);
		int b= int.Parse(this.barra2.Text);
		int c=a+b;

		this.barra3.Text=c.ToString();

	}

	protected void OnBoton2Clicked (object sender, EventArgs e)
	{
		int a = int.Parse(this.barra1.Text);
		int b= int.Parse(this.barra2.Text);
		int c=a-b;
		
		this.barra3.Text=c.ToString();

	}

	protected void OnBoton3Clicked (object sender, EventArgs e)
	{
		int a = int.Parse(this.barra1.Text);
		int b= int.Parse(this.barra2.Text);
		int c=a*b;
		
		this.barra3.Text=c.ToString();

	}

	protected void OnBoton4Clicked (object sender, EventArgs e)
	{
		int a = int.Parse(this.barra1.Text);
		int b= int.Parse(this.barra2.Text);
		int c=a/b;
		
		this.barra3.Text=c.ToString();

	}
}
