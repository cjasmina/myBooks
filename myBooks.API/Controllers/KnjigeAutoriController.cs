using myBooks.API.Services;
using myBooks.Model.Requests;

namespace myBooks.API.Controllers
{
    public class KnjigeAutoriController : BaseCrudController<Model.KnjigeAutori, KnjigeAutoriSearchRequest, KnjigeAutoriInsertRequest, KnjigeAutoriInsertRequest>
    {
        public KnjigeAutoriController(IBaseCrudService<Model.KnjigeAutori, KnjigeAutoriSearchRequest, KnjigeAutoriInsertRequest, KnjigeAutoriInsertRequest> service) : base(service)
        {

        }
    }
}