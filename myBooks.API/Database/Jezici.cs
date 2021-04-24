using System;
using System.Collections.Generic;

namespace myBooks.API.Database
{
    public partial class Jezici
    {
        public Jezici()
        {
            Knjige = new HashSet<Knjige>();
        }

        public int JezikId { get; set; }
        public string Naziv { get; set; }

        public ICollection<Knjige> Knjige { get; set; }
    }
}
