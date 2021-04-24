using myBooks.Model;
using myBooks.Model.Requests;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using System.Linq;
using System;

namespace myBooks.Mobile.ViewModels
{
    public class DetaljiKnjigeViewModel : BaseViewModel
    {
        private readonly ApiService _knjigeService = new ApiService("Knjige");
        private readonly ApiService _ocjeneService = new ApiService("Ocjene");
        private readonly ApiService _recenzijeService = new ApiService("Recenzije");
        private readonly ApiService _policeKnjigeService = new ApiService("PoliceKnjige");

        public Knjige Knjiga { get; set; }

        private double _prosjecnaOcjena;
        public double ProsjecnaOcjena
        {
            get => _prosjecnaOcjena;
            set => SetProperty(ref _prosjecnaOcjena, value);
        }

        private bool _imaProsjecnuOcjenu = false;
        public bool ImaProsjecnuOcjenu
        {
            get => _imaProsjecnuOcjenu;
            set => SetProperty(ref _imaProsjecnuOcjenu, value);
        }

        private bool _mozeDodatiRecenziju = false;
        public bool MozeDodatiRecenziju
        {
            get => _mozeDodatiRecenziju;
            set => SetProperty(ref _mozeDodatiRecenziju, value);
        }

        private bool _mozeDodatiKnjiguUPolicu = false;
        public bool MozeDodatiKnjiguUPolicu
        {
            get => _mozeDodatiKnjiguUPolicu;
            set => SetProperty(ref _mozeDodatiKnjiguUPolicu, value);
        }

        private bool _mozeObrisatiIzPolice = false;
        public bool MozeObrisatiIzPolice
        {
            get => _mozeObrisatiIzPolice;
            set => SetProperty(ref _mozeObrisatiIzPolice, value);
        }

        private bool _mozeOznacitikaoProcitano = false;
        public bool MozeOznacitiKaoProcitano
        {
            get => _mozeOznacitikaoProcitano;
            set => SetProperty(ref _mozeOznacitikaoProcitano, value);
        }

        private bool _mozeDatiOcjenu = false;
        public bool MozeDatiOcjenu
        {
            get => _mozeDatiOcjenu;
            set => SetProperty(ref _mozeDatiOcjenu, value);
        }
        
        private bool _mozePromijenitiPolicu = false;
        public bool MozePromijenitiPolicu
        {
            get => _mozePromijenitiPolicu;
            set => SetProperty(ref _mozePromijenitiPolicu, value);
        }

        private bool _knjigaProcitana = false;
        public bool KnjigaProcitana
        {
            get => _knjigaProcitana;
            set => SetProperty(ref _knjigaProcitana, value);
        }

        private string _nazivPolice = "-";
        public string NazivPolice
        {
            get => _nazivPolice;
            set => SetProperty(ref _nazivPolice, value);
        }

        private bool _isRecenzijeEmpty = false;
        public bool IsRecenzijeEmpty
        {
            get => _isRecenzijeEmpty;
            set => SetProperty(ref _isRecenzijeEmpty, value);
        }

        private bool _isPreporuceneKnjigeEmpty = false;
        public bool IsPreporuceneKnjigeEmpty
        {
            get => _isPreporuceneKnjigeEmpty;
            set => SetProperty(ref _isPreporuceneKnjigeEmpty, value);
        }

        private bool _imaPolicu = false;
        public bool ImaPolicu
        {
            get => _imaPolicu;
            set => SetProperty(ref _imaPolicu, value);
        }

        public string NazivAndISBN => $"{Knjiga.Naziv} ({Knjiga.ISBN})";
        public string Autori => string.Join(", ", Knjiga.Autori.Select(a => a.ImePrezime).ToArray());

        private PoliceKnjige _policaKnjiga;

        public ICommand BindCommand { get; set; }

        public ObservableCollection<RecenzijaViewModel> Recenzije { get; set; } = new ObservableCollection<RecenzijaViewModel>();
        public ObservableCollection<Knjige> PreporuceneKnjige { get; set; } = new ObservableCollection<Knjige>();

        public DetaljiKnjigeViewModel()
        {

        }

        public DetaljiKnjigeViewModel(Knjige knjige)
        {
            Knjiga = knjige;

            BindCommand = new Command(async () => await Bind());
        }

        public async Task Bind()
        {
            await ProvjeriPolice();
            await BindOcjene();
            await BindRecenzije();
            await BindPreporuceneKnjige();
        }

