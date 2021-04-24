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
    public class PrijedloziViewModel : BaseViewModel
    {
        private readonly ApiService _prijedloziService = new ApiService("Prijedlozi");

        public ICommand BindCommand { get; set; }

        public ObservableCollection<Prijedlozi> Prijedlozi { get; set; } = new ObservableCollection<Prijedlozi>();

        public PrijedloziViewModel()
        {
            BindCommand = new Command(async () => await Bind());
        }

        public async Task Bind()
        {
            var prijedlozi = await _prijedloziService.Get<List<Prijedlozi>>(new PrijedloziSearchRequest
            {
                Naziv = string.IsNullOrEmpty(Naziv) ? null : Naziv,
                Autor = string.IsNullOrEmpty(Autor) ? null : Autor,
                KorisnikId = Memorija.PrijavljeniKorisnik.KorisnikId
            });

            Prijedlozi.Clear();

            foreach (var prijedlog in prijedlozi)
            {
                Prijedlozi.Add(prijedlog);
            }

            IsEmpty = !prijedlozi.Any();
        }

        public async Task Obrisi(Prijedlozi polica)
        {
            await _prijedloziService.Delete<Prijedlozi>(polica.PrijedlogId);
        }

        string _naziv = string.Empty;
        public string Naziv
        {
            get => _naziv;
            set => SetProperty(ref _naziv, value);
        }

        string _autor = string.Empty;
        public string Autor
        {
            get => _autor;
            set => SetProperty(ref _autor, value);
        }
    }
}
