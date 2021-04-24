using System;
using System.Linq;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

using AutoMapper;

using myBooks.API.Database;

namespace myBooks.API.Helpers
{
    public class Preporucivanje
    {
        private readonly double _slicnost;
        private readonly IMapper _mapper;
        private readonly myBooksContext _databaseContext;

        private readonly Dictionary<int, List<Ocjene>> _knjige = new Dictionary<int, List<Ocjene>>();

        public Preporucivanje(myBooksContext database, IMapper mapper, double slicnost)
        {
            _mapper = mapper;
            _databaseContext = database;
            _slicnost = slicnost;
        }

        public List<Model.Knjige> PreporuciKnjige(int knjigaId)
        {
            InicijalizirajOstaleKnjige(knjigaId);

            var ocjene = _databaseContext.Ocjene.Where(x => x.KnjigaId == knjigaId).OrderBy(x => x.KorisnikId).ToList();

            var zajednickeOcjene1 = new List<Ocjene>();
            var zajednickeOcjene2 = new List<Ocjene>();
            var preporuceno = new List<Model.Knjige>();

            foreach (var k in _knjige)
            {
                foreach (var o in ocjene)
                {
                    if (k.Value.Where(x => x.KorisnikId == o.KorisnikId).Count() > 0)
                    {
                        zajednickeOcjene1.Add(o);
                        zajednickeOcjene2.Add(k.Value.Where(x => x.KorisnikId == o.KorisnikId).First());
                    }
                }

                var slicnost = IzracunajSlicnostIzmedjuKnjiga(zajednickeOcjene1, zajednickeOcjene2);
                if (slicnost > _slicnost)
                {
                    var entity = _databaseContext.Knjige.Find(k.Key);
                    var mapped = _mapper.Map<Model.Knjige>(entity);

                    preporuceno.Add(mapped);
                }

                zajednickeOcjene1.Clear();
                zajednickeOcjene2.Clear();
            }

            return preporuceno;
        }

        private double IzracunajSlicnostIzmedjuKnjiga(List<Ocjene> ocjeneKnjigaLijevo, List<Ocjene> ocjeneKnjigaDesno)
        {
            if (ocjeneKnjigaLijevo.Count != ocjeneKnjigaDesno.Count)
                return 0;

            int brojnik = 0;

            double koeficijentZaOcjene1 = 0;
            double koeficijentZaOcjene2 = 0;

            for (int i = 0; i < ocjeneKnjigaLijevo.Count; i++)
            {
                brojnik += ocjeneKnjigaLijevo[i].Ocjena * ocjeneKnjigaDesno[i].Ocjena;

                koeficijentZaOcjene1 += ocjeneKnjigaLijevo[i].Ocjena * ocjeneKnjigaLijevo[i].Ocjena;
                koeficijentZaOcjene2 += ocjeneKnjigaDesno[i].Ocjena * ocjeneKnjigaDesno[i].Ocjena;
            }

            var nazivnik = Math.Sqrt(koeficijentZaOcjene1) * Math.Sqrt(koeficijentZaOcjene2);

            return nazivnik != 0 ? brojnik / nazivnik : 0;

        }

        private void InicijalizirajOstaleKnjige(int knjigaId)
        {
            var ostaleKnjige = _databaseContext.Knjige.Include(k => k.Ocjene)
                                                      .Where(x => x.KnjigaId != knjigaId && x.Ocjene.Any()).ToList();

            foreach (var item in ostaleKnjige)
            {
                var ocjene = item.Ocjene.OrderBy(o => o.KorisnikId).ToList();

                _knjige.Add(item.KnjigaId, ocjene);
            }
        }
    }
}

