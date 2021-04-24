using System;
using System.ComponentModel.DataAnnotations;

namespace myBooks.Model
{
    public class Autori
    {
        public int AutorId { get; set; }

        [Required]
        public string Ime { get; set; }

        [Required]
        public string Prezime { get; set; }

        [Required]
        public DateTime DatumRodjenja { get; set; }

        public string Biografija { get; set; }

        public string ImePrezime => $"{Ime} {Prezime}";
    }
}
