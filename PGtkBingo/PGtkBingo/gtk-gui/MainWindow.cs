
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	private global::Gtk.Label labelBola;
	private global::Gtk.Button buttonBola;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.labelBola = new global::Gtk.Label ();
		this.labelBola.Name = "labelBola";
		this.vbox1.Add (this.labelBola);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.labelBola]));
		w1.Position = 0;
		// Container child vbox1.Gtk.Box+BoxChild
		this.buttonBola = new global::Gtk.Button ();
		this.buttonBola.WidthRequest = 100;
		this.buttonBola.HeightRequest = 30;
		this.buttonBola.CanFocus = true;
		this.buttonBola.Name = "buttonBola";
		this.buttonBola.UseUnderline = true;
		this.buttonBola.BorderWidth = ((uint)(10));
		this.buttonBola.Label = global::Mono.Unix.Catalog.GetString ("SIGUIENTE BOLA");
		this.vbox1.Add (this.buttonBola);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.buttonBola]));
		w2.Position = 2;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 593;
		this.DefaultHeight = 539;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
	}
}
