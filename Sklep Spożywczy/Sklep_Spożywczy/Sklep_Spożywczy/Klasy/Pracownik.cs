using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep_Spożywczy
{
    [Serializable]
    class Pracownik
    {
        private String imię, nazwisko, pesel, telefon, adres_zamieszkania, urząd_skarbowy;
        private decimal stawka;
        private DateTime data_urodzenia, data_rozpoczęcia_pracy;

        static List<Pracownik> lista_pracowników = new List<Pracownik>();

        public string Imię
        {
            get => this.imię;
            set => this.imię = value;

        }
        public string Nazwisko
        {
            get => this.nazwisko;
            set => this.nazwisko = value;

        }
        public string Pesel
        {
            get => this.pesel;
            set => this.pesel = value;
        }
        public string Adres_zamieszkania
        {
            get => this.adres_zamieszkania;
            set => this.adres_zamieszkania = value;
        }
        public DateTime Data_urodzenia
        {
            get => this.data_urodzenia;
            set => this.data_urodzenia = value;
        }
        public DateTime Data_rozpoczęcia_pracy
        {
            get => this.data_rozpoczęcia_pracy;
            set => this.data_rozpoczęcia_pracy = value;
        }
        public string Urząd_skarbowy
        {
            get => this.urząd_skarbowy;
            set => this.urząd_skarbowy = value;
        }
        public string Telefon
        {
            get => this.telefon;
            set => this.telefon = value;
        }
        public decimal Stawka
        {
            get => this.stawka;
            set => this.stawka = value;
        }
        public static List<Pracownik> Lista_pracowników
        {
            get => lista_pracowników;
            set => lista_pracowników = value;
        }


        public string[] Tabela()
        {
            string[] tbl = new string[9];
            tbl[0] = Imię;
            tbl[1] = Nazwisko;
            tbl[2] = Pesel;
            tbl[3] = Data_urodzenia.ToShortDateString();
            tbl[4] = Adres_zamieszkania;
            tbl[5] = urząd_skarbowy;
            tbl[6] = data_rozpoczęcia_pracy.ToShortDateString();
            tbl[7] = stawka.ToString();
            tbl[8] = telefon;
            return tbl;
        }
        public override string ToString()
        {
            return (Imię + " " + Nazwisko).ToString();
        }
        public bool CzyTenSamPracownik(Pracownik pracownik1, Pracownik pracownik2)
        {
            return pracownik1.imię == pracownik2.imię && pracownik1.nazwisko == pracownik2.nazwisko && pracownik1.pesel == pracownik2.pesel;
        }
    }
}
