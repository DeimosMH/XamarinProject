using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
/*
namespace Projekt01
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NMdetailpage : ContentPage
	{
		public NMdetailpage ()
		{
			InitializeComponent ();
		}
	}
}
*/

namespace ModalNavigation
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage()
        {
            InitializeComponent();
        }

        async void OnDismissButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
        }
    }
}

