using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace myBooks.Model.Requests
{
    public class KnjigeUpsertRequest
    {
        [Required(ErrorMessage = "Naziv knjige je obavezan!")]
        public string Naziv { get; set; }

        [Required(ErrorMessage = "Kratak opis knjige je obavezan!")]
        public string KratakOpis { get; set; }

        [Required(ErrorMessage = "Opis knjige je obavezan!")]
        public string Opis { get; set; }

        [Required(ErrorMessage = "Datum izdavanja knjige je obavezan!")]
        public DateTime DatumIzdavanja { get; set; }

        [Required(ErrorMessage = "ISBN knjige je obavezan!")]
        public string ISBN { get; set; }

        [Required(ErrorMessage = "Naslovna fotografija knjige je obavezna!")]
        public byte[] NaslovnaFotografija { get; set; }

        [Required(ErrorMessage = "Žanr knjige je obavezan!")]
        public int ZanrId { get; set; }

        [Required(ErrorMessage = "Izdavačka kuća knjige je obavezna!")]
        public int IzdavackaKucaId { get; set; }

        [Required(ErrorMessage = "Jezik knjige je obavezan!")]
        public int JezikId { get; set; }

        [Required(ErrorMessage = "Autori knjige su obavezni!")]
        public List<int> Autori { get; set; }
    }
}
