using System.Linq;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;

using myBooks.Model;
using myBooks.Model.Requests;

namespace myBooks.Mobile.ViewModels
{
    public class PoliceViewModel : BaseViewModel
    {
        private readonly ApiService _policeService = new ApiService("Police");

        public ICommand BindCommand { get; set; }

        public ObservableCollection<PolicaViewModel> Police { get; set; } = new ObservableCollection<PolicaViewModel>();

        public PoliceViewModel()
        {
            BindCommand = new Command(async () => await Bind());
        }

        public async Task Bind()
        {
            var police = await _policeService.Get<List<Police>>(new PoliceSearchRequest
            {
                Naziv = string.IsNullOrEmpty(Naziv) ? null : Naziv,
                KorisnikId = Memorija.PrijavljeniKorisnik.KorisnikId
            });

            Police.Clear();

            foreach (var polica in police)
            {
                Police.Add(new PolicaViewModel(polica));
            }

            IsEmpty = !police.Any();
        }

        public async Task Obrisi(Police polica)
        {
            await _policeService.Delete<Police>(polica.PolicaId);
        }

        string _naziv = string.Empty;
        public string Naziv
        {
            get => _naziv;
            set => SetProperty(ref _naziv, value);
        }
    }
}
