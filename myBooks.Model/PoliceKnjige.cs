using System;
using System.ComponentModel.DataAnnotations;

namespace myBooks.Model
{
    public class PoliceKnjige
    {
        public int PolicaKnjigaId { get; set; }

        [Required]
        public int PolicaId { get; set; }

        [Required]
        public int KnjigaId { get; set; }

        [Required]
        public Police Polica { get; set; }

        [Required]
        public bool Procitano { get; set; }
    }
}