using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using myBooks.API.Database;
using myBooks.API.Services;
using myBooks.Model.Requests;

namespace myBooks.API.Controllers
{
    public class KorisniciController : BaseCrudController<Model.Korisnici, KorisniciSearchRequest, KorisniciUpsertRequest, KorisniciUpsertRequest>
    {
        public KorisniciController(IBaseCrudService<Model.Korisnici, KorisniciSearchRequest, KorisniciUpsertRequest, KorisniciUpsertRequest> service) : base(service)
        {

        }

        [Authorize]
        [HttpGet("Prijava")]
        public ActionResult<Korisnici> GetPrijavljeniKorisnik([FromQuery] KorisniciPrijavaRequest request)
        {
            return (Service as KorisniciService).GetPrijavljeniKorisnik(request);
        }

        [HttpPost]
        [AllowAnonymous]
        public new Model.Korisnici Insert(KorisniciUpsertRequest request)
        {
            return Service.Insert(request);
        }
    }
}