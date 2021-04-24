using System;
using System.ComponentModel.DataAnnotations;

namespace myBooks.Model
{
    public class Police
    {
        public int PolicaId { get; set; }

        [Required]
        public string Naziv { get; set; }

        [Required]
        public DateTime Datum { get; set; }

        [Required]
        public int KorisnikId { get; set; }

        public int? CiljniBroj { get; set; }

        public DateTime? KrajnjiDatumCilja { get; set; }

        public int BrojKnjiga { get; set; }
        public int BrojProcitanihKnjiga { get; set; }
    }
}