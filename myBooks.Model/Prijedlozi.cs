using System;
using System.ComponentModel.DataAnnotations;

namespace myBooks.Model
{
    public class Prijedlozi
    {
        public int PrijedlogId { get; set; }

        [Required]
        public string Naziv { get; set; }

        [Required]
        public string Autor { get; set; }

        [Required]
        public DateTime Datum { get; set; }

        [Required]
        public int KorisnikId { get; set; }
    }
}