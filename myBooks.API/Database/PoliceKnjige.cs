using System;
using System.Collections.Generic;

namespace myBooks.API.Database
{
    public partial class PoliceKnjige
    {
        public int PolicaKnjigaId { get; set; }
        public int PolicaId { get; set; }
        public int KnjigaId { get; set; }
        public bool Procitano { get; set; }

        public Knjige Knjiga { get; set; }
        public Police Polica { get; set; }
    }
}
