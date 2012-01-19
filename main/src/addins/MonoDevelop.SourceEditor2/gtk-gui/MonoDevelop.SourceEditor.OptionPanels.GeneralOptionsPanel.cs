
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.SourceEditor.OptionPanels
{
	internal partial class GeneralOptionsPanel
	{
		private global::Gtk.VBox vbox1;
		private global::Gtk.Label GtkLabel13;
		private global::Gtk.Alignment alignment2;
		private global::Gtk.VBox vbox4;
		private global::Gtk.CheckButton codeCompletioncheckbutton;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Fixed fixed1;
		private global::Gtk.CheckButton autoCodeCompletionCheckbutton;
		private global::Gtk.HBox hbox3;
		private global::Gtk.Fixed fixed2;
		private global::Gtk.CheckButton spaceOrPunctiuationCheckbutton;
		private global::Gtk.HBox hbox4;
		private global::Gtk.Fixed fixed3;
		private global::Gtk.CheckButton enableParameterInsightCheckbutton;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Label label1;
		private global::Gtk.ComboBox comboboxLineEndings;
		private global::Gtk.Label GtkLabel14;
		private global::Gtk.Alignment alignment3;
		private global::Gtk.VBox vbox5;
		private global::Gtk.CheckButton foldingCheckbutton;
		private global::Gtk.CheckButton foldregionsCheckbutton;
		private global::Gtk.CheckButton foldCommentsCheckbutton;
		private global::Gtk.Label GtkLabel15;
		private global::Gtk.Alignment alignment4;
		private global::Gtk.VBox vbox6;
		private global::Gtk.CheckButton antiAliasingCheckbutton;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.SourceEditor.OptionPanels.GeneralOptionsPanel
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.SourceEditor.OptionPanels.GeneralOptionsPanel";
			// Container child MonoDevelop.SourceEditor.OptionPanels.GeneralOptionsPanel.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.GtkLabel13 = new global::Gtk.Label ();
			this.GtkLabel13.Name = "GtkLabel13";
			this.GtkLabel13.Xalign = 0F;
			this.GtkLabel13.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Coding</b>");
			this.GtkLabel13.UseMarkup = true;
			this.vbox1.Add (this.GtkLabel13);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.GtkLabel13]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.alignment2 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment2.Name = "alignment2";
			this.alignment2.LeftPadding = ((uint)(12));
			// Container child alignment2.Gtk.Container+ContainerChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.codeCompletioncheckbutton = new global::Gtk.CheckButton ();
			this.codeCompletioncheckbutton.CanFocus = true;
			this.codeCompletioncheckbutton.Name = "codeCompletioncheckbutton";
			this.codeCompletioncheckbutton.Label = global::Mono.Unix.Catalog.GetString ("Enable _code completion");
			this.codeCompletioncheckbutton.DrawIndicator = true;
			this.codeCompletioncheckbutton.UseUnderline = true;
			this.vbox4.Add (this.codeCompletioncheckbutton);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.codeCompletioncheckbutton]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.fixed1 = new global::Gtk.Fixed ();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			this.hbox2.Add (this.fixed1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.fixed1]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Padding = ((uint)(6));
			// Container child hbox2.Gtk.Box+BoxChild
			this.autoCodeCompletionCheckbutton = new global::Gtk.CheckButton ();
			this.autoCodeCompletionCheckbutton.CanFocus = true;
			this.autoCodeCompletionCheckbutton.Name = "autoCodeCompletionCheckbutton";
			this.autoCodeCompletionCheckbutton.Label = global::Mono.Unix.Catalog.GetString ("_Aggressively trigger code completion list");
			this.autoCodeCompletionCheckbutton.DrawIndicator = true;
			this.autoCodeCompletionCheckbutton.UseUnderline = true;
			this.hbox2.Add (this.autoCodeCompletionCheckbutton);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.autoCodeCompletionCheckbutton]));
			w4.Position = 1;
			this.vbox4.Add (this.hbox2);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox2]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.fixed2 = new global::Gtk.Fixed ();
			this.fixed2.Name = "fixed2";
			this.fixed2.HasWindow = false;
			this.hbox3.Add (this.fixed2);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.fixed2]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Padding = ((uint)(6));
			// Container child hbox3.Gtk.Box+BoxChild
			this.spaceOrPunctiuationCheckbutton = new global::Gtk.CheckButton ();
			this.spaceOrPunctiuationCheckbutton.CanFocus = true;
			this.spaceOrPunctiuationCheckbutton.Name = "spaceOrPunctiuationCheckbutton";
			this.spaceOrPunctiuationCheckbutton.Label = global::Mono.Unix.Catalog.GetString ("_Commit completion list selection with space or punctuation.");
			this.spaceOrPunctiuationCheckbutton.DrawIndicator = true;
			this.spaceOrPunctiuationCheckbutton.UseUnderline = true;
			this.hbox3.Add (this.spaceOrPunctiuationCheckbutton);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.spaceOrPunctiuationCheckbutton]));
			w7.Position = 1;
			this.vbox4.Add (this.hbox3);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox3]));
			w8.Position = 2;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.fixed3 = new global::Gtk.Fixed ();
			this.fixed3.Name = "fixed3";
			this.fixed3.HasWindow = false;
			this.hbox4.Add (this.fixed3);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.fixed3]));
			w9.Position = 0;
			w9.Expand = false;
			w9.Padding = ((uint)(6));
			// Container child hbox4.Gtk.Box+BoxChild
			this.enableParameterInsightCheckbutton = new global::Gtk.CheckButton ();
			this.enableParameterInsightCheckbutton.CanFocus = true;
			this.enableParameterInsightCheckbutton.Name = "enableParameterInsightCheckbutton";
			this.enableParameterInsightCheckbutton.Label = global::Mono.Unix.Catalog.GetString ("Enable _parameter insight");
			this.enableParameterInsightCheckbutton.DrawIndicator = true;
			this.enableParameterInsightCheckbutton.UseUnderline = true;
			this.hbox4.Add (this.enableParameterInsightCheckbutton);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.enableParameterInsightCheckbutton]));
			w10.Position = 1;
			this.vbox4.Add (this.hbox4);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox4]));
			w11.Position = 3;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("_Line ending conversion:");
			this.label1.UseUnderline = true;
			this.hbox1.Add (this.label1);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label1]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.comboboxLineEndings = global::Gtk.ComboBox.NewText ();
			this.comboboxLineEndings.Name = "comboboxLineEndings";
			this.hbox1.Add (this.comboboxLineEndings);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.comboboxLineEndings]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			this.vbox4.Add (this.hbox1);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox1]));
			w14.Position = 4;
			w14.Expand = false;
			w14.Fill = false;
			this.alignment2.Add (this.vbox4);
			this.vbox1.Add (this.alignment2);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.alignment2]));
			w16.Position = 1;
			w16.Expand = false;
			w16.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.GtkLabel14 = new global::Gtk.Label ();
			this.GtkLabel14.Name = "GtkLabel14";
			this.GtkLabel14.Xalign = 0F;
			this.GtkLabel14.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Code Folding</b>");
			this.GtkLabel14.UseMarkup = true;
			this.vbox1.Add (this.GtkLabel14);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.GtkLabel14]));
			w17.Position = 2;
			w17.Expand = false;
			w17.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.alignment3 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment3.Name = "alignment3";
			this.alignment3.LeftPadding = ((uint)(12));
			// Container child alignment3.Gtk.Container+ContainerChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.foldingCheckbutton = new global::Gtk.CheckButton ();
			this.foldingCheckbutton.CanFocus = true;
			this.foldingCheckbutton.Name = "foldingCheckbutton";
			this.foldingCheckbutton.Label = global::Mono.Unix.Catalog.GetString ("Enable code _folding");
			this.foldingCheckbutton.DrawIndicator = true;
			this.foldingCheckbutton.UseUnderline = true;
			this.vbox5.Add (this.foldingCheckbutton);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.foldingCheckbutton]));
			w18.Position = 0;
			w18.Expand = false;
			w18.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.foldregionsCheckbutton = new global::Gtk.CheckButton ();
			this.foldregionsCheckbutton.CanFocus = true;
			this.foldregionsCheckbutton.Name = "foldregionsCheckbutton";
			this.foldregionsCheckbutton.Label = global::Mono.Unix.Catalog.GetString ("Fold #_regions by default");
			this.foldregionsCheckbutton.DrawIndicator = true;
			this.foldregionsCheckbutton.UseUnderline = true;
			this.vbox5.Add (this.foldregionsCheckbutton);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.foldregionsCheckbutton]));
			w19.Position = 1;
			w19.Expand = false;
			w19.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.foldCommentsCheckbutton = new global::Gtk.CheckButton ();
			this.foldCommentsCheckbutton.CanFocus = true;
			this.foldCommentsCheckbutton.Name = "foldCommentsCheckbutton";
			this.foldCommentsCheckbutton.Label = global::Mono.Unix.Catalog.GetString ("Fold _comments by default");
			this.foldCommentsCheckbutton.DrawIndicator = true;
			this.foldCommentsCheckbutton.UseUnderline = true;
			this.vbox5.Add (this.foldCommentsCheckbutton);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.foldCommentsCheckbutton]));
			w20.Position = 2;
			w20.Expand = false;
			w20.Fill = false;
			this.alignment3.Add (this.vbox5);
			this.vbox1.Add (this.alignment3);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.alignment3]));
			w22.Position = 3;
			w22.Expand = false;
			w22.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.GtkLabel15 = new global::Gtk.Label ();
			this.GtkLabel15.Name = "GtkLabel15";
			this.GtkLabel15.Xalign = 0F;
			this.GtkLabel15.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Appearance</b>");
			this.GtkLabel15.UseMarkup = true;
			this.vbox1.Add (this.GtkLabel15);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.GtkLabel15]));
			w23.Position = 4;
			w23.Expand = false;
			w23.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.alignment4 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment4.Name = "alignment4";
			this.alignment4.LeftPadding = ((uint)(12));
			// Container child alignment4.Gtk.Container+ContainerChild
			this.vbox6 = new global::Gtk.VBox ();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			// Container child vbox6.Gtk.Box+BoxChild
			this.antiAliasingCheckbutton = new global::Gtk.CheckButton ();
			this.antiAliasingCheckbutton.CanFocus = true;
			this.antiAliasingCheckbutton.Name = "antiAliasingCheckbutton";
			this.antiAliasingCheckbutton.Label = global::Mono.Unix.Catalog.GetString ("_Use anti aliasing");
			this.antiAliasingCheckbutton.DrawIndicator = true;
			this.antiAliasingCheckbutton.UseUnderline = true;
			this.vbox6.Add (this.antiAliasingCheckbutton);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.antiAliasingCheckbutton]));
			w24.Position = 0;
			w24.Expand = false;
			w24.Fill = false;
			this.alignment4.Add (this.vbox6);
			this.vbox1.Add (this.alignment4);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.alignment4]));
			w26.Position = 5;
			w26.Expand = false;
			w26.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.label1.MnemonicWidget = this.comboboxLineEndings;
			this.Show ();
		}
	}
}
