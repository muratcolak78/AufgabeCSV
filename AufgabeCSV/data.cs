using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabeCSV
{
    public class data
    {
        public data(string nr, string anrede, string titel, string vorname, string nachname, string geburtsdatum, string straße, string hausnummer, string postleitzahl, string stadt, string telefon, string mobil, string eMail, string newsletter)
        {
            Nr = nr;
            Anrede = anrede;
            Titel = titel;
            Vorname = vorname;
            Nachname = nachname;
            Geburtsdatum = geburtsdatum;
            Straße = straße;
            Hausnummer = hausnummer;
            Postleitzahl = postleitzahl;
            Stadt = stadt;
            Telefon = telefon;
            Mobil = mobil;
            EMail = eMail;
            Newsletter = newsletter;
        }

        public string Nr { get; set; }
        public string Anrede { get; set; }
        public string Titel { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Geburtsdatum { get; set; }
        public string Straße { get; set; }
        public string Hausnummer { get; set; }
        public string Postleitzahl { get; set; }
        public string Stadt { get; set; }
        public string Telefon { get; set; }
        public string Mobil { get; set; }
        public string EMail { get; set; }
        public string Newsletter { get; set; }


        public override string ToString()
        {
            return $"{Nr,-5} {Anrede,-10} {Titel,-10} {Vorname,-15} {Nachname,-15} {Geburtsdatum,-12:dd.MM.yyyy} {Straße,-20} {Hausnummer,-10} {Postleitzahl,-10} {Stadt,-15} {Telefon,-15} {Mobil,-15} {EMail,-30} {Newsletter}";
        }

    }
}
