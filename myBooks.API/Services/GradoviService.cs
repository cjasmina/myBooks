using System.Linq;
using System.Collections.Generic;

using AutoMapper;

using myBooks.API.Database;
using myBooks.Model.Requests;

namespace myBooks.API.Services
{
    public class GradoviService : BaseCrudService<Model.Gradovi, Database.Gradovi, GradoviSearchRequest, GradoviUpsertRequest, GradoviUpsertRequest>
    {
        public GradoviService(myBooksContext database, IMapper mapper) : base(database, mapper)
        {
        }

        public override List<Model.Gradovi> Get(GradoviSearchRequest search)
        {
            var query = _databaseContext.Gradovi.AsQueryable();

            if(search != null)
            {
                if (!string.IsNullOrEmpty(search.Naziv))
                {
                    query = query.Where(x => x.Naziv.ToLower().Contains(search.Naziv.ToLower()));
                }

                if(search.DrzavaId != null)
                {
                    query = query.Where(x => x.DrzavaId == search.DrzavaId);
                }
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Gradovi>>(list);
        }
    }
}
