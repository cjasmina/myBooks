using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace myBooks.Model
{
    public class Knjige
    {
        public int KnjigaId { get; set; }

        [Required]
        public string Naziv { get; set; }

        [Required]
        public string KratakOpis { get; set; }

        [Required]
        public string Opis { get; set; }

        [Required]
        public DateTime DatumIzdavanja { get; set; }

        [Required]
        public string ISBN { get; set; }

        [Required]
        public byte[] NaslovnaFotografija { get; set; }

        [Required]
        public int ZanrId { get; set; }

        [Required]
        public int IzdavackaKucaId { get; set; }

        [Required]
        public int JezikId { get; set; }

        [Required]
        public List<Autori> Autori { get; set; }

        public string ZanrNaziv { get; set; }
        public string JezikNaziv { get; set; }
        public string IzdavackaKucaNaziv { get; set; }
        public string PolicaNaziv { get; set; }
        public double ProsjecnaOcjena { get; set; }
    }
}
