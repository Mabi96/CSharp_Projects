using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaSprzedażyProduktówiUsług
{
	class StawkaPTU
	{
		decimal stawka;
		static List<StawkaPTU> listaStawekPTU = new List<StawkaPTU>();

		public StawkaPTU(decimal stawka)
		{
			this.stawka = stawka;
		}

		public static List<StawkaPTU> ListaStawekPTU { get => listaStawekPTU; set => listaStawekPTU = value; }
		public decimal Stawka { get => stawka; set => stawka = value; }

		static public decimal operator * (StawkaPTU stawkiPTU, decimal kwotaNetto)
		{
			return stawkiPTU.stawka*kwotaNetto/100.0m;
		}

		static public bool operator == (StawkaPTU stawka, decimal dec)
		{
			return Math.Abs(stawka.Stawka - dec)<0.00001m;
		}

		static public bool operator !=(StawkaPTU stawka, decimal dec)
		{
			return !(stawka == dec);
		}

		public override string ToString()
		{
			return stawka.ToString("0")+"%";
		}


	}
}
