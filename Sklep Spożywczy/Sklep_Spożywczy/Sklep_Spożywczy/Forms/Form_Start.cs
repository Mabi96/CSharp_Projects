using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Sklep_Spożywczy
{
    public partial class Form_Start : Form
    {
        public Form_Start()
        {
            InitializeComponent();
        }

        //Przyciski do formatek
        private void button_Pracownicy_Click(object sender, EventArgs e)
        {
            Form_Pracownicy f = new Form_Pracownicy();
            f.Show();
        }

        private void button_Kalendarz_Click(object sender, EventArgs e)
        {
            Form_Kalendarz f = new Form_Kalendarz();
            f.Show();
        }

        private void button_Grafik_Click(object sender, EventArgs e)
        {
            Form_Grafik f = new Form_Grafik();
            f.Show();
        }

        private void button_Raporty_Click(object sender, EventArgs e)
        {
            Form_Raporty f = new Form_Raporty();
            f.Show();
        }

        private void button_Zakończ_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
