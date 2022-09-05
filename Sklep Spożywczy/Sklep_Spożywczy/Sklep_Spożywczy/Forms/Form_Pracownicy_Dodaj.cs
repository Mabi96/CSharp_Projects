using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sklep_Spożywczy
{
    public partial class Form_Pracownicy_Dodaj : Form
    {
        Pracownik Pracownik;
        internal Form_Pracownicy_Dodaj(Pracownik nowy_pracownik)
        {
            InitializeComponent();
            Pracownik = nowy_pracownik;
        }
        // Ładowanie danych do formatki przy modyfikowaniu
        private void Form_Pracownicy_Dodaj_Load(object sender, EventArgs e)
        {
            if(Pracownik.Imię != null)
            {
                textBox1.Text = Pracownik.Imię;
                textBox2.Text = Pracownik.Nazwisko;
                textBox3.Text = Pracownik.Pesel;
                dateTimePicker1.Value = Pracownik.Data_urodzenia;
                textBox4.Text = Pracownik.Adres_zamieszkania;
                textBox5.Text = Pracownik.Urząd_skarbowy;
                dateTimePicker2.Value = Pracownik.Data_rozpoczęcia_pracy;
                numericUpDown2.Value = Pracownik.Stawka;
                textBox6.Text = Pracownik.Telefon;
            }
        }
        // Dodawanie wpisanych danych
        private void button1_Click(object sender, EventArgs e)
        {
                Pracownik.Imię = textBox1.Text;
                Pracownik.Nazwisko = textBox2.Text;
                Pracownik.Pesel = textBox3.Text;
                Pracownik.Data_urodzenia = dateTimePicker1.Value;
                Pracownik.Adres_zamieszkania = textBox4.Text;
                Pracownik.Urząd_skarbowy = textBox5.Text;
                Pracownik.Data_rozpoczęcia_pracy = dateTimePicker2.Value;
                Pracownik.Stawka = (int)numericUpDown2.Value;
                Pracownik.Telefon = textBox6.Text;

            if (Pracownik.Imię.Length > 1 && Pracownik.Nazwisko.Length > 1 && Pracownik.Pesel.Length == 11
                && Pracownik.Urząd_skarbowy.Length > 1 && Pracownik.Data_rozpoczęcia_pracy != null
                && Pracownik.Stawka > 0 && Pracownik.Telefon.Length > 1 )
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
                label17.Visible = true;

                MessageBox.Show("Niepoprawne dane proszę uzupełnić zaznaczone pola");
                return;
            }
        }
    }
}
