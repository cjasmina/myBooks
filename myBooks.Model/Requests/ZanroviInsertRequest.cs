using System.ComponentModel.DataAnnotations;

namespace myBooks.Model.Requests
{
    public class ZanroviInsertRequest
    {
        [Required(ErrorMessage = "Naziv žanra je obavezan!")]
        public string Naziv { get; set; }
    }
}
