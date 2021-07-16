using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AppXross7
{
	public partial class App : Application
	{
		public App ()
		{
            MainPage = new Domowa();

			//InitializeComponent();                pomiń

			//MainPage = new AppXross7.MainPage();  pomiń
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
