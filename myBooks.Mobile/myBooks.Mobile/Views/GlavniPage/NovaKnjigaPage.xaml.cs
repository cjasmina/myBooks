using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using myBooks.Model;
using myBooks.Mobile.ViewModels;

namespace myBooks.Mobile.Views.GlavniPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NovaKnjigaPage : ContentPage
    {
        private readonly NovaKnjigaViewModel _model;

        public NovaKnjigaPage(Knjige knjiga)
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, true);
            Title = "Odaberite policu";

            BindingContext = _model = new NovaKnjigaViewModel(knjiga);
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await _model.Bind();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            try
            {
                var item = (e.SelectedItem as PolicaViewModel).Polica;

                await _model.Odaberi(item);

                await Navigation.PopAsync();
            }
            catch
            {
                _model.IsBusy = false;

                await DisplayAlert("myBooks", "Dogodila se greška prilikom dodavanja knjige u policu. Molimo pokušajte ponovo.", "Zatvori");
            }
        }

        private async void Kreiraj_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new NovaPolicaPage());

            await _model.Bind();
        }
    }
}