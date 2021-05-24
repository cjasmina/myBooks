using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using myBooks.API.Services;
using myBooks.Model.Requests;

namespace myBooks.API.Controllers
{
    public class ZanroviController : BaseCrudController<Model.Zanrovi, ZanroviSearchRequest, ZanroviInsertRequest, ZanroviInsertRequest>
    {
        public ZanroviController(IBaseCrudService<Model.Zanrovi, ZanroviSearchRequest, ZanroviInsertRequest, ZanroviInsertRequest> service) : base(service)
        {

        }

        [HttpGet]
        [Authorize(Roles = "Administrator,Korisnik")]
        public override ActionResult<List<Model.Zanrovi>> Get([FromQuery] ZanroviSearchRequest search)
        {
            return base.Get(search);
        }
    }
}