using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnwaltsKanzleiLibrary
{
    /// <summary>
    /// Klasse für einen Termin mit "Datum", "von" und "bis"-Eigenschaften als Primärschlüssel
    /// </summary>
    public class Termin
    {
        /// <summary>
        /// ID eines Termins
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// Termin-Beginnzeitpunkt
        /// </summary>
        public string Von { get; set; }

        /// <summary>
        /// Termin-Ende
        /// </summary>
        public string Bis { get; set; }

        /// <summary>
        /// Zuständiger Mitarbeiter
        /// </summary>
        public Mitarbeiter Mitarbeiter { get; set; } = new Mitarbeiter();

        /// <summary>
        /// Zugehöriges Aktenzeichen und Klient
        /// </summary>
        public Aktenzeichen Aktenzeichen { get; set; } = new Aktenzeichen();

        /// <summary>
        /// Eingeplanter Sitzungsraum
        /// </summary>
        public Raum Raum { get; set; } = new Raum();
    }
}
