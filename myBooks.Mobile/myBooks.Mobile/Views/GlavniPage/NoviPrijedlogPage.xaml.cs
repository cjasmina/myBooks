using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using myBooks.Mobile.ViewModels;

namespace myBooks.Mobile.Views.GlavniPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NoviPrijedlogPage : ContentPage
    {
        private NoviPrijedlogViewModel _model;

        public NoviPrijedlogPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, true);
            Title = "Novi prijedlog";

            BindingContext = _model = new NoviPrijedlogViewModel();
        }

        private async void Kreiraj_Clicked(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(Naziv.Text))
            {
                await DisplayAlert("myBooks", "Naziv knjige je obavezan!", "Zatvori");
                return;
            }

            if (string.IsNullOrEmpty(Autor.Text))
            {
                await DisplayAlert("myBooks", "Autor knjige je obavezan!", "Zatvori");
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

                await DisplayAlert("myBooks", "Dogodila se greška prilikom kreiranja prijedloga. Molimo pokušajte ponovo.", "Zatvori");
            }
        }
    }
}