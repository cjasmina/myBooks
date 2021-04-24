using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using myBooks.Model;
using myBooks.Mobile.ViewModels;

namespace myBooks.Mobile.Views.GlavniPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PolicePage : ContentPage
    {
        private PoliceViewModel _model;

        public PolicePage()
        {
            InitializeComponent();

            BindingContext = _model = new PoliceViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await _model.Bind();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as PolicaViewModel;

            await Navigation.PushAsync(new DetaljiPolicePage(item.Polica));
        }

        private async void Kreiraj_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new NovaPolicaPage());

            await _model.Bind();
        }

        private async void Obrisi_Clicked(object sender, System.EventArgs e)
        {
            try
            {
                var polica = (sender as Button).CommandParameter as Police;

                await _model.Obrisi(polica);
                await _model.Bind();
            }
            catch
            {
                //
            }
        }
    }
}