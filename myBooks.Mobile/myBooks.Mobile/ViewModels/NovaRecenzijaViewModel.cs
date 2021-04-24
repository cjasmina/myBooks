using System;
using System.Threading.Tasks;

using myBooks.Model;
using myBooks.Model.Requests;

namespace myBooks.Mobile.ViewModels
{
    public class NovaRecenzijaViewModel : BaseViewModel
    {
        private readonly ApiService _apiService = new ApiService("Recenzije");

        public async Task<Recenzije> Kreiraj(Knjige knjiga)
        {
            IsBusy = true;

            return await _apiService.Insert<Recenzije>(new RecenzijeInsertRequest
            {
                KorisnikId = Memorija.PrijavljeniKorisnik.KorisnikId,
                KnjigaId = knjiga.KnjigaId,
                Sadrzaj = _sadrzaj,
                DatumObjave = DateTime.Now
            });
        }

        private string _sadrzaj = string.Empty;
        public string Sadrzaj
        {
            get => _sadrzaj;
            set => SetProperty(ref _sadrzaj, value);
        }
    }
}
