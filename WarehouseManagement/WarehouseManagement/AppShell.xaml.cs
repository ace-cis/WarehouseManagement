using System;
using System.Collections.Generic;
using WarehouseManagement.ViewModels;
using WarehouseManagement.Views;
using Xamarin.Forms;

namespace WarehouseManagement
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
          //  Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(LoadPlan), typeof(LoadPlan));
        }

    }
}
