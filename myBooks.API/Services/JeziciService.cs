using System.Linq;
using System.Collections.Generic;

using AutoMapper;

using myBooks.API.Database;
using myBooks.Model.Requests;

namespace myBooks.API.Services
{
    public class JeziciService : BaseCrudService<Model.Jezici, Database.Jezici, JeziciSearchRequest, JeziciUpsertRequest, JeziciUpsertRequest>
    {
        public JeziciService(myBooksContext database, IMapper mapper) : base(database, mapper)
        {
        }

        public override List<Model.Jezici> Get(JeziciSearchRequest search)
        {
            var query = _databaseContext.Jezici.AsQueryable();

            if (search != null)
            {
                if (!string.IsNullOrEmpty(search.Naziv))
                {
                    query = query.Where(x => x.Naziv.ToLower().Contains(search.Naziv.ToLower()));
                }
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Jezici>>(list);
        }
    }
}
