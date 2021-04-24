using System.ComponentModel.DataAnnotations;

namespace myBooks.Model.Requests
{
    public class KnjigeAutoriInsertRequest
    {
        [Required(ErrorMessage = "Autor je obavezan!")]
        public int AutorId { get; set; }

        [Required(ErrorMessage = "Knjiga je obavezna!")]
        public int KnjigaId { get; set; }
    }
}
