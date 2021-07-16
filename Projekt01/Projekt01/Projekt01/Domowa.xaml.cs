using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projekt01
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Domowa : ContentPage
	{
        private NavigationPage navigationPage;

        public Domowa ()
		{
			InitializeComponent ();
		}

        public Domowa(NavigationPage navigationPage)
        {
            this.navigationPage = navigationPage;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string text = GlownyWpis.Text;
            GlownyLabel.Text = "Witaj " + text;
        }

        /*
        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
        */
        //działanie typu Navigation nie działa z Carousel/Tabbed Page
    }
}
