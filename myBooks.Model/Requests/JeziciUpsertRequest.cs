using System.ComponentModel.DataAnnotations;

namespace myBooks.Model.Requests
{
    public class JeziciUpsertRequest
    {
        [Required(ErrorMessage = "Naziv jezika je obavezan!")]
        public string Naziv { get; set; }
    }
}
