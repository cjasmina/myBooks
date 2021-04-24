using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace myBooks.Mobile.Views.GlavniPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GlavniPageFlyout : ContentPage
    {
        public ListView ListView;

        public GlavniPageFlyout()
        {
            InitializeComponent();

            BindingContext = new GlavniPageFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        class GlavniPageFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<GlavniPageFlyoutMenuItem> MenuItems { get; set; }

            public GlavniPageFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<GlavniPageFlyoutMenuItem>(new[]
                {
                    new GlavniPageFlyoutMenuItem
                    {
                        Id = 0,
                        Title = "Knjige",
                        TargetType = typeof(KnjigePage)
                    },
                    new GlavniPageFlyoutMenuItem
                    {
                        Id = 1,
                        Title = "Moje police",
                        TargetType = typeof(PolicePage)
                    },
                    new GlavniPageFlyoutMenuItem
                    {
                        Id = 2,
                        Title = "Moji prijedlozi",
                        TargetType = typeof(PrijedloziPage)
                    },
                    new GlavniPageFlyoutMenuItem
                    {
                        Id = 3,
                        Title = "Uređivanje profila",
                        TargetType = typeof(UredjivanjeProfilaPage)
                    },
                    new GlavniPageFlyoutMenuItem
                    {
                        Id = 4,
                        Title = "Odjava",
                        Action = () =>
                        {
                            Application.Current.MainPage = new PrijavaPage();
                        }
                    },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}