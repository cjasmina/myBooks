using System;
using System.ComponentModel.DataAnnotations;

namespace myBooks.Model.Requests
{
    public class PoliceInsertRequest
    {
        [Required(ErrorMessage = "Naziv police je obavezan!")]
        public string Naziv { get; set; }

        [Required(ErrorMessage = "Datum kreiranja police je obavezan!")]
        public DateTime Datum { get; set; }

        [Required(ErrorMessage = "Korisnik police je obavezan!")]
        public int KorisnikId { get; set; }

        public int? CiljniBroj { get; set; }

        public DateTime? KrajnjiDatumCilja { get; set; }
    }
}
