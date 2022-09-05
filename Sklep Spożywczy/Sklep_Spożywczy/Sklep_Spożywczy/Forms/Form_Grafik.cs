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

    public partial class Form_Grafik : Form
    {
        //Wyświetlanie podczas załadowania
        public Form_Grafik()
        {
            InitializeComponent();
            WyświetlGrafik();
        }
        // Dodanie pracowników do combobox'a
        private void Form_Grafik_Load(object sender, EventArgs e)
        {
            foreach (Pracownik p in Pracownik.Lista_pracowników)
            {
                comboBox1.Items.Add(p);
            }
        }

        public void WyświetlGrafik()
        {
            dataGridView1.Rows.Clear();
            foreach (Przyjścia_do_Pracy pdp in Przyjścia_do_Pracy.Lista_przyjść_do_pracy)
            {
                if (pdp.Liczba_godzin_zaplanowanych != 0)
                {
                    int index = dataGridView1.Rows.Add(pdp.Tabela());
                    dataGridView1.Rows[index].Tag = pdp;
                }
            }
        }

        //GRAFIK
        private void button_Dodaj_Click(object sender, EventArgs e)
        {
                Przyjścia_do_Pracy przyjścia_Do_Pracy = new Przyjścia_do_Pracy();

                przyjścia_Do_Pracy.Pracownik = (Pracownik)comboBox1.SelectedItem;
                foreach (Dni_Robocze dr in Dni_Robocze.Lista_dni_roboczych)
                {
                    if (monthCalendar1.SelectionStart.Date == dr.Data)
                        przyjścia_Do_Pracy.Dni_robocze = dr;
                }
                przyjścia_Do_Pracy.Liczba_godzin_zaplanowanych = (int)numericUpDown1.Value;
                przyjścia_Do_Pracy.Liczba_godzin_przepracowanych = (int)numericUpDown2.Value;

                Przyjścia_do_Pracy.Lista_przyjść_do_pracy.Add(przyjścia_Do_Pracy);
                WyświetlGrafik();
        }
        //Zmiana tylko godzin zaplanowanych i przepracowanych
        private void button_Zmień_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
                return;
            Przyjścia_do_Pracy przyjścia_Do_Pracy = (Przyjścia_do_Pracy)(dataGridView1.SelectedRows[0].Tag);
            przyjścia_Do_Pracy.Liczba_godzin_zaplanowanych = (int)numericUpDown1.Value;
            przyjścia_Do_Pracy.Liczba_godzin_przepracowanych = (int)numericUpDown2.Value;
            WyświetlGrafik();
        }

        private void Usuń_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
                return;
                Przyjścia_do_Pracy przyjścia_Do_Pracy = (Przyjścia_do_Pracy)(dataGridView1.SelectedRows[0].Tag);
                Przyjścia_do_Pracy.Lista_przyjść_do_pracy.Remove(przyjścia_Do_Pracy);
            WyświetlGrafik();
        }
        //Przycisk zapisu danych
        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            try
            {
                DialogResult result = MessageBox.Show("Czy zapisać dane Pracy do pliku?", "Zapisz", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                    return;

                sfd.Filter = "Pliki aplikacji SKLEP SPOŻYWCZY (*.appr)|*.appr";
                if (sfd.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                FileStream file = new FileStream(sfd.FileName, FileMode.Create, FileAccess.ReadWrite);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file, Przyjścia_do_Pracy.Lista_przyjść_do_pracy);
                bf.Serialize(file, Size);
                file.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się zapisać danych do pliku:\n" + sfd.FileName + "\n" + ex.Message, "Błąd");
            }
        }
        //Przycisk wczytania danych
        private void wczytajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = string.Empty;
            try
            {
                ofd.Filter = "Pliki aplikacji SKLEP SPOŻYWCZY (*.appr)|*.appr";
                if (ofd.ShowDialog() != DialogResult.OK)
                    return;

                FileStream file = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                Przyjścia_do_Pracy.Lista_przyjść_do_pracy = (List<Przyjścia_do_Pracy>)bf.Deserialize(file);
                Size = (Size)bf.Deserialize(file);

                file.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się odczytać danych z pliku:\n" + ofd.FileName + "\n" + ex.Message, "Błąd");
            }
        }

        private void button_Zamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
