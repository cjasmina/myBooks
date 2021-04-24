using System.Linq;
using System.Collections.Generic;

using AutoMapper;

using myBooks.API.Database;
using myBooks.Model.Requests;
using Microsoft.EntityFrameworkCore;

namespace myBooks.API.Services
{
    public class PoliceService : BaseCrudService<Model.Police, Database.Police, PoliceSearchRequest, PoliceInsertRequest, PoliceInsertRequest>
    {
        public PoliceService(myBooksContext database, IMapper mapper) : base(database, mapper)
        {
        }

        public override List<Model.Police> Get(PoliceSearchRequest search)
        {
            var query = _databaseContext.Police.Include(p => p.PoliceKnjige).AsQueryable();

            if (search != null)
            {
                if (!string.IsNullOrEmpty(search.Naziv))
                {
                    query = query.Where(x => x.Naziv.ToLower().Contains(search.Naziv.ToLower()));
                }

                query = query.Where(x => x.KorisnikId == search.KorisnikId);
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Police>>(list);
        }

        public override void Delete(int id)
        {
            var polica = _databaseContext.Police.Include(p => p.PoliceKnjige).FirstOrDefault(p => p.PolicaId == id);

            var knjigeIds = polica.PoliceKnjige.Select(pk => pk.KnjigaId).ToList();
            var ocjene = _databaseContext.Ocjene.Where(o => knjigeIds.Any(k => k == o.KnjigaId) && o.KorisnikId == polica.KorisnikId).ToList();
            var recenzije = _databaseContext.Recenzije.Where(o => knjigeIds.Any(k => k == o.KnjigaId) && o.KorisnikId == polica.KorisnikId).ToList();

            _databaseContext.PoliceKnjige.RemoveRange(polica.PoliceKnjige);
            _databaseContext.Ocjene.RemoveRange(ocjene);
            _databaseContext.Recenzije.RemoveRange(recenzije);

            _databaseContext.Police.Remove(polica);
            _databaseContext.SaveChanges();
        }
    }
}
