using System.ComponentModel.DataAnnotations;

namespace myBooks.Model
{
    public class Ocjene
    {
        public int OcjenaId { get; set; }

        [Required]
        public int Ocjena { get; set; }

        [Required]
        public int KorisnikId { get; set; }

        [Required]
        public int KnjigaId { get; set; }
    }
}
