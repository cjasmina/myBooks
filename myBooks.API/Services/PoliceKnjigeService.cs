using System.Linq;
using System.Collections.Generic;

using AutoMapper;

using myBooks.API.Database;
using myBooks.Model.Requests;
using Microsoft.EntityFrameworkCore;

namespace myBooks.API.Services
{
    public class PoliceKnjigeService : BaseCrudService<Model.PoliceKnjige, Database.PoliceKnjige, PoliceKnjigeSearchRequest, PoliceKnjigeUpsertRequest, PoliceKnjigeUpsertRequest>
    {
        public PoliceKnjigeService(myBooksContext database, IMapper mapper) : base(database, mapper)
        {
        }

        public override List<Model.PoliceKnjige> Get(PoliceKnjigeSearchRequest search)
        {
            var query = _databaseContext.PoliceKnjige.Include(pk => pk.Polica).AsQueryable();

            if (search != null)
            {
                if (search.PolicaId != null)
                {
                    query = query.Where(x => x.PolicaId == search.PolicaId);
                }

                if (search.KnjigaId != null)
                {
                    query = query.Where(x => x.KnjigaId == search.KnjigaId);
                }

                if (search.KorisnikId != null)
                {
                    query = query.Where(x => x.Polica.KorisnikId == search.KorisnikId);
                }
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.PoliceKnjige>>(list);
        }


        public void DeleteByRequest(PoliceKnjigeDeleteRequest request)
        {
            var polica = _databaseContext.Police.Find(request.PolicaId);
            var policaKnjige = _databaseContext.PoliceKnjige.Where(pk => pk.PolicaId == request.PolicaId && pk.KnjigaId == request.KnjigaId).ToList();

            var ocjene = _databaseContext.Ocjene.Where(o => o.KnjigaId == request.KnjigaId && o.KorisnikId == polica.KorisnikId).ToList();
            var recenzije = _databaseContext.Recenzije.Where(o => o.KnjigaId == request.KnjigaId && o.KorisnikId == polica.KorisnikId).ToList();

            _databaseContext.PoliceKnjige.RemoveRange(policaKnjige);
            _databaseContext.Ocjene.RemoveRange(ocjene);
            _databaseContext.Recenzije.RemoveRange(recenzije);

            _databaseContext.SaveChanges();
        }
    }
}
