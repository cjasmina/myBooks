using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using myBooks.API.Services;
using myBooks.Model.Requests;

namespace myBooks.API.Controllers
{
    [AllowAnonymous]
    public class AutoriController : BaseCrudController<Model.Autori, AutoriSearchRequest, AutoriUpsertRequest, AutoriUpsertRequest>
    {
        public AutoriController(IBaseCrudService<Model.Autori, AutoriSearchRequest, AutoriUpsertRequest, AutoriUpsertRequest> service) : base(service)
        {

        }

        [HttpGet]
        [Authorize(Roles = "Administrator,Korisnik")]
        public override ActionResult<List<Model.Autori>> Get([FromQuery] AutoriSearchRequest search)
        {
            return base.Get(search);
        }
    }
}