﻿namespace AplikacjaSprzedażyProduktówiUsług
{
	partial class Form1
	{
		/// <summary>
		/// Wymagana zmienna projektanta.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Wyczyść wszystkie używane zasoby.
		/// </summary>
		/// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Kod generowany przez Projektanta formularzy systemu Windows

		/// <summary>
		/// Metoda wymagana do obsługi projektanta — nie należy modyfikować
		/// jej zawartości w edytorze kodu.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.stawkiPTUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ofertaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stawkiPTUToolStripMenuItem,
            this.ofertaToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(854, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// stawkiPTUToolStripMenuItem
			// 
			this.stawkiPTUToolStripMenuItem.Name = "stawkiPTUToolStripMenuItem";
			this.stawkiPTUToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
			this.stawkiPTUToolStripMenuItem.Text = "Stawki PTU";
			this.stawkiPTUToolStripMenuItem.Click += new System.EventHandler(this.stawkiPTUToolStripMenuItem_Click);
			// 
			// ofertaToolStripMenuItem
			// 
			this.ofertaToolStripMenuItem.Name = "ofertaToolStripMenuItem";
			this.ofertaToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.ofertaToolStripMenuItem.Text = "Oferta";
			this.ofertaToolStripMenuItem.Click += new System.EventHandler(this.ofertaToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(854, 450);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem stawkiPTUToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ofertaToolStripMenuItem;
	}
}

