using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaSprzedażyProduktówiUsług
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			StawkaPTU.ListaStawekPTU.Add(new StawkaPTU(23m));
			StawkaPTU.ListaStawekPTU.Add(new StawkaPTU(8m));
			StawkaPTU.ListaStawekPTU.Add(new StawkaPTU(5m));
			StawkaPTU.ListaStawekPTU.Add(new StawkaPTU(0m));
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void stawkiPTUToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new FormStawkiPTU().ShowDialog();
		}

		private void ofertaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormListaOfert formListaOfert = new FormListaOfert();
			formListaOfert.ShowDialog();

		}
	}
}
