using System.Linq;
using System.Collections.Generic;

using AutoMapper;

using myBooks.API.Database;
using myBooks.Model.Requests;
using Microsoft.EntityFrameworkCore;
using myBooks.API.Helpers;

namespace myBooks.API.Services
{
    public class KnjigeService : BaseCrudService<Model.Knjige, Database.Knjige, KnjigeSearchRequest, KnjigeUpsertRequest, KnjigeUpsertRequest>
    {
        private readonly Preporucivanje _preporucivanje;

        public KnjigeService(myBooksContext database, IMapper mapper) : base(database, mapper)
        {
            _preporucivanje = new Preporucivanje(database, mapper, 0.6);
        }

        public override Model.Knjige GetById(int id)
        {
            var entity = _databaseContext.Knjige.Include(k => k.KnjigeAutori).ThenInclude(ka => ka.Autor).FirstOrDefault(k => k.KnjigaId == id);

            return _mapper.Map<Model.Knjige>(entity);
        }

        public override List<Model.Knjige> Get(KnjigeSearchRequest search)
        {
            var query = _databaseContext.Knjige.Include(k => k.PoliceKnjige)
                                               .Include(k => k.Zanr)
                                               .Include(k => k.Jezik)
                                               .Include(k => k.IzdavackaKuca)
                                               .Include(k => k.Ocjene)
                                               .Include(k => k.KnjigeAutori).ThenInclude(ka => ka.Autor).AsQueryable();

            if (search != null)
            {
                if (!string.IsNullOrEmpty(search.ISBN))
                {
                    query = query.Where(x => x.Isbn.ToLower().Contains(search.ISBN.ToLower()));
                }

                if (!string.IsNullOrEmpty(search.Naziv))
                {
                    query = query.Where(x => x.Naziv.ToLower().Contains(search.Naziv.ToLower()));
                }

                if (search.PolicaId != null)
                {
                    query = query.Where(x => x.PoliceKnjige.Any(pk => pk.PolicaId == search.PolicaId));
                }

                if (search.ZanrId != null)
                {
                    query = query.Where(x => x.ZanrId == search.ZanrId);
                }

                if (search.JezikId != null)
                {
                    query = query.Where(x => x.JezikId == search.JezikId);
                }

                if (search.IzdavackaKucaId != null)
                {
                    query = query.Where(x => x.IzdavackaKucaId == search.IzdavackaKucaId);
                }
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Knjige>>(list);
        }

        public List<Model.Knjige> PreporuciKnjige(KnjigeSearchRequest search)
        {
            return _preporucivanje.PreporuciKnjige(search.KnjigaId.Value);
        }

        public override Model.Knjige Insert(KnjigeUpsertRequest request)
        {
            var entity = _mapper.Map<Knjige>(request);
            entity.KnjigeAutori = request.Autori.Select(a => new KnjigeAutori
            {
                AutorId = a
            }).ToList();

            _databaseContext.Knjige.Add(entity);
            _databaseContext.SaveChanges();

            return _mapper.Map<Model.Knjige>(entity);
        }

        public override Model.Knjige Update(int id, KnjigeUpsertRequest request)
        {
            var entity = _databaseContext.Knjige.Include(k => k.KnjigeAutori).FirstOrDefault(k => k.KnjigaId == id);

            _databaseContext.KnjigeAutori.RemoveRange(entity.KnjigeAutori);

            _mapper.Map(request, entity);

            entity.KnjigeAutori = request.Autori.Select(a => new KnjigeAutori
            {
                AutorId = a
            }).ToList();

            _databaseContext.Knjige.Update(entity);
            _databaseContext.SaveChanges();

            return _mapper.Map<Model.Knjige>(entity);
        }
    }
}
