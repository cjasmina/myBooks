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
    public class NovaPolicaViewModel : BaseViewModel
    {
        private readonly ApiService _apiService = new ApiService("Police");

        public NovaPolicaViewModel()
        {

        }

        public NovaPolicaViewModel(DateTime minDateTime)
        {
            KrajnjiDatumCilja = minDateTime;
        }

        public async Task<Police> Kreiraj()
        {
            IsBusy = true;

            return await _apiService.Insert<Police>(new PoliceInsertRequest
            {
                KorisnikId = Memorija.PrijavljeniKorisnik.KorisnikId,
                Naziv = _naziv,
                Datum = DateTime.Now,
                CiljniBroj = CiljniBroj,
                KrajnjiDatumCilja = CiljniBroj == null ? null : KrajnjiDatumCilja
            });
        }

        private string _naziv = string.Empty;
        public string Naziv
        {
            get => _naziv;
            set => SetProperty(ref _naziv, value);
        }

        private int? _ciljniBroj;
        public int? CiljniBroj
        {
            get => _ciljniBroj;
            set => SetProperty(ref _ciljniBroj, value);
        }

        private DateTime? _krajnjiDatumCilja;

        public DateTime? KrajnjiDatumCilja
        {
            get => _krajnjiDatumCilja;
            set => SetProperty(ref _krajnjiDatumCilja, value);
        }
    }
}
