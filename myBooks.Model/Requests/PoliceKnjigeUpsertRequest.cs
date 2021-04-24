using System.ComponentModel.DataAnnotations;

namespace myBooks.Model.Requests
{
    public class PoliceKnjigeUpsertRequest
    {
        [Required(ErrorMessage = "Polica je obavezna!")]
        public int PolicaId { get; set; }

        [Required(ErrorMessage = "Knjiga je obavezna!")]
        public int KnjigaId { get; set; }

        [Required(ErrorMessage = "Informacija da li je knjiga pročitana je obavezna!")]
        public bool Procitano { get; set; }
    }
}
