namespace AplikacjaSprzedażyProduktówiUsług
{
	partial class FormListaOfert
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.usuńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modyfikujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 24);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(800, 426);
			this.dataGridView1.TabIndex = 0;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zamknijToolStripMenuItem,
            this.dodajToolStripMenuItem,
            this.usuńToolStripMenuItem,
            this.modyfikujToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// dodajToolStripMenuItem
			// 
			this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
			this.dodajToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.dodajToolStripMenuItem.Text = "Dodaj";
			this.dodajToolStripMenuItem.Click += new System.EventHandler(this.dodajToolStripMenuItem_Click);
			// 
			// usuńToolStripMenuItem
			// 
			this.usuńToolStripMenuItem.Name = "usuńToolStripMenuItem";
			this.usuńToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
			this.usuńToolStripMenuItem.Text = "Usuń";
			this.usuńToolStripMenuItem.Click += new System.EventHandler(this.usuńToolStripMenuItem_Click);
			// 
			// modyfikujToolStripMenuItem
			// 
			this.modyfikujToolStripMenuItem.Name = "modyfikujToolStripMenuItem";
			this.modyfikujToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
			this.modyfikujToolStripMenuItem.Text = "Modyfikuj";
			this.modyfikujToolStripMenuItem.Click += new System.EventHandler(this.modyfikujToolStripMenuItem_Click);
			// 
			// zamknijToolStripMenuItem
			// 
			this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
			this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
			this.zamknijToolStripMenuItem.Text = "Zamknij";
			// 
			// FormListaOfert
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormListaOfert";
			this.Text = "FormListaOfert";
			this.Load += new System.EventHandler(this.FormListaOfert_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem usuńToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem modyfikujToolStripMenuItem;
	}
}