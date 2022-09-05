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
    public partial class Form_Wynagrodzenie : Form
    {
        Kursy kursy = new Kursy();
        
        public Form_Wynagrodzenie()
        {
            InitializeComponent();
            
        }


        private void Form_Wynagrodzenie_Load(object sender, EventArgs e)
        {

            foreach (Kierowca k in Kierowca.lista_kierowców)
            {
                comboBox1.Items.Add(k.imię + " " + k.nazwisko);
            }
            
        }


        private void button_Rozlicz_Click(object sender, EventArgs e)
        {
                int index = comboBox1.SelectedIndex ;
                decimal za_godziny;
                decimal za_kilometry;
                decimal suma = 0;
                decimal suma_za_wszystkie_kursy = 0;

           
                foreach (Kursy k in Kursy.lista_kursów)
                {
                        if (index == k.kierowca)
                        {
                            za_godziny = Kierowca.lista_kierowców[index].stawka_za_godzinę * k.godziny;
                            za_kilometry = Kierowca.lista_kierowców[index].stawka_za_km * k.liczba_przejechanych_kilometrów;
                            suma = za_godziny + za_kilometry;
                        }

                    suma_za_wszystkie_kursy = suma_za_wszystkie_kursy + suma;

                }


            MessageBox.Show("Wynagrodzenie Pracownika: " + Kierowca.lista_kierowców[index].imię + " " + Kierowca.lista_kierowców[index].nazwisko  + " wynosi: " + suma_za_wszystkie_kursy + " zł");


        }

        private void button_Powrót_Click(object sender, EventArgs e)
        {
            Form_Główna f = new Form_Główna();
            f.Show();
            this.Hide();
        }

        
    }
}
