using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnwaltsKanzleiLibrary
{
    /// <summary>
    /// Rechtsgebiete der Spezialisierung von Mitarbeitern: von 0 bis n
    /// </summary>
    public class Rechtsgebiet
    {
        /// <summary>
        /// ID eines Rechtsgebietes
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Bezeichnung eines Rechtsgebietes
        /// </summary>
        public string Bezeichnung { get; set; }

    }
}
