using System.ComponentModel.DataAnnotations;

namespace myBooks.Model
{
    public class Jezici
    {
        public int JezikId { get; set; }

        [Required]
        public string Naziv { get; set; }
    }
}
