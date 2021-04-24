using myBooks.API.Services;
using myBooks.Model.Requests;

namespace myBooks.API.Controllers
{
    public class IzdavackeKuceController : BaseCrudController<Model.IzdavackeKuce, IzdavackeKuceSearchRequest, IzdavackeKuceInsertRequest, IzdavackeKuceInsertRequest>
    {
        public IzdavackeKuceController(IBaseCrudService<Model.IzdavackeKuce, IzdavackeKuceSearchRequest, IzdavackeKuceInsertRequest, IzdavackeKuceInsertRequest> service) : base(service)
        {

        }
    }
}