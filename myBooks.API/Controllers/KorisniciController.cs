using System.Linq;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using myBooks.API.Services;
using myBooks.Model.Requests;

namespace myBooks.API.Controllers
{
    public class KorisniciController : BaseCrudController<Model.Korisnici, KorisniciSearchRequest, KorisniciUpsertRequest, KorisniciUpsertRequest>
    {
        public KorisniciController(IBaseCrudService<Model.Korisnici, KorisniciSearchRequest, KorisniciUpsertRequest, KorisniciUpsertRequest> service) : base(service)
        {

        }

        [HttpGet("Prijava")]
        [Authorize(Roles = "Administrator,Korisnik")]
        public ActionResult<Model.Korisnici> GetPrijavljeniKorisnik()
        {
            return Ok((Service as KorisniciService).GetById(int.Parse(User.Claims.First(c => c.Type == "Id").Value)));
        }

        [HttpPost]
        public new Model.Korisnici Insert(KorisniciUpsertRequest request)
        {
            return Service.Insert(request);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Administrator,Korisnik")]
        public override Model.Korisnici Update(int id, KorisniciUpsertRequest request)
        {
            return base.Update(id, request);
        }
    }
}