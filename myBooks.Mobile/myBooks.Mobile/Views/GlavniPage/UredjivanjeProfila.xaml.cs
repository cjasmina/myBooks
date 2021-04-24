using System;
using System.Text.RegularExpressions;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using myBooks.Mobile.ViewModels;

namespace myBooks.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UredjivanjeProfilaPage : ContentPage
    {
        private readonly UredjivanjeProfilaViewModel _model;

        public UredjivanjeProfilaPage()
        {
            InitializeComponent();

            BindingContext = _model = new UredjivanjeProfilaViewModel();
        }

        private async void UrediButton_Clicked(object sender, EventArgs e)
        {
            string greska = null;

            if (string.IsNullOrEmpty(Ime.Text))
            {
                greska = "Ime je obavezno!";
            }
            else if (string.IsNullOrEmpty(Prezime.Text))
            {
                greska = "Prezime je obavezno!";
            }
            else if (string.IsNullOrEmpty(Telefon.Text))
            {
                greska = "Telefon je obavezan!";
            }
            else if (string.IsNullOrEmpty(Email.Text))
            {
                greska = "Email je obavezan!";
            }
            else if (!string.IsNullOrEmpty(Lozinka.Text))
            {
                if (Lozinka.Text.Length < 8)
                {
                    greska = "Lozinka ne smije biti kraća od 8 karaktera.";
                }
                else if (Lozinka.Text != PotvrdaLozinke.Text)
                {
                    greska = "Lozinke se ne podudaraju!";
                }
            }
            

            if(greska != null)
            {
                await DisplayAlert("myBooks", greska, "Zatvori");
                return;
            }

            try
            {
                await _model.Uredi();

                await DisplayAlert("myBooks", "Profil uspješno uređen.", "Zatvori");
            }
            catch
            {
                _model.IsBusy = false;

                await DisplayAlert("myBooks", "Dogodila se greška prilikom registracije. Molimo pokušajte ponovo.", "Zatvori");
            }
        }
    }
}