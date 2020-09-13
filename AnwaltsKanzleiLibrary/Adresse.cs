using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnwaltsKanzleiLibrary
{
    /// <summary>
    /// Klasse für die Adressenverwaltung und -zuordnung
    /// </summary>
    public class Adresse
    {
        /// <summary>
        /// Eindeutige ID einer Adresse, künstlicher Primärschlüssel
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Straßenbezeichnung mit Hausnummer
        /// </summary>
        public string Strasse { get; set; }

        /// <summary>
        /// PLS eines Ortes
        /// </summary>
        public string Plz { get; set; }

        /// <summary>
        /// Ortsbezeichnung
        /// </summary>
        public string Ort { get; set; }
    }
}
