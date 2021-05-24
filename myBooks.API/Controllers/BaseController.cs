using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using myBooks.API.Services;

namespace myBooks.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController<T, TSearch> : ControllerBase
    {
        protected readonly IBaseService<T, TSearch> Service;

        public BaseController(IBaseService<T, TSearch> service)
        {
            Service = service;
        }

        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public virtual ActionResult<List<T>> Get([FromQuery] TSearch search)
        {
            return Service.Get(search);
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Administrator")]
        public virtual ActionResult<T> GetById(int id)
        {
            return Service.GetById(id);
        }
    }
}
