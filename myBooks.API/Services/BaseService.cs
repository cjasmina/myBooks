using System.Linq;
using System.Collections.Generic;

using AutoMapper;

using myBooks.API.Database;

namespace myBooks.API.Services
{
    public class BaseService<TModel, TDatabase, TSearch> : IBaseService<TModel, TSearch> where TDatabase : class
    {
        protected readonly myBooksContext _databaseContext;
        protected readonly IMapper _mapper;

        public BaseService(myBooksContext databaseContext, IMapper mapper)
        {
            _databaseContext = databaseContext;
            _mapper = mapper;
        }

        public virtual List<TModel> Get(TSearch search)
        {
            var list = _databaseContext.Set<TDatabase>().ToList();

            return _mapper.Map<List<TModel>>(list);
        }

        public virtual TModel GetById(int id)
        {
            var entity = _databaseContext.Set<TDatabase>().Find(id);

            return _mapper.Map<TModel>(entity);
        }
    }
}
