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
    public partial class Form_Raporty : Form
    {
        public Form_Raporty()
        {
            InitializeComponent();
        }
        private void Form_Raporty_Load(object sender, EventArgs e)
        {
            foreach (Pracownik p in Pracownik.Lista_pracowników)
            {
                comboBox1.Items.Add(p);
                comboBox2.Items.Add(p);
            }
        }

        // I Raport - Sprawdzenie nadmiaru i niedomiaru godzin w stosunku do kalendarza i zaplanowanych godzin w grafiku
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();

            foreach (Dni_Robocze dr in Dni_Robocze.Lista_dni_roboczych)
            {
                int godziny = 0;
                foreach (Przyjścia_do_Pracy pdp in Przyjścia_do_Pracy.Lista_przyjść_do_pracy)
                {
                    if (Dni_Robocze.CzyTaSamaData(pdp.Dni_robocze.Data,dr.Data))
                    {
                        godziny += pdp.Liczba_godzin_zaplanowanych;
                    }
                }
                if (godziny < dr.Zaplanowane_roboczo_godziny)
                    dataGridView1.Rows.Add(dr.Data.ToShortDateString());
                else if (godziny > dr.Zaplanowane_roboczo_godziny)
                    dataGridView2.Rows.Add(dr.Data.ToShortDateString());
            }
        }
        // II Raport - Sprawdzenie ile godzin (nadmiaru i niedomiaru) dany Pracownik
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();

            int nadgodziny_ile_razy = 0;
            int nadgodziny = 0;

            int za_mało_ile_razy = 0;
            int za_mało = 0;

            Pracownik p = (Pracownik)comboBox1.SelectedItem;

            foreach (Przyjścia_do_Pracy pdp in Przyjścia_do_Pracy.Lista_przyjść_do_pracy)
            {
                if (p.CzyTenSamPracownik(p, pdp.Pracownik))
                {
                    if (pdp.Liczba_godzin_zaplanowanych < pdp.Liczba_godzin_przepracowanych)
                    {
                        nadgodziny += (pdp.Liczba_godzin_zaplanowanych - pdp.Liczba_godzin_przepracowanych);
                        nadgodziny_ile_razy++;
                    }
                    else if (pdp.Liczba_godzin_zaplanowanych > pdp.Liczba_godzin_przepracowanych)
                    {
                        za_mało += (pdp.Liczba_godzin_zaplanowanych - pdp.Liczba_godzin_przepracowanych);
                        za_mało_ile_razy++;
                    }
                }
            }
            dataGridView3.Rows.Add(za_mało_ile_razy + " razy", za_mało + " godzin", nadgodziny_ile_razy + " razy", nadgodziny + " godzin");
        }
        // III Raport - Wynagrodzenie danego Pracownika
        private void button3_Click(object sender, EventArgs e)
        {
            int sumaGodzin = 0;
            decimal wynagrodzenie;

            Pracownik p = (Pracownik)comboBox2.SelectedItem;

            foreach (Przyjścia_do_Pracy pdp in Przyjścia_do_Pracy.Lista_przyjść_do_pracy)
            {
                if (p.CzyTenSamPracownik(p, pdp.Pracownik))
                    sumaGodzin += pdp.Liczba_godzin_przepracowanych;
            }
            wynagrodzenie = sumaGodzin * p.Stawka;
            dataGridView4.Rows.Add(sumaGodzin + " godzin", wynagrodzenie + " zł");
        }

        private void button_zamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal godziny_przepracowane = 0;
            decimal godziny_zaplanowane = 0;
            decimal wynik;

            //Wyszukuje dni robocze
            foreach (Dni_Robocze dr in Dni_Robocze.Lista_dni_roboczych)
            {
                // Warunek tygodnia

                if(dr.Data > DateTime.Today - new TimeSpan((int)DateTime.Today.DayOfWeek,0,0,0)
                    && dr.Data < DateTime.Today + new TimeSpan((int)DateTime.Today.DayOfWeek + 6, 0, 0, 0))
                { 
                    //Przeszukuje na podstawie warunku te dni z godzinami
                    foreach (Przyjścia_do_Pracy pdp in Przyjścia_do_Pracy.Lista_przyjść_do_pracy)
                    {
                        //Sprawdzam czy dni się pokrywają
                        if (Dni_Robocze.CzyTaSamaData(pdp.Dni_robocze.Data, dr.Data))
                        {
                            godziny_przepracowane += pdp.Liczba_godzin_przepracowanych;
                            godziny_zaplanowane += pdp.Liczba_godzin_zaplanowanych;
                        }
                    }
                }
                    
            }
            
            if (godziny_zaplanowane != 0)
            {
                wynik = (godziny_przepracowane / godziny_zaplanowane) * 100;
                label3.Text = "Wynik wynosi godzin przepracowanych wynosi: " + Math.Round(wynik, 2) + "%";
            }



            ////Szukam maksymalnej daty
            //foreach (Dni_Robocze dr in Dni_Robocze.Lista_dni_roboczych)
            //{
            //    int godziny = 0;

            //    foreach (Przyjścia_do_Pracy pdp in Przyjścia_do_Pracy.Lista_przyjść_do_pracy)
            //    {
            //        if (Dni_Robocze.CzyTaSamaData(pdp.Dni_robocze.Data, dr.Data))
            //        {
            //            godziny += pdp.Liczba_godzin_przepracowanych;
            //        }
            //    }
            //    if (godziny > MAX)
            //    {
            //        MAX = godziny;
            //        Data_MAX = dr.Data;
            //    }
            //}

            ////Stworzyłem dodatkową litę pomocniczą aby pózniej ją posortować
            //List<Przyjścia_do_Pracy> Lista_pracowników2 = new List<Przyjścia_do_Pracy>();

            ////Sprawdzam pracowników na podstawie Daty maksymalnej
            //foreach (Przyjścia_do_Pracy pdp in Przyjścia_do_Pracy.Lista_przyjść_do_pracy)
            //{
            //    if (Dni_Robocze.CzyTaSamaData(pdp.Dni_robocze.Data, Data_MAX))
            //    {
            //        foreach (Pracownik pr in Pracownik.Lista_pracowników)
            //        {
            //            if (pr.CzyTenSamPracownik(pr, pdp.Pracownik))
            //            {
            //                Lista_pracowników2.Add(pdp);
            //            }
            //        }
            //    }
            //}

            ////Sortowanie w dół 5,4,3,2,1 itd.
            //List <Przyjścia_do_Pracy> Listaposortowana =  Lista_pracowników2.OrderByDescending(x => x.Liczba_godzin_przepracowanych).ToList();
            ////Ascending 1,2,3,4,5 itd.
            ////Lista_pracowników2.OrderBy(x => x.Liczba_godzin_przepracowanych).ToList();

            //// Wpisanie posortowanych
            //foreach (Przyjścia_do_Pracy pdp in Listaposortowana)
            //{
            //    listBox1.Items.Add(pdp.Pracownik.Imię + pdp.Pracownik.Nazwisko);
            //}

        }
    }
}
