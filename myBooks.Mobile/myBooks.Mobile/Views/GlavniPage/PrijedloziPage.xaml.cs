using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using myBooks.Model;
using myBooks.Mobile.ViewModels;

namespace myBooks.Mobile.Views.GlavniPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrijedloziPage : ContentPage
    {
        private PrijedloziViewModel _model;

        public PrijedloziPage()
        {
            InitializeComponent();

            BindingContext = _model = new PrijedloziViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await _model.Bind();
        }

        private async void Kreiraj_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new NoviPrijedlogPage());

            await _model.Bind();
        }

        private async void Obrisi_Clicked(object sender, System.EventArgs e)
        {
            try
            {
                var prijedlog = (sender as Button).CommandParameter as Prijedlozi;

                await _model.Obrisi(prijedlog);
                await _model.Bind();
            }
            catch
            {
                //
            }
        }
    }
}