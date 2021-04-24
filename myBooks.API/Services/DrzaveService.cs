using System.Linq;
using System.Collections.Generic;

using AutoMapper;

using myBooks.API.Database;
using myBooks.Model.Requests;

namespace myBooks.API.Services
{
    public class DrzaveService : BaseCrudService<Model.Drzave, Database.Drzave, DrzaveSearchRequest, DrzaveUpsertRequest, DrzaveUpsertRequest>
    {
        public DrzaveService(myBooksContext database, IMapper mapper) : base(database, mapper)
        {
        }

        public override List<Model.Drzave> Get(DrzaveSearchRequest search)
        {
            var query = _databaseContext.Drzave.AsQueryable();

            if(search != null)
            {
                if (!string.IsNullOrEmpty(search.Naziv))
                {
                    query = query.Where(x => x.Naziv.ToLower().Contains(search.Naziv.ToLower()));
                }
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Drzave>>(list);
        }
    }
}
