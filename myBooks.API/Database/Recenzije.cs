using System;
using System.Collections.Generic;

namespace myBooks.API.Database
{
    public partial class Recenzije
    {
        public int RecenzijaId { get; set; }
        public string Sadrzaj { get; set; }
        public DateTime DatumObjave { get; set; }
        public int KorisnikId { get; set; }
        public int KnjigaId { get; set; }

        public Knjige Knjiga { get; set; }
        public Korisnici Korisnik { get; set; }
    }
}
