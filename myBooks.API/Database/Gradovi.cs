using System;
using System.Collections.Generic;

namespace myBooks.API.Database
{
    public partial class Gradovi
    {
        public Gradovi()
        {
            IzdavackeKuce = new HashSet<IzdavackeKuce>();
        }

        public int GradId { get; set; }
        public string Naziv { get; set; }
        public int DrzavaId { get; set; }

        public Drzave Drzava { get; set; }
        public ICollection<IzdavackeKuce> IzdavackeKuce { get; set; }
    }
}
