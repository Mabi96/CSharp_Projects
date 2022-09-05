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
    public partial class Form_Główna : Form
    {

        

        public Form_Główna()
        {
            InitializeComponent();
        }
        private void Form_Główna_Load(object sender, EventArgs e)
        {
            Kierowca kierowca = new Kierowca();


            if (Kierowca.lista_kierowców.Count <= 0)
            {

                Kierowca kierowca_1 = new Kierowca { imię = "Grzegorz", nazwisko = "Starzyńsi", rok_uzyskania_uprawnień_do_kierowania = 1995, rok_rozpoczęcia_pracy_na_stanowisku = 2015 };
                Kierowca kierowca_2 = new Kierowca { imię = "Jan", nazwisko = "Nowak", rok_uzyskania_uprawnień_do_kierowania = 2002, rok_rozpoczęcia_pracy_na_stanowisku = 2017 };
                Kierowca kierowca_3 = new Kierowca { imię = "Paweł", nazwisko = "Beliński", rok_uzyskania_uprawnień_do_kierowania = 2001, rok_rozpoczęcia_pracy_na_stanowisku = 2016 };
                Kierowca kierowca_4 = new Kierowca { imię = "Aleksander", nazwisko = "Cieszyński", rok_uzyskania_uprawnień_do_kierowania = 1998, rok_rozpoczęcia_pracy_na_stanowisku = 2016, stawka_za_godzinę = +2, stawka_za_km = +2 };
                Kierowca kierowca_5 = new Kierowca { imię = "Michał", nazwisko = "Kowalski", rok_uzyskania_uprawnień_do_kierowania = 2005, rok_rozpoczęcia_pracy_na_stanowisku = 2019, stawka_za_godzinę = +1 };

                Kierowca.lista_kierowców.Add(kierowca_1);
                Kierowca.lista_kierowców.Add(kierowca_2);
                Kierowca.lista_kierowców.Add(kierowca_3);
                Kierowca.lista_kierowców.Add(kierowca_4);
                Kierowca.lista_kierowców.Add(kierowca_5);

            }
            
            
        }

        private void button_Dodaj_pracownika_Click(object sender, EventArgs e)
        {
            Form_Dodaj_Pracownika f = new Form_Dodaj_Pracownika();
            f.Show();
            this.Hide();
        }

        private void button_Kursy_Click(object sender, EventArgs e)
        {
            Form_Dodaj_kurs f = new Form_Dodaj_kurs();
            f.Show();
            this.Hide();
        }

        private void button_Wynagrodzenia_Click(object sender, EventArgs e)
        {
            
            Form_Wynagrodzenie f = new Form_Wynagrodzenie();
            f.Show();
            this.Hide();
            

        }

        private void button_Zamknij_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
