using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using AutoMapper;

using myBooks.Model;
using myBooks.API.Helpers;
using myBooks.API.Database;
using System;

namespace myBooks.API.Services
{
    public interface IPrijavaService
    {
        Task<PrijavljeniKorisnik> Autentificiraj(string korisnickoIme, string lozinka);
    }

    public class PrijavaService : IPrijavaService
    {
        private readonly IMapper _mapper;
        private readonly myBooksContext _databaseContext;

        public PrijavaService(myBooksContext databaseContext, IMapper mapper)
        {
            _databaseContext = databaseContext;
            _mapper = mapper;
        }

        public async Task<PrijavljeniKorisnik> Autentificiraj(string korisnickoIme, string lozinka)
        {
            try
            {
                var korisnik = await _databaseContext.Korisnici.Where(x => x.KorisnickoIme == korisnickoIme).FirstOrDefaultAsync();
                if (korisnik == null)
                    return null;

                var lozinkaHash = Helpers.Security.GenerateHash(korisnik.LozinkaSalt, lozinka);
                if (lozinkaHash != korisnik.LozinkaHash)
                    return null;

                return _mapper.Map<PrijavljeniKorisnik>(korisnik);
            }
            catch(Exception e)
            {
                return null;
            }
        }
    }
}
