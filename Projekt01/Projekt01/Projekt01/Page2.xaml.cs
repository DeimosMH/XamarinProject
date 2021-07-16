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
	public partial class Page2 : ContentPage
	{
		public Page2 ()
		{
			InitializeComponent ();
		}

        
        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                double P = double.Parse(moc.Text);
                double U = double.Parse(nap.Text);
                double I = Math.Round(P / U, 2);

                pra.Text = I.ToString();
            }
            catch (FormatException)
            {
                pra.Text = "Błąd wejścia";
            }


        }

    }

    
}
