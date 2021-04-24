using System.ComponentModel.DataAnnotations;

namespace myBooks.Model.Requests
{
    public class GradoviUpsertRequest
    {
        [Required(ErrorMessage = "Naziv grada je obavezan!")]
        public string Naziv { get; set; }

        [Required(ErrorMessage = "Država grada je obavezna!")]
        public int DrzavaId { get; set; }
    }
}
