using System.Linq;
using System.Collections.Generic;

using AutoMapper;

using myBooks.API.Database;
using myBooks.Model.Requests;
using System;

namespace myBooks.API.Services
{
    public class KorisniciService : BaseCrudService<Model.Korisnici, Database.Korisnici, KorisniciSearchRequest, KorisniciUpsertRequest, KorisniciUpsertRequest>
    {
        public KorisniciService(myBooksContext database, IMapper mapper) : base(database, mapper)
        {
        }

        public Korisnici GetPrijavljeniKorisnik(KorisniciPrijavaRequest prijava)
        {
            return _databaseContext.Korisnici.FirstOrDefault(k => k.KorisnickoIme == prijava.KorisnickoIme && k.Uloga == prijava.Uloga);
        }

        public override List<Model.Korisnici> Get(KorisniciSearchRequest search)
        {
            var query = _databaseContext.Korisnici.AsQueryable();

            if (search != null)
            {
                if (!string.IsNullOrEmpty(search.Ime))
                {
                    query = query.Where(x => x.Ime.ToLower().Contains(search.Ime.ToLower()));
                }

                if (!string.IsNullOrEmpty(search.Prezime))
                {
                    query = query.Where(x => x.Prezime.ToLower().Contains(search.Prezime.ToLower()));
                }

                if (!string.IsNullOrEmpty(search.KorisnickoIme))
                {
                    query = query.Where(x => x.KorisnickoIme.ToLower().Contains(search.KorisnickoIme.ToLower()));
                }
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Korisnici>>(list);
        }

        public override Model.Korisnici Insert(KorisniciUpsertRequest request)
        {
            var entity = _mapper.Map<Database.Korisnici>(request);

            entity.LozinkaSalt = Helpers.Security.GenerateSalt();
            entity.LozinkaHash = Helpers.Security.GenerateHash(entity.LozinkaSalt, request.Lozinka);

            entity.Police = new List<Police>
            {
                new Police
                {
                    Naziv = "Želim čitati",
                    Datum = DateTime.Now
                },
                new Police
                {
                    Naziv = "Trenutno čitam",
                    Datum = DateTime.Now
                },
                new Police
                {
                    Naziv = "Pročitao/la sam",
                    Datum = DateTime.Now
                }
            };

            _databaseContext.Korisnici.Add(entity);
            _databaseContext.SaveChanges();

            return _mapper.Map<Model.Korisnici>(entity);
        }

        public override Model.Korisnici Update(int id, KorisniciUpsertRequest request)
        {
            var entity = _databaseContext.Set<Database.Korisnici>().Find(id);

            if (!string.IsNullOrWhiteSpace(request.Lozinka))
            {
                entity.LozinkaSalt = Helpers.Security.GenerateSalt();
                entity.LozinkaHash = Helpers.Security.GenerateHash(entity.LozinkaSalt, request.Lozinka);
            }

            _mapper.Map(request, entity);
            _databaseContext.SaveChanges();

            return _mapper.Map<Model.Korisnici>(entity);
        }
    }
}
