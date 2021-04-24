using myBooks.API.Services;
using myBooks.Model.Requests;

namespace myBooks.API.Controllers
{
    public class GradoviController : BaseCrudController<Model.Gradovi, GradoviSearchRequest, GradoviUpsertRequest, GradoviUpsertRequest>
    {
        public GradoviController(IBaseCrudService<Model.Gradovi, GradoviSearchRequest, GradoviUpsertRequest, GradoviUpsertRequest> service) : base(service)
        {

        }
    }
}