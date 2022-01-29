using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Diplomarbeit
{
    public class Listen_Generator
    {
        private List<Veranstaltung> m_VLst;
        private string[] m_Orte;
        private string[] m_Veranstaltungsart;
        private string[] m_Vortragender;
        private string[] m_Studiengruppe;
        private string[] m_Modul;

        public Listen_Generator()
        {
            m_VLst = new List<Veranstaltung>();
            m_Orte = new string[] { "Ingenium", "HAK Grazbachgasse" };
            m_Veranstaltungsart = new string[] { "Projektgruppe", "Seminar", "Prüfungstermin" };
            m_Vortragender = new string[] { "Mayer", "Weber" };
            m_Studiengruppe = new string[] { "KIF-GRAZ-2009", "KIF-GRAZ-2109" };
            m_Modul = new string[] { "DA", "DB" };
        }

        public List<Veranstaltung> GetVlist()
        {
            for (int i = 0; i < 50; i++)
            {
                m_VLst.Add(new Veranstaltung
                {
                    VeranstID = 1000 + i,
                    Datumvon = new DateTime(2022, 01, 25, 10, 00, 00).AddDays(7 * i),
                    Datumbis = new DateTime(2022, 01, 25, 16, 00, 00).AddDays(7 * i),
                    Ort = m_Orte[i % 2],
                    Veranstaltungsart = m_Veranstaltungsart[i % 3],
                    Vortragender = m_Vortragender[i % 2],
                    Studiengruppe = m_Studiengruppe[i % 2],
                    Modul = m_Modul[i % 2],
                    AnzTeiln = 4
                });
            }

            return m_VLst;
        }

    }
}