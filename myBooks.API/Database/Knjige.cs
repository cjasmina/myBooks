using System;
using System.Collections.Generic;

namespace myBooks.API.Database
{
    public partial class Knjige
    {
        public Knjige()
        {
            KnjigeAutori = new HashSet<KnjigeAutori>();
            Ocjene = new HashSet<Ocjene>();
            PoliceKnjige = new HashSet<PoliceKnjige>();
            Recenzije = new HashSet<Recenzije>();
        }

        public int KnjigaId { get; set; }
        public string Naziv { get; set; }
        public string KratakOpis { get; set; }
        public string Opis { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public string Isbn { get; set; }
        public byte[] NaslovnaFotografija { get; set; }
        public int ZanrId { get; set; }
        public int IzdavackaKucaId { get; set; }
        public int JezikId { get; set; }

        public IzdavackeKuce IzdavackaKuca { get; set; }
        public Jezici Jezik { get; set; }
        public Zanrovi Zanr { get; set; }
        public ICollection<KnjigeAutori> KnjigeAutori { get; set; }
        public ICollection<Ocjene> Ocjene { get; set; }
        public ICollection<PoliceKnjige> PoliceKnjige { get; set; }
        public ICollection<Recenzije> Recenzije { get; set; }
    }
}
