using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using myBooks.Mobile.ViewModels;

namespace myBooks.Mobile.Views.GlavniPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NovaPolicaPage : ContentPage
    {
        private NovaPolicaViewModel _model;
        private DateTime _minDateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).AddDays(1);

        public NovaPolicaPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, true);
            Title = "Nova polica";

            KrajnjiDatumCilja.MinimumDate = _minDateTime;

            BindingContext = _model = new NovaPolicaViewModel(_minDateTime);
        }

        private async void Kreiraj_Clicked(object sender, System.EventArgs e)
        {
            string greska = null;

            if (string.IsNullOrEmpty(Naziv.Text))
            {
                greska = "Naziv police je obavezan!";
            }


            if (KrajnjiDatumCilja.Date < _minDateTime)
            {
                greska = "Krajnji datum cilja ne može biti manji od trenutnog datuma";
                KrajnjiDatumCilja.Date = _minDateTime;
            }

            if (greska != null)
            {
                await DisplayAlert("myBooks", greska, "Zatvori");
                return;
            }

            try
            {
                await _model.Kreiraj();

                await Navigation.PopAsync();
            }
            catch
            {
                _model.IsBusy = false;

                await DisplayAlert("myBooks", "Dogodila se greška prilikom kreiranja police. Molimo pokušajte ponovo.", "Zatvori");
            }
        }
    }
}