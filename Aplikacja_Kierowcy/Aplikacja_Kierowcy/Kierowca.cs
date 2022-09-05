using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja_Kierowcy
{
    public class Kierowca
    {
        public String imię, nazwisko;
        public int rok_uzyskania_uprawnień_do_kierowania, rok_rozpoczęcia_pracy_na_stanowisku, stawka_za_godzinę = 14, stawka_za_km = 5;

        public static List<Kierowca> lista_kierowców = new List<Kierowca>();

    }
}
