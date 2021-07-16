using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Projekt01
{
	public partial class App : Application
	{
		public App ()
		{

            MainPage = new TabbedPage
            {
                Children =
                {
                    new Projekt01.MainPage(), //patrz bMainPage.xaml
                    new ListViewPage1(),
                    new Domowa(),
                    new Page1(),
                    new Page2(),
                    new Page3(),
                    new Page4(),
                    new ModalNavigation.MainPage()
                 },
            };

            //MainPage =  new NavigationPage(new Domowa());

            //InitializeComponent();
            //MainPage = new Projekt01.MainPage();
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
