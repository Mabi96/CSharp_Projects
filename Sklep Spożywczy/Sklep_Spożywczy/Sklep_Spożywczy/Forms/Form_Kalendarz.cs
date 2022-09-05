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
    public partial class Form_Kalendarz : Form
    {

        public Form_Kalendarz()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
            foreach (Dni_Robocze dr in Dni_Robocze.Lista_dni_roboczych)
            {
                monthCalendar1.AddBoldedDate(dr.Data);
                if (monthCalendar1.SelectionStart == dr.Data.Date)
                {
                    if (dr.Zaplanowane_roboczo_godziny != 0)
                    {
                        textBox1.Text = dr.Zaplanowane_roboczo_godziny.ToString() + " godzin";
                        return;
                    }
                }
                else
                    textBox1.Text = "Nie zaplanowano";
            }
        }

        private void button_dodaj_Click(object sender, EventArgs e)
        {
            Dni_Robocze dni_Robocze = new Dni_Robocze();
            
            dni_Robocze.Data = monthCalendar1.SelectionStart.Date;
            monthCalendar1.AddBoldedDate(dni_Robocze.Data);
            dni_Robocze.Zaplanowane_roboczo_godziny = (int)numericUpDown1.Value;
            Dni_Robocze.Lista_dni_roboczych.Add(dni_Robocze);

            monthCalendar1_DateChanged(sender,null);
        }
       

        private void button_modyfikuj_Click(object sender, EventArgs e)
        {
            foreach (Dni_Robocze dr in Dni_Robocze.Lista_dni_roboczych)
            {
                if (monthCalendar1.SelectionStart == dr.Data.Date)
                {
                    dr.Data = monthCalendar1.SelectionStart.Date;
                    dr.Zaplanowane_roboczo_godziny = (int)numericUpDown1.Value;
                }
            }
            monthCalendar1_DateChanged(sender, null);
        }

        private void button_usuń_Click(object sender, EventArgs e)
        {
            foreach (Dni_Robocze dr in Dni_Robocze.Lista_dni_roboczych)
            {
                if (monthCalendar1.SelectionStart == dr.Data.Date)
                {
                    Dni_Robocze.Lista_dni_roboczych.Remove(dr);
                    monthCalendar1.RemoveBoldedDate(dr.Data);
                    return;
                }
            }
            monthCalendar1_DateChanged(sender, null);
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            try
            {
                DialogResult result = MessageBox.Show("Czy zapisać dane Kalendarza do pliku?", "Zapisz", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                    return;

                sfd.Filter = "Pliki aplikacji SKLEP SPOŻYWCZY (*.appr)|*.appr";
                if (sfd.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                FileStream file = new FileStream(sfd.FileName, FileMode.Create, FileAccess.ReadWrite);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file, Dni_Robocze.Lista_dni_roboczych);
                bf.Serialize(file, Size);
                file.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się zapisać danych do pliku:\n" + sfd.FileName + "\n" + ex.Message, "Błąd");
            }
        }

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
                Dni_Robocze.Lista_dni_roboczych = (List<Dni_Robocze>)bf.Deserialize(file);
                Size = (Size)bf.Deserialize(file);

                file.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się odczytać danych z pliku:\n" + ofd.FileName + "\n" + ex.Message, "Błąd");
            }
            foreach (Dni_Robocze dr in Dni_Robocze.Lista_dni_roboczych)
            {
                monthCalendar1.AddBoldedDate(dr.Data);
            }
        }

        private void button_Zamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
