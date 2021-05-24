using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using myBooks.API.Services;
using myBooks.Model.Requests;

namespace myBooks.API.Controllers
{
    public class JeziciController : BaseCrudController<Model.Jezici, JeziciSearchRequest, JeziciUpsertRequest, JeziciUpsertRequest>
    {
        public JeziciController(IBaseCrudService<Model.Jezici, JeziciSearchRequest, JeziciUpsertRequest, JeziciUpsertRequest> service) : base(service)
        {

        }

        [HttpGet]
        [Authorize(Roles = "Administrator,Korisnik")]
        public override ActionResult<List<Model.Jezici>> Get([FromQuery] JeziciSearchRequest search)
        {
            return base.Get(search);
        }
    }
}