using System;
using System.Collections.Generic;

namespace myBooks.API.Database
{
    public partial class Autori
    {
        public Autori()
        {
            KnjigeAutori = new HashSet<KnjigeAutori>();
        }

        public int AutorId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Biografija { get; set; }

        public ICollection<KnjigeAutori> KnjigeAutori { get; set; }
    }
}
