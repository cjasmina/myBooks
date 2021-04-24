using myBooks.API.Services;
using myBooks.Model.Requests;

namespace myBooks.API.Controllers
{
    public class DrzaveController : BaseCrudController<Model.Drzave, DrzaveSearchRequest, DrzaveUpsertRequest, DrzaveUpsertRequest>
    {
        public DrzaveController(IBaseCrudService<Model.Drzave, DrzaveSearchRequest, DrzaveUpsertRequest, DrzaveUpsertRequest> service) : base(service)
        {

        }
    }
}