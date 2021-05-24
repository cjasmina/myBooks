using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using myBooks.API.Services;
using myBooks.Model.Requests;

namespace myBooks.API.Controllers
{
    public class PoliceKnjigeController : BaseCrudController<Model.PoliceKnjige, PoliceKnjigeSearchRequest, PoliceKnjigeUpsertRequest, PoliceKnjigeUpsertRequest>
    {
        public PoliceKnjigeController(IBaseCrudService<Model.PoliceKnjige, PoliceKnjigeSearchRequest, PoliceKnjigeUpsertRequest, PoliceKnjigeUpsertRequest> service) : base(service)
        {

        }

        [HttpGet]
        [Authorize(Roles = "Administrator,Korisnik")]
        public override ActionResult<List<Model.PoliceKnjige>> Get([FromQuery] PoliceKnjigeSearchRequest search)
        {
            return base.Get(search);
        }

        [HttpPost]
        [Authorize(Roles = "Administrator,Korisnik")]
        public override Model.PoliceKnjige Insert(PoliceKnjigeUpsertRequest request)
        {
            return base.Insert(request);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Administrator,Korisnik")]
        public override Model.PoliceKnjige Update(int id, PoliceKnjigeUpsertRequest request)
        {
            return base.Update(id, request);
        }

        [HttpDelete]
        [Authorize(Roles = "Administrator,Korisnik")]
        public void Delete([FromQuery] PoliceKnjigeDeleteRequest request)
        {
            (Service as PoliceKnjigeService).DeleteByRequest(request);
        }
    }
}