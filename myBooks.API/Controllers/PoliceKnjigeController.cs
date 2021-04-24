using Microsoft.AspNetCore.Mvc;

using myBooks.API.Services;
using myBooks.Model.Requests;

namespace myBooks.API.Controllers
{
    public class PoliceKnjigeController : BaseCrudController<Model.PoliceKnjige, PoliceKnjigeSearchRequest, PoliceKnjigeUpsertRequest, PoliceKnjigeUpsertRequest>
    {
        public PoliceKnjigeController(IBaseCrudService<Model.PoliceKnjige, PoliceKnjigeSearchRequest, PoliceKnjigeUpsertRequest, PoliceKnjigeUpsertRequest> service) : base(service)
        {

        }


        [HttpDelete]
        public void Delete([FromQuery] PoliceKnjigeDeleteRequest request)
        {
            (Service as PoliceKnjigeService).DeleteByRequest(request);
        }
    }
}