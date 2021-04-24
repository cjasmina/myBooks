using System;
using System.Collections.Generic;

namespace myBooks.API.Database
{
    public partial class Police
    {
        public Police()
        {
            PoliceKnjige = new HashSet<PoliceKnjige>();
        }

        public int PolicaId { get; set; }
        public string Naziv { get; set; }
        public DateTime Datum { get; set; }
        public int KorisnikId { get; set; }
        public int? CiljniBroj { get; set; }
        public DateTime? KrajnjiDatumCilja { get; set; }

        public Korisnici Korisnik { get; set; }
        public ICollection<PoliceKnjige> PoliceKnjige { get; set; }
    }
}
