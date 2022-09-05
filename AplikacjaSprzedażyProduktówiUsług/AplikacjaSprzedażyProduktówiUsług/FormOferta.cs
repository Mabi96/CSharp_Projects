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
	
	public partial class FormOferta : Form
	{
		Oferta oferta;

		internal FormOferta(Oferta oferta)
		{
			InitializeComponent();
			this.oferta = oferta;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			oferta.CenaNetto = numericUpDown1.Value;
			oferta.Nazwa = textBox1.Text;
			oferta.PodlegaPTU = checkBox1.Checked;
			
			if (checkBox1.Checked)
				oferta.StawkaPTU = (StawkaPTU)comboBox1.SelectedItem;
			else
				oferta.StawkaPTU = null;

			DialogResult = DialogResult.OK;
		}

		private void FormOferta_Load(object sender, EventArgs e)
		{
			comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox1.Items.Clear();
			foreach (StawkaPTU st in StawkaPTU.ListaStawekPTU)
				comboBox1.Items.Add(st);
			if(oferta.PodlegaPTU)
				comboBox1.SelectedItem = oferta.StawkaPTU;

			checkBox1.Checked = oferta.PodlegaPTU;
			textBox1.Text = oferta.Nazwa;
			numericUpDown1.Value = oferta.CenaNetto;


		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
				numericUpDown2.Value = ((StawkaPTU)comboBox1.SelectedItem) * numericUpDown1.Value + numericUpDown1.Value;
			else
				numericUpDown2.Value = numericUpDown1.Value;
		}

		private void numericUpDown2_ValueChanged(object sender, EventArgs e)
		{
			//if (checkBox1.Checked)
			//	numericUpDown1.Value = numericUpDown1.Value / (1.0m + ((StawkaPTU)comboBox1.SelectedItem).Stawka);
			//else
			//	numericUpDown1.Value = numericUpDown2.Value;

		}
	}
}
