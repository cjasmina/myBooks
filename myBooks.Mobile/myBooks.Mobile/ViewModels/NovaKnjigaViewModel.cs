using System.Windows.Input;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;

using myBooks.Model;
using myBooks.Model.Requests;
using System.Linq;

namespace myBooks.Mobile.ViewModels
{
    public class NovaKnjigaViewModel : BaseViewModel
    {
        private readonly ApiService _policeService = new ApiService("Police");
        private readonly ApiService _policeKnjigeService = new ApiService("PoliceKnjige");

        private readonly Knjige _knjiga;
        private PoliceKnjige _policeKnjige;

        public ICommand BindCommand { get; set; }

        public ObservableCollection<PolicaViewModel> Police { get; set; } = new ObservableCollection<PolicaViewModel>();

        public NovaKnjigaViewModel()
        {
            BindCommand = new Command(async () => await Bind());
        }

        public NovaKnjigaViewModel(Knjige knjiga)
        {
            _knjiga = knjiga;

            BindCommand = new Command(async () => await Bind());
        }

        public async Task Bind()
        {
            var police = await _policeService.Get<List<Police>>(new PoliceSearchRequest
            {
                Naziv = string.IsNullOrEmpty(Naziv) ? null : Naziv,
                KorisnikId = Memorija.PrijavljeniKorisnik.KorisnikId
            });

            _policeKnjige = (await _policeKnjigeService.Get<List<PoliceKnjige>>(new PoliceKnjigeSearchRequest
            {
                KnjigaId = _knjiga.KnjigaId,
                KorisnikId = Memorija.PrijavljeniKorisnik.KorisnikId
            })).FirstOrDefault();

            if(_policeKnjige != null)
            {
                police.RemoveAll(p => p.PolicaId == _policeKnjige.PolicaId);
            }

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

        public async Task Odaberi(Police polica)
        {
            if(_policeKnjige != null)
            {
                await _policeKnjigeService.Update<PoliceKnjige>(_policeKnjige.PolicaKnjigaId, new PoliceKnjigeUpsertRequest
                {
                    PolicaId = polica.PolicaId,
                    KnjigaId = _knjiga.KnjigaId,
                    Procitano = _policeKnjige.Procitano
                });
            }
            else
            {
                await _policeKnjigeService.Insert<PoliceKnjige>(new PoliceKnjigeUpsertRequest
                {
                    PolicaId = polica.PolicaId,
                    KnjigaId = _knjiga.KnjigaId,
                    Procitano = false
                });
            }
        }

        string _naziv = string.Empty;
        public string Naziv
        {
            get => _naziv;
            set => SetProperty(ref _naziv, value);
        }
    }
}
