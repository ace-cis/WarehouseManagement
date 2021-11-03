using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WarehouseManagement.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoadPlan : TabbedPage
    {
        LoadPlanViewModel _viewModel;
        public LoadPlan()
        {
            InitializeComponent();
            BindingContext = _viewModel = new LoadPlanViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();

            //App.HardwareBackPressed = () => Task.FromResult<bool?>(null);
        }

        protected override bool OnBackButtonPressed()
        {
            //_viewModel.OnClickbackAsync();



            //  base.OnBackButtonPressed();
            Device.BeginInvokeOnMainThread(async () =>
            {
                if (await DisplayAlert("Exit?", "Are you sure you want to exit from this page?", "Yes", "No"))
                {
                    base.OnBackButtonPressed();
                    await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
                }
            });

            return true;
        }
    }
}