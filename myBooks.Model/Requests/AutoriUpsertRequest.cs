using System;
using System.ComponentModel.DataAnnotations;

namespace myBooks.Model.Requests
{
    public class AutoriUpsertRequest
    {
        [Required(ErrorMessage = "Ime autora je obavezno!")]
        public string Ime { get; set; }

        [Required(ErrorMessage = "Prezime autora je obavezno!")]
        public string Prezime { get; set; }

        [Required(ErrorMessage = "Datum rođenja autora je obavezan!")]
        public DateTime DatumRodjenja { get; set; }

        public string Biografija { get; set; }
    }
}
