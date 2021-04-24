using System;
using System.ComponentModel.DataAnnotations;

namespace myBooks.Model
{
    public class Recenzije
    {
        public int RecenzijaId { get; set; }

        [Required]
        public string Sadrzaj { get; set; }

        [Required]
        public DateTime DatumObjave { get; set; }

        [Required]
        public RecenzijeKorisnici Korisnik { get; set; }

        [Required]
        public int KnjigaId { get; set; }
    }
}
