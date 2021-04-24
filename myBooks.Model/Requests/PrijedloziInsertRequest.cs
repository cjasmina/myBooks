using System;
using System.ComponentModel.DataAnnotations;

namespace myBooks.Model.Requests
{
    public class PrijedloziInsertRequest
    {
        [Required(ErrorMessage = "Naziv knjige je obavezan!")]
        public string Naziv { get; set; }

        [Required(ErrorMessage = "Autor knjige je obavezan!")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "Datum prijedloga je obavezan!")]
        public DateTime Datum { get; set; }

        [Required(ErrorMessage = "Korisnik prijedloga je obavezan!")]
        public int KorisnikId { get; set; }
    }
}