        public async Task BindOcjene()
        {
            var ocjene = await _ocjeneService.Get<List<Ocjene>>(new OcjeneSearchRequest
            {
                KnjigaId = Knjiga.KnjigaId
            });

            if (ocjene.Any())
            {
                ProsjecnaOcjena = ocjene.Average(o => o.Ocjena);
                MozeDatiOcjenu = !ocjene.Any(o => o.KorisnikId == Memorija.PrijavljeniKorisnik.KorisnikId) && !MozeDodatiKnjiguUPolicu;
            }
            else
            {
                ProsjecnaOcjena = 0;
                MozeDatiOcjenu = !MozeDodatiKnjiguUPolicu;
            }
            
            ImaProsjecnuOcjenu = ProsjecnaOcjena > 0;
        }

        public async Task BindRecenzije()
        {
            var recenzije = await _recenzijeService.Get<List<Recenzije>>(new RecenzijeSearchRequest
            {
                KnjigaId = Knjiga.KnjigaId
            });

            Recenzije.Clear();

            if (recenzije.Any())
            {
                foreach (var recenzija in recenzije)
                {
                    Recenzije.Add(new RecenzijaViewModel
                    {
                        Recenzija = recenzija,
                        MozeObrisati = Memorija.PrijavljeniKorisnik.KorisnikId == recenzija.Korisnik.KorisnikId && !KnjigaProcitana
                    });
                }

                MozeDodatiRecenziju = !recenzije.Any(r => r.Korisnik.KorisnikId == Memorija.PrijavljeniKorisnik.KorisnikId) && !MozeDodatiKnjiguUPolicu;
            }
            else
            {
                MozeDodatiRecenziju = !MozeDodatiKnjiguUPolicu;
            }

            IsRecenzijeEmpty = !recenzije.Any();
        }

        public async Task BindPreporuceneKnjige()
        {
            var preporuceneKnjige = await _knjigeService.GetAction<List<Knjige>>("PreporuciKnjige", new KnjigeSearchRequest
            {
                KnjigaId = Knjiga.KnjigaId
            });

            PreporuceneKnjige.Clear();

            foreach (var preporucenaKnjiga in preporuceneKnjige)
            {
                PreporuceneKnjige.Add(preporucenaKnjiga);
            }

            IsPreporuceneKnjigeEmpty = !preporuceneKnjige.Any();
        }

        public async Task ProvjeriPolice()
        {
            _policaKnjiga = (await _policeKnjigeService.Get<List<PoliceKnjige>>(new PoliceKnjigeSearchRequest
            {
                KnjigaId = Knjiga.KnjigaId,
                KorisnikId = Memorija.PrijavljeniKorisnik.KorisnikId
            })).FirstOrDefault();

            if(_policaKnjiga == null)
            {
                ImaPolicu = false;
                MozeDodatiKnjiguUPolicu = true;
                MozeObrisatiIzPolice = false;
                MozeOznacitiKaoProcitano = false;
                KnjigaProcitana = false;
                MozePromijenitiPolicu = false;
            }
            else
            {
                ImaPolicu = true;
                NazivPolice = _policaKnjiga.Polica.Naziv;
                MozeDodatiKnjiguUPolicu = false;
                MozeObrisatiIzPolice = !_policaKnjiga.Procitano;
                MozeOznacitiKaoProcitano = !_policaKnjiga.Procitano;
                MozePromijenitiPolicu = !_policaKnjiga.Procitano;
                KnjigaProcitana = _policaKnjiga.Procitano;
            }
        }

        public async Task ObrisiIzPolice()
        {
            if (_policaKnjiga != null)
            {
                await _policeKnjigeService.DeleteWithRequest<PoliceKnjige>(new PoliceKnjigeDeleteRequest
                {
                    PolicaId = _policaKnjiga.PolicaId,
                    KnjigaId = _policaKnjiga.KnjigaId
                });
            }
        }

        public async Task OznaciKaoProcitano()
        {
            if (_policaKnjiga != null)
            {
                await _policeKnjigeService.Update<PoliceKnjige>(_policaKnjiga.PolicaKnjigaId, new PoliceKnjigeUpsertRequest
                {
                    PolicaId = _policaKnjiga.PolicaId,
                    KnjigaId = _policaKnjiga.KnjigaId,
                    Procitano = true
                });
            }
        }

        public async Task ObrisiRecenziju(RecenzijaViewModel recenzija)
        {
            await _recenzijeService.Delete<Recenzije>(recenzija.Recenzija.RecenzijaId);
        }
    }

    public class RecenzijaViewModel
    {
        public Recenzije Recenzija { get; set; }
        public bool MozeObrisati { get; set; }
    }
}
