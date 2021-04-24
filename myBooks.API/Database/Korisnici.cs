using System;
using System.Collections.Generic;

using myBooks.Model;

namespace myBooks.API.Database
{
    public partial class Korisnici
    {
        public Korisnici()
        {
            Ocjene = new HashSet<Ocjene>();
            Police = new HashSet<Police>();
            Prijedlozi = new HashSet<Prijedlozi>();
            Recenzije = new HashSet<Recenzije>();
        }

        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public Uloge Uloga { get; set; }

        public ICollection<Ocjene> Ocjene { get; set; }
        public ICollection<Police> Police { get; set; }
        public ICollection<Prijedlozi> Prijedlozi { get; set; }
        public ICollection<Recenzije> Recenzije { get; set; }
    }
}
