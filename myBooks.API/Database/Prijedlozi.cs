using System;

namespace myBooks.API.Database
{
    public partial class Prijedlozi
    {
        public int PrijedlogId { get; set; }
        public string Naziv { get; set; }
        public string Autor { get; set; }
        public DateTime Datum { get; set; }
        public int KorisnikId { get; set; }

        public Korisnici Korisnik { get; set; }
    }
}
