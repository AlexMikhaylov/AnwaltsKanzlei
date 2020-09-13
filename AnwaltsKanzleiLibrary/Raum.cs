using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnwaltsKanzleiLibrary
{   
    /// <summary>
    /// Ein Sitzungsraum mit einer eindeutigen Nummer, Platzzahl und einer Stzungsart
    /// </summary>
    public class Raum
    {
        /// <summary>
        /// Eindeitige Raum-ID bzw. Raumnummer
        /// </summary>
        public int Raumnummer { get; set; }

        /// <summary>
        /// Sitzungsart des Raumes
        /// </summary>
        public string Sitzungsart { get; set; }

        /// <summary>
        /// Anzahl von Plätzen
        /// </summary>
        public int Platzzahl { get; set; }

        /// <summary>
        /// Termine, in welchen ein Raum eingeplant war bzw. ist
        /// </summary>
        public List<Termin> Termine { get; set; } = new List<Termin>();
    }
}
