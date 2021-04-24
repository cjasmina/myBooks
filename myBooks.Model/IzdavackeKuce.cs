using System.ComponentModel.DataAnnotations;

namespace myBooks.Model
{
    public class IzdavackeKuce
    {
        public int IzdavackaKucaId { get; set; }

        [Required]
        public string Naziv { get; set; }

        [Required]
        public int GradId { get; set; }
    }
}
