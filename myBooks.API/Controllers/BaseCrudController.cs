using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using myBooks.API.Services;

namespace myBooks.API.Controllers
{
    public class BaseCrudController<T, TSearch, TInsert, TUpdate> : BaseController<T, TSearch>
    {
        protected new readonly IBaseCrudService<T, TSearch, TInsert, TUpdate> Service;

        public BaseCrudController(IBaseCrudService<T, TSearch, TInsert, TUpdate> service) : base(service)
        {
            Service = service;
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public virtual T Insert(TInsert request)
        {
            return Service.Insert(request);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Administrator")]
        public virtual T Update(int id, TUpdate request)
        {
            return Service.Update(id, request);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Administrator")]
        public virtual void Delete(int id)
        {
            Service.Delete(id);
        }
    }
}
