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
	public partial class FormListaOfert : Form
	{
		public FormListaOfert()
		{
			InitializeComponent();
		}

		void odśwież()
		{
			dataGridView1.Rows.Clear();
			dataGridView1.Columns.Clear();
			string[] nazwy_kol = Oferta.NazwyKolumn;
			foreach (string s in nazwy_kol)
				dataGridView1.Columns.Add("kol", s);
			foreach (Oferta of in Oferta.ListaProduktówiUsług)
				dataGridView1.Rows[dataGridView1.Rows.Add(of)].Tag = of;
		}

		private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Oferta oferta = new Oferta();
			FormOferta formOferta = new FormOferta(oferta);
			if (formOferta.ShowDialog() != DialogResult.OK)
				return;
			Oferta.ListaProduktówiUsług.Add(oferta);
			odśwież();
		}

		private void FormListaOfert_Load(object sender, EventArgs e)
		{
			odśwież();
		}

		private void usuńToolStripMenuItem_Click(object sender, EventArgs e)
		{
			foreach(DataGridViewRow row in dataGridView1.SelectedRows)
				Oferta.ListaProduktówiUsług.Remove((Oferta)row.Tag);
			odśwież();

		}

		private void modyfikujToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count != 1)
				return;
			if (dataGridView1.SelectedRows[0].GetType() != typeof(Oferta))
				return;

			new FormOferta((Oferta)dataGridView1.SelectedRows[0].Tag).ShowDialog();
			odśwież();

		}
	}
}
