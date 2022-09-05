namespace Sklep_Spożywczy
{
    partial class Form_Kalendarz
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button_modyfikuj = new System.Windows.Forms.Button();
            this.button_usuń = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_dodaj = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wczytajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_Zamknij = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.White;
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.monthCalendar1.Location = new System.Drawing.Point(18, 57);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.TitleForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // button_modyfikuj
            // 
            this.button_modyfikuj.Location = new System.Drawing.Point(397, 108);
            this.button_modyfikuj.Name = "button_modyfikuj";
            this.button_modyfikuj.Size = new System.Drawing.Size(151, 43);
            this.button_modyfikuj.TabIndex = 2;
            this.button_modyfikuj.Text = "Modyfikuj";
            this.button_modyfikuj.UseVisualStyleBackColor = true;
            this.button_modyfikuj.Click += new System.EventHandler(this.button_modyfikuj_Click);
            // 
            // button_usuń
            // 
            this.button_usuń.Location = new System.Drawing.Point(397, 157);
            this.button_usuń.Name = "button_usuń";
            this.button_usuń.Size = new System.Drawing.Size(151, 43);
            this.button_usuń.TabIndex = 3;
            this.button_usuń.Text = "Usuń";
            this.button_usuń.UseVisualStyleBackColor = true;
            this.button_usuń.Click += new System.EventHandler(this.button_usuń_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Zaplanowane godziny";
            // 
            // button_dodaj
            // 
            this.button_dodaj.Location = new System.Drawing.Point(397, 59);
            this.button_dodaj.Name = "button_dodaj";
            this.button_dodaj.Size = new System.Drawing.Size(151, 43);
            this.button_dodaj.TabIndex = 6;
            this.button_dodaj.Text = "Dodaj";
            this.button_dodaj.UseVisualStyleBackColor = true;
            this.button_dodaj.Click += new System.EventHandler(this.button_dodaj_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(397, 223);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(151, 22);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 273);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 22);
            this.textBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ilość godzin";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszToolStripMenuItem,
            this.wczytajToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(595, 30);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(66, 26);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // wczytajToolStripMenuItem
            // 
            this.wczytajToolStripMenuItem.Name = "wczytajToolStripMenuItem";
            this.wczytajToolStripMenuItem.Size = new System.Drawing.Size(74, 26);
            this.wczytajToolStripMenuItem.Text = "Wczytaj";
            this.wczytajToolStripMenuItem.Click += new System.EventHandler(this.wczytajToolStripMenuItem_Click);
            // 
            // button_Zamknij
            // 
            this.button_Zamknij.Location = new System.Drawing.Point(397, 264);
            this.button_Zamknij.Name = "button_Zamknij";
            this.button_Zamknij.Size = new System.Drawing.Size(151, 43);
            this.button_Zamknij.TabIndex = 12;
            this.button_Zamknij.Text = "Zamknij";
            this.button_Zamknij.UseVisualStyleBackColor = true;
            this.button_Zamknij.Click += new System.EventHandler(this.button_Zamknij_Click);
            // 
            // Form_Kalendarz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 319);
            this.Controls.Add(this.button_Zamknij);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button_dodaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_usuń);
            this.Controls.Add(this.button_modyfikuj);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Kalendarz";
            this.Text = "Form_Kalendarz";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button_modyfikuj;
        private System.Windows.Forms.Button button_usuń;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_dodaj;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wczytajToolStripMenuItem;
        private System.Windows.Forms.Button button_Zamknij;
    }
}