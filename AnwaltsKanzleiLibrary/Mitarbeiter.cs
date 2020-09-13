using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnwaltsKanzleiLibrary
{
    /// <summary>
    /// Klasse für die Mitarbeiter der Kanzlei
    /// </summary>
    public class Mitarbeiter
    {
        /// <summary>
        /// Eindeutige Personalnummer eines Mitarbeiters 
        /// </summary>
        public int Personalnummer { get; set; }

        /// <summary>
        /// Titel eines Mitarbeiters
        /// </summary>
        public string Anrede { get; set; }

        /// <summary>
        /// Titel eines Mitarbeiters
        /// </summary>
        public string Titel { get; set; }

        /// <summary>
        /// Name eines Mitarbeiters
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Vorname eines Mitarbeiters
        /// </summary>
        public string Vorname { get; set; }

        /// <summary>
        /// Adresse eines Mitarbeiters
        /// </summary>
        public Adresse Adresse { get; set; } = new Adresse();

        /// <summary>
        /// Telefon eines Mitarbeiters
        /// </summary>
        public string Telefon { get; set; }

        /// <summary>
        /// Funktion eines Mitarbeiters
        /// </summary>
        public string Funktion { get; set; }

        /// <summary>
        /// Rechtsgebiet(e) eines Mitarbeiters: von 0 bis n
        /// </summary>
        public List<Rechtsgebiet> Rechtsgebiete { get; set; } = new List<Rechtsgebiet>();

        /// <summary>
        /// Terminvorgänge eines Mitarbeiters: vergangene und geplante
        /// </summary>
        public List<Termin> Termine { get; set; } = new List<Termin>();

        /// <summary>
        /// Alle Aktenzeichen, für die ein Mitarbeiter aktuell zuständig ist
        /// </summary>
        public List<string> Aktenzeichen { get; set; } = new List<string>();
    }
}
