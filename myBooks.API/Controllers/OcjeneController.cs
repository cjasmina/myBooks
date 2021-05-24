using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using myBooks.API.Services;
using myBooks.Model.Requests;

namespace myBooks.API.Controllers
{
    public class OcjeneController : BaseCrudController<Model.Ocjene, OcjeneSearchRequest, OcjeneInsertRequest, OcjeneInsertRequest>
    {
        public OcjeneController(IBaseCrudService<Model.Ocjene, OcjeneSearchRequest, OcjeneInsertRequest, OcjeneInsertRequest> service) : base(service)
        {

        }

        [HttpGet]
        [Authorize(Roles = "Administrator,Korisnik")]
        public override ActionResult<List<Model.Ocjene>> Get([FromQuery] OcjeneSearchRequest search)
        {
            return base.Get(search);
        }

        [HttpPost]
        [Authorize(Roles = "Administrator,Korisnik")]
        public override Model.Ocjene Insert(OcjeneInsertRequest request)
        {
            return base.Insert(request);
        }
    }
}