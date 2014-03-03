using System;
using Gtk;
using System.Collections.Generic;

public partial class MainWindow: Gtk.Window
{	
	//VISIBILIDAD AL RESTO DE METODOS
		List<int> numeros = new List<int>();
		Random ran = new Random();
	
		private Table table;
		private Table tableExtraidos;
		private List<Button> buttons;
		
		private int numTotalBolas = 90;
	
	private static readonly Gdk.Color COLOR_GREEN = new Gdk.Color(0,255,0);
	
	public  MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		// CREACION DE LA TABLA PARA LOS NUMEROS
		
		//uint numTotalFilas = ((uint)numTotalBolas-1) /10 +1;
		table = new Table(9, 10, true);
		vbox1.Add (table);
		table.Visible = true;
				
		buttons = new List<Button>();
		
		
		
		
		tableExtraidos = new Table (1,1, true);
		vbox1.Add (tableExtraidos);
		tableExtraidos.Visible = true;
		
		addButtons();
		addButtonExtraido();
		//
							
		
		//los numeros metidos en array
			for (int numero=1; numero <= numTotalBolas; numero++)
			{
			numeros.Add(numero);	
			}
		
		
		    buttonBola.Clicked += delegate {
			int aleatorio = ran.Next(numeros.Count);
			
		    int	numExtraido = numeros [aleatorio];
			
			
			labelBola.LabelProp = numExtraido.ToString();
			//espeak(numExtraido);
			
				
			
			buttons[numExtraido -1 ].ModifyBg (StateType.Normal, COLOR_GREEN);
			
			numeros.Remove(numExtraido);
			
			showNumeros();
			addButtonExtraido();
			
			};
		
		
		
		
		
		
	/*	foreach (var num in numeros)
		{
   			 Console.Write(num + " ");
		}
		*/
		
	}
	
	//CREACION DE LOS 99 BOTONES DEL NUMERO 
		
	private void addButtons (){
			
			
		for (int index = 0; index < numTotalBolas; index++){
			
			Button button = new Button();
			button.Label = string.Format ("{0}", index + 1);
			button.Visible = true;
			
			buttons.Add (button);
			uint fila = (uint)index /10;
			uint columna = (uint)index % 10;
			
			table.Attach(button, columna , columna + 1, fila, fila +1 );
		
		
			}
			
		}
	
	private void addButtonExtraido(){
		Button button = new Button();
		button.Label = labelBola.Text; //CORREGIR ESTO QUE NO SALE NADAAA
		button.Visible = true;
		
		int index = tableExtraidos.Children.Length;
		
		uint fila = (uint)index /10;
		uint columna = (uint)index % 10 ;
		tableExtraidos.Attach(button,columna,columna+1,fila,fila+1);
		
		
	}
	//
	
	//VA MOSTRANDO LOS NUMEROS RESTANTES
	private void showNumeros(){
	
		foreach (var num in numeros)
		{
   			 Console.Write(num + " ");
			Console.WriteLine();
		}
		
		
	}
	
	//FALTA LA FUNCION DEL ESPEAK PA QUE CANTE
	
	 void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	
	/*
	 public static  void OnButtonBolaClicked (object sender, System.EventArgs e)
	{
		
		aleatorio = ran.Next(1, 75);
		
		
		
		labelBola.LabelProp = aleatorio.ToString();
		
		
	}
	*/
}
