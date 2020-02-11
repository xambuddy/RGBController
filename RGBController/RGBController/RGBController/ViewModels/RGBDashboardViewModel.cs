using RGBController.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RGBController.ViewModels
{
    public class RGBDashboardViewModel : BindableObject
    {
        public RGBDashboardViewModel()
        {
            Red = 255;
        }

        public ICommand SendCommand => new Command(async () => await SendCommandExecute());

        private async Task SendCommandExecute()
        {
            await new DataService().SendColor(new Models.RGB { blue = Blue, green = Green, red = Red });
        }

        private int _red;

        public int Red
        {
            get => _red;
            set
            {
                _red = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ButtonColor));
            }
        }


        private int _blue;

        public int Blue
        {
            get => _blue;
            set
            {
                _blue = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ButtonColor));
            }
        }

        private int _green;

        public int Green
        {
            get => _green;
            set
            {
                _green = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ButtonColor));
            }
        }

        public Color ButtonColor
        {
            get
            {
                return Color.FromRgb(Red, Green, Blue);
            }
        }
    }
}
