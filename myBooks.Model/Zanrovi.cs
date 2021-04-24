using System.ComponentModel.DataAnnotations;

namespace myBooks.Model
{
    public class Zanrovi
    {
        public int ZanrId { get; set; }

        [Required]
        public string Naziv { get; set; }
    }
}
