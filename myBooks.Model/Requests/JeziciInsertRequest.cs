using System.ComponentModel.DataAnnotations;

namespace myBooks.Model.Requests
{
    public class JeziciInsertRequest
    {
        [Required(ErrorMessage = "Naziv jezika je obavezan!")]
        public string Naziv { get; set; }
    }
}
