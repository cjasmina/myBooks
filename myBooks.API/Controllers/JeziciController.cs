using myBooks.API.Services;
using myBooks.Model.Requests;

namespace myBooks.API.Controllers
{
    public class JeziciController : BaseCrudController<Model.Jezici, JeziciSearchRequest, JeziciUpsertRequest, JeziciUpsertRequest>
    {
        public JeziciController(IBaseCrudService<Model.Jezici, JeziciSearchRequest, JeziciUpsertRequest, JeziciUpsertRequest> service) : base(service)
        {

        }
    }
}