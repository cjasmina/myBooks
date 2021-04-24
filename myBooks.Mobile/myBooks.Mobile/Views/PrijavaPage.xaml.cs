using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Flurl.Http;

using myBooks.Mobile.ViewModels;

namespace myBooks.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrijavaPage : ContentPage
    {
        private readonly PrijavaViewModel _model;

        public PrijavaPage(string korisnickoIme = null)
        {
            InitializeComponent();

            KorisnickoIme.Text = korisnickoIme;
            BindingContext = _model = new PrijavaViewModel();

            KorisnickoIme.Text = "korisnik1";
            Lozinka.Text = "test";
        }

        private async void PrijavaButton_Clicked(object sender, EventArgs e)
        {
            string greska = null;

            if (string.IsNullOrEmpty(KorisnickoIme.Text))
            {
                greska = "Korisničko ime je obavezno!";
            }
            else if (string.IsNullOrEmpty(Lozinka.Text))
            {
                greska = "Lozinka je obavezna!";
            }

            if (greska != null)
            {
                await DisplayAlert("myBooks", greska, "Zatvori");
                return;
            }

            try
            {
                var korisnik = await _model.Prijava();
                if(korisnik == null)
                {
                    await DisplayAlert("myBooks", "Korisničko ime i/ili lozinka nisu ispravni.", "Zatvori");
                    return;
                }

                Memorija.PrijavljeniKorisnik = korisnik;

                Application.Current.MainPage = new GlavniPage.GlavniPage();
            }
            catch (FlurlHttpException ex)
            {
                _model.IsBusy = false;

                if (ex.Call.Response.StatusCode == (int)System.Net.HttpStatusCode.Unauthorized)
                {
                    await DisplayAlert("myBooks", "Korisničko ime i/ili lozinka nisu ispravni.", "Zatvori");
                }
                else
                {
                    await DisplayAlert("myBooks", "Dogodila se greška prilikom registracije. Molimo pokušajte ponovo.", "Zatvori");
                }
            }
        }

        private void RegistracijaButton_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new RegistracijaPage();
        }
    }
}