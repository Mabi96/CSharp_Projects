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
    public partial class Form_Pracownicy : Form
    {
        public Form_Pracownicy()
        {
            InitializeComponent();
        }

        private void Form_Pracownicy_Load(object sender, EventArgs e)
        {
            WyświetlListęPracowników();
        }
        // Dodawanie Pracowników z listy do DataGridView
        public void WyświetlListęPracowników()
        {
            dataGridView1.Rows.Clear();
            foreach (Pracownik p in Pracownik.Lista_pracowników)
            {
                int index = dataGridView1.Rows.Add(p.Tabela());
                dataGridView1.Rows[index].Tag = p;
            }
        }
        //Przycisk dodawania Pracownika
        private void button_dodaj_Click(object sender, EventArgs e)
        {
            Pracownik nowy_pracownik = new Pracownik();
            Form_Pracownicy_Dodaj f = new Form_Pracownicy_Dodaj(nowy_pracownik);
            if (f.ShowDialog() != DialogResult.OK)
                return;

            Pracownik.Lista_pracowników.Add(nowy_pracownik);
            
            WyświetlListęPracowników();

        }
        //Przycisk modyfikacji Pracownika
        private void button_modyfikuj_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
                return;
            Pracownik pracownik = (Pracownik)(dataGridView1.SelectedRows[0].Tag);
            Form_Pracownicy_Dodaj f = new Form_Pracownicy_Dodaj(pracownik);
            f.ShowDialog();
            WyświetlListęPracowników();
        }
        //Przycisk usuwania Pracownika
        private void button_usuń_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
                return;
            Pracownik pracownik = (Pracownik)(dataGridView1.SelectedRows[0].Tag);
            Pracownik.Lista_pracowników.Remove(pracownik);

            WyświetlListęPracowników();
        }
        // Zapisywanie Pracowników do pliku
        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            try
            {
                DialogResult result = MessageBox.Show("Czy zapisać dane Pracowników do pliku?", "Zapisz", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                    return;

                sfd.Filter = "Pliki aplikacji SKLEP SPOŻYWCZY (*.appr)|*.appr";
                if (sfd.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                FileStream file = new FileStream(sfd.FileName, FileMode.Create, FileAccess.ReadWrite);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file, Pracownik.Lista_pracowników);
                bf.Serialize(file, Size);
                file.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się zapisać danych do pliku:\n" + sfd.FileName + "\n" + ex.Message, "Błąd");
            }
        }
        // Usuwanie Pracowników do pliku
        private void wczytajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = string.Empty;
            try
            {
                ofd.Filter = "Pliki aplikacji PRACOWNICY (*.appr)|*.appr";
                if (ofd.ShowDialog() != DialogResult.OK)
                    return;

                FileStream file = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                Pracownik.Lista_pracowników = (List<Pracownik>)bf.Deserialize(file);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}