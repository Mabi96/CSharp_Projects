namespace Sklep_Spożywczy
{
    partial class Form_Start
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
            this.button_Pracownicy = new System.Windows.Forms.Button();
            this.button_Kalendarz = new System.Windows.Forms.Button();
            this.button_Grafik = new System.Windows.Forms.Button();
            this.button_Zakończ = new System.Windows.Forms.Button();
            this.button_Raporty = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // button_Pracownicy
            // 
            this.button_Pracownicy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Pracownicy.Location = new System.Drawing.Point(12, 31);
            this.button_Pracownicy.Name = "button_Pracownicy";
            this.button_Pracownicy.Size = new System.Drawing.Size(316, 77);
            this.button_Pracownicy.TabIndex = 0;
            this.button_Pracownicy.Text = "Pracownicy";
            this.button_Pracownicy.UseVisualStyleBackColor = true;
            this.button_Pracownicy.Click += new System.EventHandler(this.button_Pracownicy_Click);
            // 
            // button_Kalendarz
            // 
            this.button_Kalendarz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Kalendarz.Location = new System.Drawing.Point(12, 114);
            this.button_Kalendarz.Name = "button_Kalendarz";
            this.button_Kalendarz.Size = new System.Drawing.Size(316, 77);
            this.button_Kalendarz.TabIndex = 1;
            this.button_Kalendarz.Text = "Kalendarz";
            this.button_Kalendarz.UseVisualStyleBackColor = true;
            this.button_Kalendarz.Click += new System.EventHandler(this.button_Kalendarz_Click);
            // 
            // button_Grafik
            // 
            this.button_Grafik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Grafik.Location = new System.Drawing.Point(12, 197);
            this.button_Grafik.Name = "button_Grafik";
            this.button_Grafik.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Grafik.Size = new System.Drawing.Size(316, 77);
            this.button_Grafik.TabIndex = 2;
            this.button_Grafik.Text = "Grafik";
            this.button_Grafik.UseVisualStyleBackColor = true;
            this.button_Grafik.Click += new System.EventHandler(this.button_Grafik_Click);
            // 
            // button_Zakończ
            // 
            this.button_Zakończ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Zakończ.Location = new System.Drawing.Point(12, 363);
            this.button_Zakończ.Name = "button_Zakończ";
            this.button_Zakończ.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Zakończ.Size = new System.Drawing.Size(316, 77);
            this.button_Zakończ.TabIndex = 4;
            this.button_Zakończ.Text = "Zakończ";
            this.button_Zakończ.UseVisualStyleBackColor = true;
            this.button_Zakończ.Click += new System.EventHandler(this.button_Zakończ_Click);
            // 
            // button_Raporty
            // 
            this.button_Raporty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Raporty.Location = new System.Drawing.Point(12, 280);
            this.button_Raporty.Name = "button_Raporty";
            this.button_Raporty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Raporty.Size = new System.Drawing.Size(316, 77);
            this.button_Raporty.TabIndex = 5;
            this.button_Raporty.Text = "Raporty";
            this.button_Raporty.UseVisualStyleBackColor = true;
            this.button_Raporty.Click += new System.EventHandler(this.button_Raporty_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(340, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Pliki aplikacji SKLEP SPOŻYWCZY (*.appr)|*.appr";
            this.saveFileDialog1.Title = "Wybierz gdzie zapisać:";
            // 
            // Form_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 455);
            this.Controls.Add(this.button_Raporty);
            this.Controls.Add(this.button_Zakończ);
            this.Controls.Add(this.button_Grafik);
            this.Controls.Add(this.button_Kalendarz);
            this.Controls.Add(this.button_Pracownicy);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Start";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Pracownicy;
        private System.Windows.Forms.Button button_Kalendarz;
        private System.Windows.Forms.Button button_Grafik;
        private System.Windows.Forms.Button button_Zakończ;
        private System.Windows.Forms.Button button_Raporty;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

