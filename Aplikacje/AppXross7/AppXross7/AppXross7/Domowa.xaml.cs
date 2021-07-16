using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppXross7
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Domowa : ContentPage
	{
		public Domowa ()
		{
			InitializeComponent ();

            GlownyListView.ItemsSource = new List<string> 
            {
                "Maciej", "Deimos", "Mojżesz", "3perełki ;)", "Jestem", "Byłem", "Będę"
            };
            //przypomnienie info o string : https://developer.xamarin.com/api/type/System.String/
            //info o itemssource https://developer.xamarin.com/api/property/Xamarin.Forms.ItemsView<TVisual>.ItemsSource/
        }
    }
}
