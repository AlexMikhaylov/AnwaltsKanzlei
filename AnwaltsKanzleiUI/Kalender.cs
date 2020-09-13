using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnwaltsKanzleiLibrary;

namespace AnwaltsKanzleiUI
{
    public partial class Kalender : UserControl
    {
        private Klient klient = new Klient();
        private Mitarbeiter mitarbeiter = new Mitarbeiter();
        private Aktenzeichen Aktenzeichen = new Aktenzeichen();
        private Dictionary<string, Aktenzeichen> alle = new Dictionary<string, Aktenzeichen>();

        public Kalender()
        {
            InitializeComponent();
        }

        public string getSelectedDate()
        {
            
            monthCalendar1.MaxSelectionCount = 1;
            

            return monthCalendar1.SelectionRange.Start.ToShortDateString();
        }

        /// <summary>
        /// Die Aktenzeichen, Klienten und Mitarbeiter-Objekte für den ausgewählten Datensatz erstellen
        /// </summary>
        /// <param name="aktenzeichen"></param>
        public void setObjekte(Aktenzeichen aktenzeichen, Dictionary<string, Aktenzeichen> alle)
        {
            // Klienten-Objekt erstellen
            this.klient.Id = aktenzeichen.Klient.Id;
            this.klient.Anrede = aktenzeichen.Klient.Anrede;
            this.klient.Vorname = aktenzeichen.Klient.Vorname;
            this.klient.Name = aktenzeichen.Klient.Name;

            // Mitarbeiter-Objekt erstellen
            this.mitarbeiter.Personalnummer = aktenzeichen.Mitarbeiter.Personalnummer;
            this.mitarbeiter.Anrede = aktenzeichen.Mitarbeiter.Anrede;
            this.mitarbeiter.Titel = aktenzeichen.Mitarbeiter.Titel;
            this.mitarbeiter.Vorname = aktenzeichen.Mitarbeiter.Vorname;
            this.mitarbeiter.Name = aktenzeichen.Mitarbeiter.Name;
            this.mitarbeiter.Telefon = aktenzeichen.Mitarbeiter.Telefon;
            this.mitarbeiter.Funktion = aktenzeichen.Mitarbeiter.Funktion;


            //Aktenzeichen-Objekt erstellen
            this.Aktenzeichen.Id = aktenzeichen.Id;
            this.Aktenzeichen.Klient = aktenzeichen.Klient;
            this.Aktenzeichen.Mitarbeiter = aktenzeichen.Mitarbeiter;

            //Sammlung kopieren
            this.alle = alle.ToDictionary(entry => entry.Key, entry => entry.Value);
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            //Das Fenster mit Terminen öffnen
            var selectedDate = getSelectedDate();
            Termine termine = new Termine(Aktenzeichen, selectedDate, alle);
            termine.Show();
            

        }


        public void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            labelBezeichnungen.Text = $"Aktenzeichen:\nKlient:\nMitarbeiter:\nDatum:";
            labelPlatzhalterDaten.Text = $"{Aktenzeichen.Id}\n{klient.Anrede} {klient.Name}, {klient.Vorname}\n{mitarbeiter.Anrede} {mitarbeiter.Titel} {mitarbeiter.Name}, {mitarbeiter.Vorname}\n{getSelectedDate()}";

        }
    }
}
