using System;
using System.Net;
using WarehouseManagement.Services;
using WarehouseManagement.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WarehouseManagement
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            DependencyService.Register<UserMockDataStore>();
            MainPage = new LoginPage();
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
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
