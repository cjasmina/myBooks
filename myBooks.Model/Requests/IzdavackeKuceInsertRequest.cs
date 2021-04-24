using System.ComponentModel.DataAnnotations;

namespace myBooks.Model.Requests
{
    public class IzdavackeKuceInsertRequest
    {
        [Required(ErrorMessage = "Naziv izdavačke kuće je obavezan!")]
        public string Naziv { get; set; }

        [Required(ErrorMessage = "Grad izdavačke kuće je obavezan!")]
        public int GradId { get; set; }
    }
}
