using System;
using System.ComponentModel.DataAnnotations;

namespace myBooks.Model.Requests
{
    public class RecenzijeInsertRequest
    {
        [Required(ErrorMessage = "Sadržaj recenzija je obavezna!")]
        public string Sadrzaj { get; set; }

        [Required(ErrorMessage = "Datum objave recenzije je obavezan!")]
        public DateTime DatumObjave { get; set; }

        [Required(ErrorMessage = "Korisnik recenzije je obavezan!")]
        public int KorisnikId { get; set; }

        [Required(ErrorMessage = "Knjiga recenzije je obavezna!")]
        public int KnjigaId { get; set; }
    }
}
