using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep_Spożywczy
{
    [Serializable]
    class Przyjścia_do_Pracy
    {
        private Pracownik pracownik;
        private Dni_Robocze dni_robocze;
        private int liczba_godzin_zaplanowanych, liczba_godzin_przepracowanych;

        static List<Przyjścia_do_Pracy> lista_przyjść_do_pracy = new List<Przyjścia_do_Pracy>();
        
        public Pracownik Pracownik
        {
            get => pracownik; 
            set => pracownik = value; 
        }
        public Dni_Robocze Dni_robocze
        {
            get => dni_robocze;
            set => dni_robocze = value;
        }
        public int Liczba_godzin_zaplanowanych
        {
            get => liczba_godzin_zaplanowanych;
            set => this.liczba_godzin_zaplanowanych = value;
        }
        public int Liczba_godzin_przepracowanych
        {
            get => liczba_godzin_przepracowanych;
            set => this.liczba_godzin_przepracowanych = value;
        }
        public static List<Przyjścia_do_Pracy> Lista_przyjść_do_pracy
        {
            get => lista_przyjść_do_pracy;
            set => lista_przyjść_do_pracy = value;
        }
        public string[] Tabela()
        {
            string[] tbl = new string[4];
            tbl[0] = Pracownik.Imię + " " + Pracownik.Nazwisko;
            tbl[1] = Dni_robocze.Data.ToShortDateString();
            tbl[2] = Liczba_godzin_zaplanowanych.ToString();
            tbl[3] = Liczba_godzin_przepracowanych.ToString();
            return tbl; 
        }
    }
}
