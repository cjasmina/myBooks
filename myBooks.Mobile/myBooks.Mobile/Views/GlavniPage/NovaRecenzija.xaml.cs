using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using myBooks.Model;
using myBooks.Mobile.ViewModels;

namespace myBooks.Mobile.Views.GlavniPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NovaRecenzijaPage : ContentPage
    {
        private readonly Knjige knjiga;
        private readonly NovaRecenzijaViewModel _model;

        public NovaRecenzijaPage(Knjige knjiga)
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, true);
            Title = "Nova recenzija";

            BindingContext = _model = new NovaRecenzijaViewModel();
            this.knjiga = knjiga;
        }

        private async void Kreiraj_Clicked(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(Sadrzaj.Text))
            {
                await DisplayAlert("myBooks", "Sadržaj recenzije je obavezan!", "Zatvori");
                return;
            }

            try
            {
                await _model.Kreiraj(knjiga);

                await Navigation.PopAsync();
            }
            catch
            {
                _model.IsBusy = false;

                await DisplayAlert("myBooks", "Dogodila se greška prilikom kreiranja recenzije. Molimo pokušajte ponovo.", "Zatvori");
            }
        }
    }
}