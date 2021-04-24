using myBooks.API.Services;
using myBooks.Model.Requests;

namespace myBooks.API.Controllers
{
    public class PoliceController : BaseCrudController<Model.Police, PoliceSearchRequest, PoliceInsertRequest, PoliceInsertRequest>
    {
        public PoliceController(IBaseCrudService<Model.Police, PoliceSearchRequest, PoliceInsertRequest, PoliceInsertRequest> service) : base(service)
        {

        }
    }
}