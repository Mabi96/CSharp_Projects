using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja_Kierowcy
{
    public partial class Form_Dodaj_kurs : Form
    {
        
        public Form_Dodaj_kurs()
        {
            InitializeComponent();
           
        }

        
        
        private void Form_Dodaj_kurs_Load(object sender, EventArgs e)
        {
            
            foreach (Kierowca k in Kierowca.lista_kierowców)
            {
                comboBox1.Items.Add(k.imię + " " + k.nazwisko);
            }
            
        }

         

        private void button_Dodaj_Kurs_Click(object sender, EventArgs e)
        {
            
            Kursy kursy = new Kursy();

                if (dateTimePicker1.Value <= dateTimePicker2.Value)
                {
                    kursy.kierowca = comboBox1.SelectedIndex;
                    kursy.data_wyjazdu = dateTimePicker1.Value;
                    kursy.data_powrotu = dateTimePicker2.Value;
                    kursy.liczba_przejechanych_kilometrów = (int)numericUpDown2.Value;
                    kursy.godziny = (int)numericUpDown3.Value;

                    Kursy.lista_kursów.Add(kursy);
                }

                else
                    MessageBox.Show("Zły przedział czasowy!");
            }

        private void button_Powrót_Click(object sender, EventArgs e)
        {
            Form_Główna f = new Form_Główna();
            f.Show();
            this.Hide();
        }
    }
   
    
}
