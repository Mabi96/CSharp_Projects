using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep_Spożywczy
{
    [Serializable]
    public class Dni_Robocze
    {
        private DateTime data;
        private int zaplanowane_roboczo_godziny;

        static List<Dni_Robocze> lista_dni_roboczych = new List<Dni_Robocze>();
        
        public DateTime Data
        {
            get => this.data;
            set => this.data = value;
        }
        public int Zaplanowane_roboczo_godziny
        {
            get => this.zaplanowane_roboczo_godziny;
            set => this.zaplanowane_roboczo_godziny = value;
        }
        public static List<Dni_Robocze> Lista_dni_roboczych
        {
            get => lista_dni_roboczych;
            set => lista_dni_roboczych = value;
        }
        static public bool CzyTaSamaData(DateTime PierwszaData, DateTime DrugaData)
        {
            return PierwszaData.Year == DrugaData.Year && PierwszaData.Month == DrugaData.Month && PierwszaData.Day == DrugaData.Day;
        }
    }
}
