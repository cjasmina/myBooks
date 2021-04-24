using System;
using System.Collections.Generic;

namespace myBooks.API.Database
{
    public partial class IzdavackeKuce
    {
        public IzdavackeKuce()
        {
            Knjige = new HashSet<Knjige>();
        }

        public int IzdavackaKucaId { get; set; }
        public string Naziv { get; set; }
        public int GradId { get; set; }

        public Gradovi Grad { get; set; }
        public ICollection<Knjige> Knjige { get; set; }
    }
}
