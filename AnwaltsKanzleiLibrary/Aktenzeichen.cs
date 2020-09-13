using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AnwaltsKanzleiLibrary
{
    /// <summary>
    /// Zuordnung eines Aktenzeichnens einem Kienten und Mitarbeiter
    /// </summary>
    public class Aktenzeichen
    {
        /// <summary>
        //Aktenzeichen
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// zugeordneter Klient
        /// </summary>
        public Klient Klient { get; set; } = new Klient();

        /// <summary>
        /// zugeordneter Mitarbeiter
        /// </summary>
        public Mitarbeiter Mitarbeiter { get; set; } = new Mitarbeiter();
    }
}
