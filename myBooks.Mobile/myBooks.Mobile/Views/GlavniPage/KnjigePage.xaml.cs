using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using myBooks.Model;
using myBooks.Mobile.ViewModels;

namespace myBooks.Mobile.Views.GlavniPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KnjigePage : ContentPage
    {
        private KnjigeViewModel _model;

        public KnjigePage()
        {
            InitializeComponent();

            BindingContext = _model = new KnjigeViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await _model.Bind();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Knjige;

            await Navigation.PushAsync(new DetaljiKnjigePage(item));
        }
    }
}