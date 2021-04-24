using System;
using System.Collections.Generic;

namespace myBooks.API.Database
{
    public partial class KnjigeAutori
    {
        public int KnjigaAutorId { get; set; }
        public int AutorId { get; set; }
        public int KnjigaId { get; set; }

        public Autori Autor { get; set; }
        public Knjige Knjiga { get; set; }
    }
}
