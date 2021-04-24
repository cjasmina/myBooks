using System.Linq;
using System.Collections.Generic;

using AutoMapper;

using myBooks.API.Database;
using myBooks.Model.Requests;

namespace myBooks.API.Services
{
    public class KnjigeAutoriService : BaseCrudService<Model.KnjigeAutori, Database.KnjigeAutori, KnjigeAutoriSearchRequest, KnjigeAutoriInsertRequest, KnjigeAutoriInsertRequest>
    {
        public KnjigeAutoriService(myBooksContext database, IMapper mapper) : base(database, mapper)
        {
        }

        public override List<Model.KnjigeAutori> Get(KnjigeAutoriSearchRequest search)
        {
            var query = _databaseContext.KnjigeAutori.AsQueryable();

            if (search != null)
            {
                if (search.AutorId != null)
                {
                    query = query.Where(x => x.AutorId == search.AutorId);
                }

                if (search.KnjigaId != null)
                {
                    query = query.Where(x => x.KnjigaId == search.KnjigaId);
                }
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.KnjigeAutori>>(list);
        }
    }
}
