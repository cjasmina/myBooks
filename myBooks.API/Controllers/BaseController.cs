using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using myBooks.API.Services;

namespace myBooks.API.Controllers
{
    [Authorize]
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
        public ActionResult<List<T>> Get([FromQuery] TSearch search)
        {
            return Service.Get(search);
        }

        [HttpGet("{id}")]
        public ActionResult<T> GetById(int id)
        {
            return Service.GetById(id);
        }
    }
}
