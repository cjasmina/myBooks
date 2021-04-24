using System;
using System.ComponentModel.DataAnnotations;

namespace myBooks.Model
{
    public class RecenzijeKorisnici
    {
        [Required]
        public int KorisnikId { get; set; }
        [Required]
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }
        [Required]
        public string KorisnickoIme { get; set; }
    }
}
