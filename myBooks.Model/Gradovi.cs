using System.ComponentModel.DataAnnotations;

namespace myBooks.Model
{
    public class Gradovi
    {
        public int GradId { get; set; }

        [Required]
        public string Naziv { get; set; }

        [Required]
        public int DrzavaId { get; set; }
    }
}
