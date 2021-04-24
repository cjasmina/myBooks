using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using myBooks.Model;
using myBooks.Mobile.ViewModels;
using System;

namespace myBooks.Mobile.Views.GlavniPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetaljiKnjigePage : ContentPage
    {
        private readonly Knjige _knjiga;
        private readonly DetaljiKnjigeViewModel _model;

        public DetaljiKnjigePage(Knjige knjiga)
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, true);
            Title = knjiga.Naziv;
            _knjiga = knjiga;

            BindingContext = _model = new DetaljiKnjigeViewModel(knjiga);
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await _model.Bind();
        }

        private async void DodajUPolicu_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NovaKnjigaPage(_knjiga));

            await _model.Bind();
        }

        private async void ObrisiIzPolice_Clicked(object sender, EventArgs e)
        {
            try
            {
                await _model.ObrisiIzPolice();
                await _model.Bind();
            }
            catch
            {
                //
            }
        }

        private async void OznaciKaoProcitano_Clicked(object sender, EventArgs e)
        {
            try
            {
                await _model.OznaciKaoProcitano();
                await _model.Bind();
            }
            catch
            {
                //
            }
        }

        private async void PromijeniPolicu_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new NovaKnjigaPage(_knjiga));

                await _model.Bind();
            }
            catch
            {
                //
            }
        }

        private async void ObrisiRecenziju_Clicked(object sender, EventArgs e)
        {
            try
            {
                var recenzija = (sender as Button).CommandParameter as RecenzijaViewModel;

                await _model.ObrisiRecenziju(recenzija);
                await _model.Bind();
            }
            catch
            {
                //
            }
        }

        private async void KreirajRecenziju_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NovaRecenzijaPage(_knjiga));

            await _model.BindRecenzije();
        }

        private async void Ocijeni_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NovaOcjenaPage(_knjiga));

            await _model.BindRecenzije();
        }

        private async void Detalji_Clicked(object sender, EventArgs e)
        {
            var knjiga = (sender as Button).CommandParameter as Knjige;

            await Navigation.PushAsync(new DetaljiKnjigePage(knjiga));
        }
    }
}