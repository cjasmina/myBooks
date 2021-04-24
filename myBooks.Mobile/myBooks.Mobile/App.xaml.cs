﻿using Xamarin.Forms;

using myBooks.Mobile.Views;

namespace myBooks.Mobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            
            MainPage = new PrijavaPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
