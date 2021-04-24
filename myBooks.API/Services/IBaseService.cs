using System.Collections.Generic;

namespace myBooks.API.Services
{
    public interface IBaseService<TModel, TSearch>
    {
        TModel GetById(int id);

        List<TModel> Get(TSearch search);
    }
}
