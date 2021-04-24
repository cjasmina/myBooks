using myBooks.Model;
using myBooks.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
namespace myBooks.Mobile.ViewModels
{
    public class KnjigeViewModel : BaseViewModel
    {
        private readonly ApiService _knjigeService = new ApiService("Knjige");
        private readonly ApiService _zanroviService = new ApiService("Zanrovi");
        private readonly ApiService _autoriService = new ApiService("Autori");
        private readonly ApiService _jeziciService = new ApiService("Jezici");

        public ICommand BindCommand { get; set; }
        public ICommand PretragaCommand { get; set; }

        public ObservableCollection<Knjige> Knjige { get; set; } = new ObservableCollection<Knjige>();
        public ObservableCollection<OdabirViewModel> Zanrovi { get; set; } = new ObservableCollection<OdabirViewModel>();
        public ObservableCollection<OdabirViewModel> Autori { get; set; } = new ObservableCollection<OdabirViewModel>();
        public ObservableCollection<OdabirViewModel> Jezici { get; set; } = new ObservableCollection<OdabirViewModel>();

        public KnjigeViewModel()
        {
            BindCommand = new Command(async () => await Bind());
        }

        public async Task Bind()
        {
            await BindZanrove();
            await BindAutore();
            await BindJezike();
            await BindKnjige();
        }

        public async Task BindZanrove()
        {
            if (!Zanrovi.Any())
            {
                var zanrovi = (await _zanroviService.Get<List<Zanrovi>>(null)).Select(z => new OdabirViewModel
                {
                    Id = z.ZanrId,
                    Naziv = z.Naziv
                }).ToList();

                Zanrovi.Insert(0, new OdabirViewModel
                {
                    Naziv = "Odaberite žanr"
                });

                OdabraniZanr = Zanrovi.First();

                foreach (var zanr in zanrovi)
                {
                    Zanrovi.Add(zanr);
                }
            }
        }

        public async Task BindAutore()
        {
            if (!Autori.Any())
            {
                var autori = (await _autoriService.Get<List<Autori>>(null)).Select(a => new OdabirViewModel
                {
                    Id = a.AutorId,
                    Naziv = $"{a.Ime} {a.Prezime}"
                }).ToList();

                Autori.Insert(0, new OdabirViewModel
                {
                    Naziv = "Odaberite autora"
                });

                OdabraniAutor = Autori.First();

                foreach (var autor in autori)
                {
                    Autori.Add(autor);
                }
            }
        }

        public async Task BindJezike()
        {
            if (!Jezici.Any())
            {
                var jezici = (await _jeziciService.Get<List<Jezici>>(null)).Select(j => new OdabirViewModel
                {
                    Id = j.JezikId,
                    Naziv = j.Naziv
                }).ToList();

                Jezici.Insert(0, new OdabirViewModel
                {
                    Naziv = "Odaberite jezik"
                });

                OdabraniJezik = Jezici.First();

                foreach (var jezik in jezici)
                {
                    Jezici.Add(jezik);
                }
            }
        }

        public async Task BindKnjige()
        {
            List<Knjige> knjige;

            if (_odabraniZanr == null && string.IsNullOrEmpty(Naziv))
            {
                knjige = await _knjigeService.Get<List<Knjige>>();
            }
            else
            {
                KnjigeSearchRequest request = new KnjigeSearchRequest
                {
                    ZanrId = _odabraniZanr.Id != 0 ? _odabraniZanr.Id : (int?)null,
                    AutorId = _odabraniAutor.Id != 0 ? _odabraniAutor.Id : (int?)null,
                    JezikId = _odabraniJezik.Id != 0 ? _odabraniJezik.Id : (int?)null,
                    Naziv = Naziv
                };

                knjige = await _knjigeService.Get<List<Knjige>>(request);
            }

            Knjige.Clear();

            foreach (var knjiga in knjige)
            {
                Knjige.Add(knjiga);
            }

            IsEmpty = !knjige.Any();
        }

        string _naziv = string.Empty;
        public string Naziv
        {
            get => _naziv;
            set => SetProperty(ref _naziv, value);
        }

        OdabirViewModel _odabraniZanr = null;
        public OdabirViewModel OdabraniZanr
        {
            get => _odabraniZanr;
            set => SetProperty(ref _odabraniZanr, value);
        }

        OdabirViewModel _odabraniAutor = null;
        public OdabirViewModel OdabraniAutor
        {
            get => _odabraniAutor;
            set => SetProperty(ref _odabraniAutor, value);
        }

        OdabirViewModel _odabraniJezik = null;
        public OdabirViewModel OdabraniJezik
        {
            get => _odabraniJezik;
            set => SetProperty(ref _odabraniJezik, value);
        }
    }

    public class OdabirViewModel
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
    }
}
