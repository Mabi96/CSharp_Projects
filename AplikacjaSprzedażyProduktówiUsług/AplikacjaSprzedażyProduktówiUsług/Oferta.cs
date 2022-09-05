using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaSprzedażyProduktówiUsług
{
	class Oferta
	{
		string nazwa;
		decimal cenaNetto;
		StawkaPTU stawkaPTU;
		bool podlegaPTU;

		public string Nazwa { get => nazwa; set => nazwa = value; }
		public decimal CenaNetto { get => cenaNetto; set => cenaNetto = value; }
		public StawkaPTU StawkaPTU { get => stawkaPTU; set => stawkaPTU = value; }
		internal static List<Oferta> ListaProduktówiUsług { get => listaProduktówiUsług; set => listaProduktówiUsług = value; }
		public bool PodlegaPTU { get => podlegaPTU; set => podlegaPTU = value; }

		static List<Oferta> listaProduktówiUsług = new List<Oferta>();

		public object[] ObjTbl
		{
			get
			{
				string cena_brutto = "", stawka = "zwoln.";
				if (podlegaPTU)
				{
					cena_brutto = (stawkaPTU * cenaNetto + cenaNetto).ToString("0.00");
					stawka = stawkaPTU.ToString();
				}
				return new object[] { nazwa, stawka, cenaNetto.ToString("0.00"), cena_brutto };
			}
		}

		static public string[] NazwyKolumn { get => new string [] { "Nazwa", "Stawka PTU", "Cena jedn. netto", "Cena jedn. brutto", }; }
	}
}
