using System.ComponentModel.DataAnnotations;

namespace myBooks.Model
{
    public class KnjigeAutori
    {
        public int KnjigaAutorId { get; set; }

        [Required]
        public int AutorId { get; set; }

        [Required]
        public int KnjigaId { get; set; }
    }
}