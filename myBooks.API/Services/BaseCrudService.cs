using AutoMapper;

using myBooks.API.Database;

namespace myBooks.API.Services
{
    public class BaseCrudService<TModel, TDatabase, TSearch, TInsert, TUpdate> : BaseService<TModel, TDatabase, TSearch>, IBaseCrudService<TModel, TSearch, TInsert, TUpdate> where TDatabase : class
    {
        public BaseCrudService(myBooksContext databaseContext, IMapper mapper) : base(databaseContext, mapper)
        {
        }

        public virtual TModel Insert(TInsert request)
        {
            var entity = _mapper.Map<TDatabase>(request);
            _databaseContext.Add(entity);
            _databaseContext.SaveChanges();

            return _mapper.Map<TModel>(entity);
        }

        public virtual TModel Update(int id, TUpdate request)
        {
            var entity = _databaseContext.Set<TDatabase>().Find(id);
            _mapper.Map(request, entity);
            _databaseContext.Set<TDatabase>().Attach(entity);
            _databaseContext.Set<TDatabase>().Update(entity);
            _databaseContext.SaveChanges();

            return _mapper.Map<TModel>(entity);
        }

        public virtual void Delete(int id)
        {
            var entity = _databaseContext.Set<TDatabase>().Find(id);
            _databaseContext.Remove(entity);
            _databaseContext.SaveChanges();
        }
    }
}
