using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace myBooks.Mobile.Views.GlavniPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GlavniPage : FlyoutPage
    {
        public GlavniPage()
        {
            InitializeComponent();
            
            FlyoutPage.ListView.ItemSelected += ListView_ItemSelected;

            SetujPrviPage();
        }

        private void SetujPrviPage()
        {
            var menuItem = FlyoutPage.ListView.ItemsSource.Cast<GlavniPageFlyoutMenuItem>().First();
            var page = (Page)Activator.CreateInstance(menuItem.TargetType);
            page.Title = menuItem.Title;

            Detail = new NavigationPage(page);
            IsPresented = false;

            FlyoutPage.ListView.SelectedItem = menuItem;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as GlavniPageFlyoutMenuItem;
            if (item == null)
                return;

            if (item.Action != null)
            {
                item.Action.Invoke();
            }
            else
            {
                var page = (Page)Activator.CreateInstance(item.TargetType);
                page.Title = item.Title;

                Detail = new NavigationPage(page);
                IsPresented = false;

                FlyoutPage.ListView.SelectedItem = null;
            }
        }
    }
}