using System.Linq;
using System.Collections.Generic;

using AutoMapper;

using myBooks.API.Database;
using myBooks.Model.Requests;

namespace myBooks.API.Services
{
    public class OcjeneService : BaseCrudService<Model.Ocjene, Database.Ocjene, OcjeneSearchRequest, OcjeneInsertRequest, OcjeneInsertRequest>
    {
        public OcjeneService(myBooksContext database, IMapper mapper) : base(database, mapper)
        {
        }

        public override List<Model.Ocjene> Get(OcjeneSearchRequest search)
        {
            var query = _databaseContext.Ocjene.AsQueryable();

            if (search != null)
            {
                if (search.Ocjena != null)
                {
                    query = query.Where(x => x.Ocjena == search.Ocjena);
                }

                if (search.KorisnikId != null)
                {
                    query = query.Where(x => x.KorisnikId == search.KorisnikId);
                }

                if (search.KnjigaId != null)
                {
                    query = query.Where(x => x.KnjigaId == search.KnjigaId);
                }
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Ocjene>>(list);
        }
    }
}
