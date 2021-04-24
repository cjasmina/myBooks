using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using myBooks.Model;
using myBooks.Mobile.ViewModels;

namespace myBooks.Mobile.Views.GlavniPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NovaOcjenaPage : ContentPage
    {
        private readonly Knjige knjiga;
        private readonly NovaOcjenaViewModel _model;

        public NovaOcjenaPage(Knjige knjiga)
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, true);
            Title = "Nova ocjena";

            BindingContext = _model = new NovaOcjenaViewModel();
            this.knjiga = knjiga;
        }

        private async void Kreiraj_Clicked(object sender, System.EventArgs e)
        {
            if(Ocjena.SelectedItem == null)
            {
                await DisplayAlert("myBooks", "Ocjena je obavezan!", "Zatvori");
                return;
            }

            try
            {
                await _model.Ocijeni(knjiga, int.Parse(Ocjena.SelectedItem as string));

                await Navigation.PopAsync();
            }
            catch
            {
                _model.IsBusy = false;

                await DisplayAlert("myBooks", "Dogodila se greška prilikom ocijenjivanja knjige. Molimo pokušajte ponovo.", "Zatvori");
            }
        }
    }
}