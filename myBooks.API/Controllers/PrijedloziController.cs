using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using myBooks.API.Services;
using myBooks.Model.Requests;

namespace myBooks.API.Controllers
{
    public class PrijedloziController : BaseCrudController<Model.Prijedlozi, PrijedloziSearchRequest, PrijedloziInsertRequest, PrijedloziInsertRequest>
    {
        public PrijedloziController(IBaseCrudService<Model.Prijedlozi, PrijedloziSearchRequest, PrijedloziInsertRequest, PrijedloziInsertRequest> service) : base(service)
        {

        }

        [HttpGet]
        [Authorize(Roles = "Administrator,Korisnik")]
        public override ActionResult<List<Model.Prijedlozi>> Get([FromQuery] PrijedloziSearchRequest search)
        {
            return base.Get(search);
        }

        [HttpPost]
        [Authorize(Roles = "Administrator,Korisnik")]
        public override Model.Prijedlozi Insert(PrijedloziInsertRequest request)
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