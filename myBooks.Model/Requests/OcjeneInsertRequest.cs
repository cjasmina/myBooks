using System.ComponentModel.DataAnnotations;

namespace myBooks.Model.Requests
{
    public class OcjeneInsertRequest
    {
        [Required(ErrorMessage = "Ocjena je obavezna!")]
        public int Ocjena { get; set; }

        [Required(ErrorMessage = "Korisnik ocjene je obavezan!")]
        public int KorisnikId { get; set; }

        [Required(ErrorMessage = "Knjiga ocjene je obavezna!")]
        public int KnjigaId { get; set; }
    }
}
