using System.Linq;
using System.Collections.Generic;

using AutoMapper;

using myBooks.API.Database;
using myBooks.Model.Requests;

namespace myBooks.API.Services
{
    public class ZanroviService : BaseCrudService<Model.Zanrovi, Database.Zanrovi, ZanroviSearchRequest, ZanroviInsertRequest, ZanroviInsertRequest>
    {
        public ZanroviService(myBooksContext database, IMapper mapper) : base(database, mapper)
        {
        }

        public override List<Model.Zanrovi> Get(ZanroviSearchRequest search)
        {
            var query = _databaseContext.Zanrovi.AsQueryable();

            if (search != null)
            {
                if (!string.IsNullOrEmpty(search.Naziv))
                {
                    query = query.Where(x => x.Naziv.ToLower().Contains(search.Naziv.ToLower()));
                }
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Zanrovi>>(list);
        }
    }
}
