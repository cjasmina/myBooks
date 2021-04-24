using System.Linq;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

using AutoMapper;

using myBooks.API.Database;
using myBooks.Model.Requests;

namespace myBooks.API.Services
{
    public class RecenzijeService : BaseCrudService<Model.Recenzije, Database.Recenzije, RecenzijeSearchRequest, RecenzijeInsertRequest, RecenzijeInsertRequest>
    {
        public RecenzijeService(myBooksContext database, IMapper mapper) : base(database, mapper)
        {
        }

        public override List<Model.Recenzije> Get(RecenzijeSearchRequest search)
        {
            var query = _databaseContext.Recenzije.Include(r => r.Korisnik).AsQueryable();

            if (search != null)
            {
                if (!string.IsNullOrEmpty(search.Sadrzaj))
                {
                    query = query.Where(x => x.Sadrzaj.ToLower().Contains(search.Sadrzaj.ToLower()));
                }

                if (search.KorisnikId != null)
                {
                    query = query.Where(x => x.KorisnikId == search.KorisnikId);
                }

                if (search.KnjigaId != null)
                {
                    query = query.Where(x => x.KnjigaId == search.KnjigaId);
                }
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Recenzije>>(list);
        }
    }
}
