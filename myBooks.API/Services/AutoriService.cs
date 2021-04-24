using System.Linq;
using System.Collections.Generic;

using AutoMapper;

using myBooks.API.Database;
using myBooks.Model.Requests;

namespace myBooks.API.Services
{
    public class AutoriService : BaseCrudService<Model.Autori, Database.Autori, AutoriSearchRequest, AutoriUpsertRequest, AutoriUpsertRequest>
    {
        public AutoriService(myBooksContext database, IMapper mapper) : base(database, mapper)
        {
        }

        public override List<Model.Autori> Get(AutoriSearchRequest search)
        {
            var query = _databaseContext.Autori.AsQueryable();

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
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Autori>>(list);
        }
    }
}
