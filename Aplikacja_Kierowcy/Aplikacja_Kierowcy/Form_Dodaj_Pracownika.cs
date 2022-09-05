using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja_Kierowcy
{
    public partial class Form_Dodaj_Pracownika : Form
    {
        public Form_Dodaj_Pracownika()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kierowca kierowca = new Kierowca();

             kierowca.imię = textBox1.Text;
             kierowca.nazwisko = textBox2.Text;
             kierowca.rok_uzyskania_uprawnień_do_kierowania = (int)numericUpDown1.Value;
             kierowca.rok_rozpoczęcia_pracy_na_stanowisku = (int)numericUpDown2.Value;
             kierowca.stawka_za_godzinę = (int)numericUpDown3.Value;
             kierowca.stawka_za_km = (int)numericUpDown4.Value;

            Kierowca.lista_kierowców.Add(kierowca);
        }

        private void button_Powrót_Click(object sender, EventArgs e)
        {
            Form_Główna f = new Form_Główna();
            f.Show();
            this.Hide();
        }
    }
}
