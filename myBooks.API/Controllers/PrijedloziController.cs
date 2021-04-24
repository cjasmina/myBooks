using myBooks.API.Services;
using myBooks.Model.Requests;

namespace myBooks.API.Controllers
{
    public class PrijedloziController : BaseCrudController<Model.Prijedlozi, PrijedloziSearchRequest, PrijedloziInsertRequest, PrijedloziInsertRequest>
    {
        public PrijedloziController(IBaseCrudService<Model.Prijedlozi, PrijedloziSearchRequest, PrijedloziInsertRequest, PrijedloziInsertRequest> service) : base(service)
        {

        }
    }
}