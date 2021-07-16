using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppXross1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Domowa : ContentPage
	{
		public Domowa ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            string text = GlownyWpis.Text;
            //odniesienie do entry x.Name 

            GlownyLabel.Text = "Witaj " + text;
            //odniesienie do Label x:Name="GlownyLabel" + powyzszy string text
        }

        private async void Button_Clicked_1(object sender, EventArgs e) //musi być asynchroniczne z powodu metody await
        {
            await Navigation.PushAsync(new Page1(GlownyWpis.Text));
            //działanie naciśnięcia przycisku -> przekierowuje do Page1
            //wpisany tekst z GlownyWpis (patrz -> domowa.xaml) zostanie przekazany do Page1
        }
    }
}
