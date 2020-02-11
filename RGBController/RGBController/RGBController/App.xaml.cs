using RGBController.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RGBController
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new RGBDashboard();
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
