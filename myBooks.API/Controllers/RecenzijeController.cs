using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using myBooks.API.Services;
using myBooks.Model.Requests;

namespace myBooks.API.Controllers
{
    public class RecenzijeController : BaseCrudController<Model.Recenzije, RecenzijeSearchRequest, RecenzijeInsertRequest, RecenzijeInsertRequest>
    {
        public RecenzijeController(IBaseCrudService<Model.Recenzije, RecenzijeSearchRequest, RecenzijeInsertRequest, RecenzijeInsertRequest> service) : base(service)
        {

        }

        [HttpGet]
        [Authorize(Roles = "Administrator,Korisnik")]
        public override ActionResult<List<Model.Recenzije>> Get([FromQuery] RecenzijeSearchRequest search)
        {
            return base.Get(search);
        }

        [HttpPost]
        [Authorize(Roles = "Administrator,Korisnik")]
        public override Model.Recenzije Insert(RecenzijeInsertRequest request)
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