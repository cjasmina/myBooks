using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using myBooks.API.Services;
using myBooks.Model.Requests;

namespace myBooks.API.Controllers
{
    public class KnjigeController : BaseCrudController<Model.Knjige, KnjigeSearchRequest, KnjigeUpsertRequest, KnjigeUpsertRequest>
    {
        public KnjigeController(IBaseCrudService<Model.Knjige, KnjigeSearchRequest, KnjigeUpsertRequest, KnjigeUpsertRequest> service) : base(service)
        {

        }

        [HttpGet]
        [Authorize(Roles = "Administrator,Korisnik")]
        public override ActionResult<List<Model.Knjige>> Get([FromQuery] KnjigeSearchRequest search)
        {
            return base.Get(search);
        }

        [HttpGet("PreporuciKnjige")]
        [Authorize(Roles = "Administrator,Korisnik")]
        public List<Model.Knjige> PreporuciKnjige([FromQuery] KnjigeSearchRequest search)
        {
            return (Service as KnjigeService).PreporuciKnjige(search);
        }
    }
}