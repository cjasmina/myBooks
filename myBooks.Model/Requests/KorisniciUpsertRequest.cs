using System;
using System.ComponentModel.DataAnnotations;

namespace myBooks.Model.Requests
{
    public class KorisniciUpsertRequest
    {
        [Required(ErrorMessage = "Ime korisnika je obavezno!")]
        public string Ime { get; set; }
        [Required(ErrorMessage = "Prezime korisnika je obavezno!")]
        public string Prezime { get; set; }
        [Required(ErrorMessage = "Email korisnika je obavezan!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Datum rođenja korisnika je obavezan!")]
        public DateTime DatumRodjenja { get; set; }
        [Required(ErrorMessage = "Telefon korisnika je obavezan!")]
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        [Required(ErrorMessage = "Uloga korisnika je obavezna!")]
        public Uloge Uloga { get; set; }
    }
}
