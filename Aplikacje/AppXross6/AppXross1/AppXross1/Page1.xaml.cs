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
	public partial class Page1 : ContentPage
	{
		public Page1 (string parameter)
        //A string is a sequential collection of Unicode characters that is used to represent text.
        //Więcej informacji na temat stringa jako klasy i konstruktora na https://developer.xamarin.com/api/type/System.String/

        {
            InitializeComponent ();

            DrogiLabel.Text = parameter; //odnośnik od Label w Page1.xaml jako parametru
		}
	}
}
