using RGBController.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RGBController.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RGBDashboard : ContentPage
    {
        public RGBDashboard()
        {
            InitializeComponent();

            this.BindingContext = new RGBDashboardViewModel();
        }
    }
}