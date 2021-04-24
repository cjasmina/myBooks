using myBooks.API.Services;
using myBooks.Model.Requests;

namespace myBooks.API.Controllers
{
    public class RecenzijeController : BaseCrudController<Model.Recenzije, RecenzijeSearchRequest, RecenzijeInsertRequest, RecenzijeInsertRequest>
    {
        public RecenzijeController(IBaseCrudService<Model.Recenzije, RecenzijeSearchRequest, RecenzijeInsertRequest, RecenzijeInsertRequest> service) : base(service)
        {

        }
    }
}