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
	public partial class Page3 : ContentPage
    {
        int count = 0;

        public Page3 ()
		{
			InitializeComponent ();
		}

        public void Button_Clicked(object sender, EventArgs e)
        {
            count++;

            ((Button)sender).Text =
                String.Format("{0} click{1}!", count, count == 1 ? "" : "s");
        }
    }
}
