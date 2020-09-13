using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnwaltsKanzleiLibrary
{
    /// <summary>
    /// Klasse für Klienten der Kanzlei
    /// </summary>
    public class Klient
    {
        /// <summary>
        /// Eindeutige Klienten-ID - künstlicher Primärschlüssel
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Anrede eines Klienten
        /// </summary>
        public string Anrede { get; set; }

        /// <summary>
        /// Name eines Klienten
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Vorname eines Klienten
        /// </summary>
        public string Vorname { get; set; }

        /// <summary>
        /// Adresse eines Klienten
        /// </summary>
        public Adresse Adresse { get; set; } = new Adresse();

        /// <summary>
        /// Liste der zugeordneten Aktenzeichen
        /// </summary>
        public List<string> Aktenzeichen { get; set; } = new List<string>();

        /// <summary>
        /// Liste der geplanten Termine
        /// </summary>
        public List<Termin> Termine { get; set; } = new List<Termin>();

    }
}
