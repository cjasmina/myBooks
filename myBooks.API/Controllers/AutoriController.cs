using myBooks.API.Services;
using myBooks.Model.Requests;

namespace myBooks.API.Controllers
{
    public class AutoriController : BaseCrudController<Model.Autori, AutoriSearchRequest, AutoriUpsertRequest, AutoriUpsertRequest>
    {
        public AutoriController(IBaseCrudService<Model.Autori, AutoriSearchRequest, AutoriUpsertRequest, AutoriUpsertRequest> service) : base(service)
        {

        }
    }
}