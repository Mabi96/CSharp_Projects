namespace Aplikacja_Kierowcy
{
    partial class Form_Główna
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
            this.button_Zamknij = new System.Windows.Forms.Button();
            this.button_Wynagrodzenia = new System.Windows.Forms.Button();
            this.button_Kursy = new System.Windows.Forms.Button();
            this.button_Dodaj_pracownika = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Zamknij
            // 
            this.button_Zamknij.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Zamknij.Location = new System.Drawing.Point(12, 271);
            this.button_Zamknij.Name = "button_Zamknij";
            this.button_Zamknij.Size = new System.Drawing.Size(255, 81);
            this.button_Zamknij.TabIndex = 5;
            this.button_Zamknij.Text = "Zamknij";
            this.button_Zamknij.UseVisualStyleBackColor = true;
            this.button_Zamknij.Click += new System.EventHandler(this.button_Zamknij_Click);
            // 
            // button_Wynagrodzenia
            // 
            this.button_Wynagrodzenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Wynagrodzenia.Location = new System.Drawing.Point(12, 184);
            this.button_Wynagrodzenia.Name = "button_Wynagrodzenia";
            this.button_Wynagrodzenia.Size = new System.Drawing.Size(255, 81);
            this.button_Wynagrodzenia.TabIndex = 4;
            this.button_Wynagrodzenia.Text = "Wynagrodzenia";
            this.button_Wynagrodzenia.UseVisualStyleBackColor = true;
            this.button_Wynagrodzenia.Click += new System.EventHandler(this.button_Wynagrodzenia_Click);
            // 
            // button_Kursy
            // 
            this.button_Kursy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Kursy.Location = new System.Drawing.Point(12, 97);
            this.button_Kursy.Name = "button_Kursy";
            this.button_Kursy.Size = new System.Drawing.Size(255, 81);
            this.button_Kursy.TabIndex = 3;
            this.button_Kursy.Text = "Kursy";
            this.button_Kursy.UseVisualStyleBackColor = true;
            this.button_Kursy.Click += new System.EventHandler(this.button_Kursy_Click);
            // 
            // button_Dodaj_pracownika
            // 
            this.button_Dodaj_pracownika.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Dodaj_pracownika.Location = new System.Drawing.Point(12, 10);
            this.button_Dodaj_pracownika.Name = "button_Dodaj_pracownika";
            this.button_Dodaj_pracownika.Size = new System.Drawing.Size(255, 81);
            this.button_Dodaj_pracownika.TabIndex = 6;
            this.button_Dodaj_pracownika.Text = "Dodaj Pracownika";
            this.button_Dodaj_pracownika.UseVisualStyleBackColor = true;
            this.button_Dodaj_pracownika.Click += new System.EventHandler(this.button_Dodaj_pracownika_Click);
            // 
            // Form_Główna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 371);
            this.Controls.Add(this.button_Dodaj_pracownika);
            this.Controls.Add(this.button_Zamknij);
            this.Controls.Add(this.button_Wynagrodzenia);
            this.Controls.Add(this.button_Kursy);
            this.Name = "Form_Główna";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Główna_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Zamknij;
        private System.Windows.Forms.Button button_Wynagrodzenia;
        private System.Windows.Forms.Button button_Kursy;
        private System.Windows.Forms.Button button_Dodaj_pracownika;
    }
}

