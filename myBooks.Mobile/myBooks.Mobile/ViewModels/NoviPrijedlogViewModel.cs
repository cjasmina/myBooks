using System;
using System.Threading.Tasks;

using myBooks.Model;
using myBooks.Model.Requests;

namespace myBooks.Mobile.ViewModels
{
    public class NoviPrijedlogViewModel : BaseViewModel
    {
        private readonly ApiService _apiService = new ApiService("Prijedlozi");

        public async Task<Prijedlozi> Kreiraj()
        {
            IsBusy = true;

            return await _apiService.Insert<Prijedlozi>(new PrijedloziInsertRequest
            {
                KorisnikId = Memorija.PrijavljeniKorisnik.KorisnikId,
                Naziv = _naziv,
                Autor = _autor,
                Datum = DateTime.Now
            });
        }

        private string _naziv = string.Empty;
        public string Naziv
        {
            get => _naziv;
            set => SetProperty(ref _naziv, value);
        }

        private string _autor = string.Empty;
        public string Autor
        {
            get => _autor;
            set => SetProperty(ref _autor, value);
        }
    }
}
