using System;
using System.Text;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Collections.Generic;

using Xamarin.Forms;

using myBooks.Model;
using myBooks.Model.Requests;
using myBooks.Mobile.Views;

namespace myBooks.Mobile.ViewModels
{
    public class PrijavaViewModel : BaseViewModel
    {
        private readonly ApiService _apiService = new ApiService("Korisnici");

        public ICommand PrijavaCommand { get; set; }

        public PrijavaViewModel()
        {
            PrijavaCommand = new Command(async () => await Prijava());
        }

        public Task<Korisnici> Prijava()
        {
            IsBusy = true;

            ApiService.KorisnickoIme = KorisnickoIme;
            ApiService.Lozinka = Lozinka;

            return _apiService.GetAction<Korisnici>("Prijava", new KorisniciPrijavaRequest
            {
                KorisnickoIme = KorisnickoIme,
                Uloga = Uloge.Korisnik
            });
        }

        private string _korisnickoIme = string.Empty;
        public string KorisnickoIme
        {
            get => _korisnickoIme;
            set => SetProperty(ref _korisnickoIme, value);
        }

        private string _lozinka = string.Empty;
        public string Lozinka
        {
            get => _lozinka;
            set => SetProperty(ref _lozinka, value);
        }
    }
}
