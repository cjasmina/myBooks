using myBooks.API.Services;
using myBooks.Model.Requests;

namespace myBooks.API.Controllers
{
    public class OcjeneController : BaseCrudController<Model.Ocjene, OcjeneSearchRequest, OcjeneInsertRequest, OcjeneInsertRequest>
    {
        public OcjeneController(IBaseCrudService<Model.Ocjene, OcjeneSearchRequest, OcjeneInsertRequest, OcjeneInsertRequest> service) : base(service)
        {

        }
    }
}