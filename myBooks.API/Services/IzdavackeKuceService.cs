using System.Linq;
using System.Collections.Generic;

using AutoMapper;

using myBooks.API.Database;
using myBooks.Model.Requests;

namespace myBooks.API.Services
{
    public class IzdavackeKuceService : BaseCrudService<Model.IzdavackeKuce, Database.IzdavackeKuce, IzdavackeKuceSearchRequest, IzdavackeKuceInsertRequest, IzdavackeKuceInsertRequest>
    {
        public IzdavackeKuceService(myBooksContext database, IMapper mapper) : base(database, mapper)
        {
        }

        public override List<Model.IzdavackeKuce> Get(IzdavackeKuceSearchRequest search)
        {
            var query = _databaseContext.IzdavackeKuce.AsQueryable();

            if(search != null)
            {
                if (!string.IsNullOrEmpty(search.Naziv))
                {
                    query = query.Where(x => x.Naziv.ToLower().Contains(search.Naziv.ToLower()));
                }

                if(search.GradId != null)
                {
                    query = query.Where(x => x.GradId == search.GradId);
                }
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.IzdavackeKuce>>(list);
        }
    }
}
