using System.Linq;
using System.Collections.Generic;

using AutoMapper;

using myBooks.API.Database;
using myBooks.Model.Requests;

namespace myBooks.API.Services
{
    public class PrijedloziService : BaseCrudService<Model.Prijedlozi, Database.Prijedlozi, PrijedloziSearchRequest, PrijedloziInsertRequest, PrijedloziInsertRequest>
    {
        public PrijedloziService(myBooksContext database, IMapper mapper) : base(database, mapper)
        {
        }

        public override List<Model.Prijedlozi> Get(PrijedloziSearchRequest search)
        {
            var query = _databaseContext.Prijedlozi.AsQueryable();

            if (search != null)
            {
                if (!string.IsNullOrEmpty(search.Naziv))
                {
                    query = query.Where(x => x.Naziv.ToLower().Contains(search.Naziv.ToLower()));
                }

                if (!string.IsNullOrEmpty(search.Autor))
                {
                    query = query.Where(x => x.Autor.ToLower().Contains(search.Autor.ToLower()));
                }

                if (search.KorisnikId != null)
                {
                    query = query.Where(x => x.KorisnikId == search.KorisnikId);
                }
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Prijedlozi>>(list);
        }
    }
}
