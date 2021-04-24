namespace myBooks.API.Services
{
    public interface IBaseCrudService<T, TSearch, TInsert, TUpdate> : IBaseService<T, TSearch>
    {
        T Insert(TInsert request);

        T Update(int id, TUpdate request);

        void Delete(int id);
    }
}
