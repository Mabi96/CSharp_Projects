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
	public partial class FormStawkiPTU : Form
	{
		public FormStawkiPTU()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			foreach(StawkaPTU s in StawkaPTU.ListaStawekPTU)
				if(s==numericUpDown1.Value)
				{
					MessageBox.Show("Taka stawka już istnieje.","Błąd");
					return;
				}
			
			StawkaPTU stawka = new StawkaPTU(numericUpDown1.Value);
			StawkaPTU.ListaStawekPTU.Add(stawka);
			odśwież_listę();
		}

		void odśwież_listę()
		{
			listBox1.Items.Clear();
			foreach (StawkaPTU s in StawkaPTU.ListaStawekPTU)
				listBox1.Items.Add(s);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (listBox1.SelectedIndex < 0)
				return;

			StawkaPTU.ListaStawekPTU.Remove((StawkaPTU)listBox1.SelectedItem);
			odśwież_listę();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			foreach (StawkaPTU s in StawkaPTU.ListaStawekPTU)
				if (s == numericUpDown1.Value)
				{
					MessageBox.Show("Taka stawka już istnieje.", "Błąd");
					return;
				}

			StawkaPTU stawka = (StawkaPTU)listBox1.SelectedItem;
			stawka.Stawka = numericUpDown1.Value;
			odśwież_listę();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (listBox1.SelectedIndex < 1)
				return;

			int i = listBox1.SelectedIndex;
			StawkaPTU stawka = StawkaPTU.ListaStawekPTU[i];
			StawkaPTU.ListaStawekPTU.RemoveAt(i);
			StawkaPTU.ListaStawekPTU.Insert(i - 1, stawka);
			odśwież_listę();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			if (listBox1.SelectedIndex > listBox1.Items.Count - 1)
				return;
			int i = listBox1.SelectedIndex;
			StawkaPTU stawka = StawkaPTU.ListaStawekPTU[i];
			StawkaPTU.ListaStawekPTU.RemoveAt(i);
			StawkaPTU.ListaStawekPTU.Insert(i + 1, stawka);
			odśwież_listę();

		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBox1.SelectedIndex>-1)
				numericUpDown1.Value=((StawkaPTU)listBox1.SelectedItem).Stawka;
			else
				numericUpDown1.Value = 0m;

		}

		private void button4_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
		}

		private void FormStawkiPTU_Load(object sender, EventArgs e)
		{
			odśwież_listę();
		}
	}
}
