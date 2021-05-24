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
    public class DetaljiPoliceViewModel : BaseViewModel
    {
        private readonly Police _polica;
        private readonly ApiService _knjigeService = new ApiService("Knjige");
        private readonly ApiService _policeKnjigeService = new ApiService("PoliceKnjige");

        public ICommand BindCommand { get; set; }

        public ObservableCollection<Knjige> Knjige { get; set; } = new ObservableCollection<Knjige>();

        public DetaljiPoliceViewModel(Police polica)
        {
            _polica = polica;
            BindCommand = new Command(async () => await Bind());
        }

        public async Task Bind()
        {
            var knjige = await _knjigeService.Get<List<Knjige>>(new KnjigeSearchRequest
            {
                PolicaId = _polica.PolicaId
            });

            Knjige.Clear();

            foreach (var knjiga in knjige)
            {
                Knjige.Add(knjiga);
            }

            IsEmpty = !knjige.Any();
        }

        public async Task Obrisi(Knjige knjiga)
        {
            await _policeKnjigeService.DeleteWithRequest<PoliceKnjige>(new PoliceKnjigeDeleteRequest
            {
                KnjigaId = knjiga.KnjigaId,
                PolicaId = _polica.PolicaId
            });
        }
    }
}
