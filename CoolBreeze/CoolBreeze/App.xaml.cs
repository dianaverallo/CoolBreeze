using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CoolBreeze
{
	public partial class App : Application
	{
	    public static MainViewModel ViewModel;
	    public static string RegistrationCode = "XBWWA1A0D6CC1D5C77B239BC0B274844";

        public App ()
		{
			InitializeComponent();

            //MainPage = new CoolBreeze.MainPage();
            //MainPage = new CoolBreeze.StartPage();
		    MainPage = new NavigationPage(new CoolBreeze.StartPage());
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
