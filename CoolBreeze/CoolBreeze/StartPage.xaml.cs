using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CoolBreeze
{
    public partial class StartPage : TabbedPage
    {
        public StartPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            InitializeAppAsync();
            base.OnAppearing();
        }

        private void InitializeAppAsync()
        {
            //DateTime badDateTime = DateTime.Parse("This is not a date or time"); //use to demo crash report transmitted to AppCenter
            if (App.ViewModel == null) App.ViewModel = new MainViewModel();
        }

        private async void ViewForecastClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ForecastPage());
        }
    }
}