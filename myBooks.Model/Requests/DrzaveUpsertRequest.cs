using System.ComponentModel.DataAnnotations;

namespace myBooks.Model.Requests
{
    public class DrzaveUpsertRequest
    {
        [Required(ErrorMessage = "Naziv države je obavezan!")]
        public string Naziv { get; set; }
    }
}
