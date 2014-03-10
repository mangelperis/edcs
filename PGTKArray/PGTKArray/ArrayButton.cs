using System;
using Gtk;

namespace PGTKArray
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class ArrayButton : Gtk.Bin
	{
	private int filas = 1;
	private int columnas = 1;
	private Table table;	
		public ArrayButton ()
		{
			this.Build ();
			
			
			
			 table = new Table((uint)filas,(uint)columnas,true);
			Add (table);
		}
	
	

	
		private void refresh() {
		
			Button button = new Button();
			button.Visible=true;
			button.Label = "33";
			table.Attach(button,0,1,0,1);
			
		}
			
	
	
	}
	
}

