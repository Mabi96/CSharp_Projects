using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja_Kierowcy
{
    public class Kursy
    {

        public int kierowca, liczba_przejechanych_kilometrów, godziny;
        public DateTime data_wyjazdu, data_powrotu;

        public static List<Kursy> lista_kursów = new List<Kursy>();
    }
}
