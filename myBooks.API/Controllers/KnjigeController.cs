using Microsoft.AspNetCore.Mvc;
using myBooks.API.Services;
using myBooks.Model.Requests;
using System.Collections.Generic;

namespace myBooks.API.Controllers
{
    public class KnjigeController : BaseCrudController<Model.Knjige, KnjigeSearchRequest, KnjigeUpsertRequest, KnjigeUpsertRequest>
    {
        public KnjigeController(IBaseCrudService<Model.Knjige, KnjigeSearchRequest, KnjigeUpsertRequest, KnjigeUpsertRequest> service) : base(service)
        {

        }

        [HttpGet("PreporuciKnjige")]
        public List<Model.Knjige> PreporuciKnjige([FromQuery] KnjigeSearchRequest search)
        {
            return (Service as KnjigeService).PreporuciKnjige(search);
        }
    }
}