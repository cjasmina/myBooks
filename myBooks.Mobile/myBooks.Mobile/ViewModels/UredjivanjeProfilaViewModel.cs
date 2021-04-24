using System;
using System.Text;
using System.Windows.Input;
using System.Threading.Tasks;

using myBooks.Model;
using myBooks.Model.Requests;

namespace myBooks.Mobile.ViewModels
{
    public class UredjivanjeProfilaViewModel : BaseViewModel
    {
        private readonly ApiService _service = new ApiService("Korisnici");

        public UredjivanjeProfilaViewModel()
        {
            Ime = Memorija.PrijavljeniKorisnik.Ime;
            Prezime = Memorija.PrijavljeniKorisnik.Prezime;
            DatumRodjenja = Memorija.PrijavljeniKorisnik.DatumRodjenja;
            Email = Memorija.PrijavljeniKorisnik.Email;
            Telefon = Memorija.PrijavljeniKorisnik.Telefon;
        }

        public async Task Uredi()
        {
            IsBusy = true;

            await _service.Update<Korisnici>(Memorija.PrijavljeniKorisnik.KorisnikId, new KorisniciUpsertRequest
            {
                Ime = _ime,
                Prezime = _prezime,
                DatumRodjenja = _datumRodjenja,
                Telefon = _telefon,
                Email = _email,
                Lozinka = _lozinka,
                KorisnickoIme = Memorija.PrijavljeniKorisnik.KorisnickoIme,
                Uloga = Uloge.Korisnik
            });

            IsBusy = false;
        }

        private string _ime = string.Empty;
        public string Ime
        {
            get => _ime;
            set => SetProperty(ref _ime, value);
        }

        private string _prezime = string.Empty;
        public string Prezime
        {
            get => _prezime;
            set => SetProperty(ref _prezime, value);
        }

        private DateTime _datumRodjenja = new DateTime(2020, 1, 1);
        public DateTime DatumRodjenja
        {
            get => _datumRodjenja;
            set => SetProperty(ref _datumRodjenja, value);
        }

        private string _email = string.Empty;
        public string Email
        {
            get => _email;
            set => SetProperty(ref _email, value);
        }

        private string _telefon = string.Empty;
        public string Telefon
        {
            get => _telefon;
            set => SetProperty(ref _telefon, value);
        }

        private string _lozinka = string.Empty;
        public string Lozinka
        {
            get => _lozinka;
            set => SetProperty(ref _lozinka, value);
        }

        private string _potvrdaLozinke = string.Empty;
        public string PotvrdaLozinke
        {
            get => _potvrdaLozinke;
            set => SetProperty(ref _potvrdaLozinke, value);
        }
    }
}
