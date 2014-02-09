using System;
using Gtk;
//Miguel Angel Peris Iborra
//TODO Al hacer click en buttonSumar, sumar los números en entry1 y entry2 mostrando el resultado en entryResult

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
	
	
	protected void OnButtonSumarClicked (object sender, System.EventArgs e)
	{
			try{
						
			decimal d1 = decimal.Parse(entry1.Text.Replace('.',','));
			decimal d2 = decimal.Parse(entry2.Text.Replace('.',','));
		
			
			
			decimal result = d1 + d2;
					
			entryResult.Text = result.ToString();
			
		}
		catch( System.FormatException ){
			entryResult.Text = "ERROR :: No has introducido números ";
		}
				
	}

	protected void OnResetClicked (object sender, System.EventArgs e)
	{
		string empty = "";
		entry1.Text = entry2.Text = entryResult.Text = empty;
	}

	protected void OnRestarClicked (object sender, System.EventArgs e)
	{
		try{
						
			decimal d1 = decimal.Parse(entry1.Text.Replace('.',','));
			decimal d2 = decimal.Parse(entry2.Text.Replace('.',','));
		
			
			
			decimal result = d1 - d2;
					
			entryResult.Text = result.ToString();
			
		}
		catch( System.FormatException ){
			entryResult.Text = "ERROR :: No has introducido números ";
		}
		
		
		
	}

	protected void OnMultiplicarClicked (object sender, System.EventArgs e)
	{
		try{
						
			decimal d1 = decimal.Parse(entry1.Text.Replace('.',','));
			decimal d2 = decimal.Parse(entry2.Text.Replace('.',','));
		
			
			
			decimal result = d1 * d2;
					
			entryResult.Text = result.ToString();
			
		}
		catch( System.FormatException ){
			entryResult.Text = "ERROR :: No has introducido números ";
		}
		
		
	}

	protected void OnDividirClicked (object sender, System.EventArgs e)
	{
		try{
						
			decimal d1 = decimal.Parse(entry1.Text.Replace('.',','));
			decimal d2 = decimal.Parse(entry2.Text.Replace('.',','));
		
			
			
			decimal result = d1 / d2;
					
			entryResult.Text = result.ToString();
			
		}
		catch( System.FormatException ){
			entryResult.Text = "ERROR :: No has introducido números ";
		}
	}
}
