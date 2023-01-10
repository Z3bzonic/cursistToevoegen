using System.Collections.Generic;

namespace cursistToevoegen
{
    public class Cursist
    {
        public Cursist(string voornaam, string achternaam)
        {
            Voornaam = voornaam;
            Achternaam = achternaam;
        }

        public string Voornaam { get; set; }
        public string Achternaam { get; set; }

        public string Fullname { get => $"{Voornaam} {Achternaam}"; }
    }
}