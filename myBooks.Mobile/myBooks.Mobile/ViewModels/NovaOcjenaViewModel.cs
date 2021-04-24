using System.Threading.Tasks;

using myBooks.Model;
using myBooks.Model.Requests;

namespace myBooks.Mobile.ViewModels
{
    public class NovaOcjenaViewModel : BaseViewModel
    {
        private readonly ApiService _apiService = new ApiService("Ocjene");

        public async Task<Ocjene> Ocijeni(Knjige knjiga, int ocjena)
        {
            IsBusy = true;

            return await _apiService.Insert<Ocjene>(new OcjeneInsertRequest
            {
                KorisnikId = Memorija.PrijavljeniKorisnik.KorisnikId,
                KnjigaId = knjiga.KnjigaId,
                Ocjena = ocjena
            });
        }
    }
}
