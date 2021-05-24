using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using myBooks.API.Services;
using myBooks.Model.Requests;

namespace myBooks.API.Controllers
{
    public class PoliceController : BaseCrudController<Model.Police, PoliceSearchRequest, PoliceInsertRequest, PoliceInsertRequest>
    {
        public PoliceController(IBaseCrudService<Model.Police, PoliceSearchRequest, PoliceInsertRequest, PoliceInsertRequest> service) : base(service)
        {

        }

        [HttpGet]
        [Authorize(Roles = "Administrator,Korisnik")]
        public override ActionResult<List<Model.Police>> Get([FromQuery] PoliceSearchRequest search)
        {
            return base.Get(search);
        }

        [HttpPost]
        [Authorize(Roles = "Administrator,Korisnik")]
        public override Model.Police Insert(PoliceInsertRequest request)
        {
            return base.Insert(request);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Administrator,Korisnik")]
        public override void Delete(int id)
        {
            base.Delete(id);
        }
    }
}