using System;
using System.ComponentModel.DataAnnotations;

namespace myBooks.Model
{
    public class Korisnici
    {
        public int KorisnikId { get; set; }

        [Required]
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime DatumRodjenja { get; set; }
        [Required]
        public string Telefon { get; set; }
        [Required]
        public string KorisnickoIme { get; set; }
        [Required]
        public string LozinkaHash { get; set; }
        [Required]
        public string LozinkaSalt { get; set; }
        [Required]
        public Uloge Uloga { get; set; }

        public string ImePrezime => $"{Ime} {Prezime}";
    }
}
