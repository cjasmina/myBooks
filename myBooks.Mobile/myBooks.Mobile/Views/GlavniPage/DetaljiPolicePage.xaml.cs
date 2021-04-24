using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using myBooks.Model;
using myBooks.Mobile.ViewModels;

namespace myBooks.Mobile.Views.GlavniPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetaljiPolicePage : ContentPage
    {
        private DetaljiPoliceViewModel _model;

        public DetaljiPolicePage(Police polica)
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, true);
            Title = polica.Naziv;

            BindingContext = _model = new DetaljiPoliceViewModel(polica);
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await _model.Bind();
        }

        private async void Obrisi_Clicked(object sender, System.EventArgs e)
        {
            try
            {
                var knjiga = (sender as Button).CommandParameter as Knjige;

                await _model.Obrisi(knjiga);
                await _model.Bind();
            }
            catch
            {
                //
            }
        }
    }
}