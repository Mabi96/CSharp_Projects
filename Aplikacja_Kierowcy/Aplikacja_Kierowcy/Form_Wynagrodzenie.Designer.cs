namespace Aplikacja_Kierowcy
{
    partial class Form_Wynagrodzenie
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_Rozlicz = new System.Windows.Forms.Button();
            this.button_Powrót = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kierowca";
            // 
            // button_Rozlicz
            // 
            this.button_Rozlicz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Rozlicz.Location = new System.Drawing.Point(34, 79);
            this.button_Rozlicz.Name = "button_Rozlicz";
            this.button_Rozlicz.Size = new System.Drawing.Size(354, 62);
            this.button_Rozlicz.TabIndex = 2;
            this.button_Rozlicz.Text = "Rozlicz";
            this.button_Rozlicz.UseVisualStyleBackColor = true;
            this.button_Rozlicz.Click += new System.EventHandler(this.button_Rozlicz_Click);
            // 
            // button_Powrót
            // 
            this.button_Powrót.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Powrót.Location = new System.Drawing.Point(34, 159);
            this.button_Powrót.Name = "button_Powrót";
            this.button_Powrót.Size = new System.Drawing.Size(354, 62);
            this.button_Powrót.TabIndex = 3;
            this.button_Powrót.Text = "Powrót";
            this.button_Powrót.UseVisualStyleBackColor = true;
            this.button_Powrót.Click += new System.EventHandler(this.button_Powrót_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(157, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // Form_Wynagrodzenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 233);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_Powrót);
            this.Controls.Add(this.button_Rozlicz);
            this.Controls.Add(this.label1);
            this.Name = "Form_Wynagrodzenie";
            this.Text = "Form_Wynagrodzenie";
            this.Load += new System.EventHandler(this.Form_Wynagrodzenie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Rozlicz;
        private System.Windows.Forms.Button button_Powrót;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}