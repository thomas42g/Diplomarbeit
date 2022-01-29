using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Diplomarbeit
{
    public class Veranstaltung
    {
        public int VeranstID { get; set; }
        public DateTime Datumvon { get; set; }
        public DateTime Datumbis { get; set; }
        public string Ort { get; set; }
        public string Veranstaltungsart { get; set; }
        public string Vortragender { get; set; }
        public string Studiengruppe { get; set; }
        public string Modul { get; set; }
        public int AnzTeiln { get; set; }
    }
}