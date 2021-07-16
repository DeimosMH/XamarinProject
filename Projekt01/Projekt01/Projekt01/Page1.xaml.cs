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
	public partial class Page1 : ContentPage
	{
        public Page1()
        {
            InitializeComponent();
        }
   
        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                /*
                double a = double.Parse(boka.Text);
                double b = double.Parse(bokb.Text);

                //double c = Math.Round(Math.Sqrt(a*a)+Math.Sqrt(b*b));
                double c = double.Parse(bokc.Text);

                if(a!=0 && b!=0)
                {
                    double c1 = Math.Round(Math.Sqrt(a * a) + Math.Sqrt(b * b));
                    bokc.Text = c1.ToString();
                }

                else if(a != 0 && c != 0)
                {
                    double b1 = Math.Round(Math.Sqrt(a * a) + Math.Sqrt(c * c));
                    bokb.Text = b1.ToString();
                }

                else if (b != 0 && c != 0)
                {
                    double a1 = Math.Round(Math.Sqrt(b * b) + Math.Sqrt(c * c));
                    bokb.Text = a1.ToString();
                }
                */
                double a = double.Parse(boka.Text);
                double b = double.Parse(bokb.Text);

                double c1 = Math.Round(Math.Sqrt((a * a) +(b * b)));
                bokc.Text = c1.ToString();
            }
            catch (FormatException)
            {
                bokc.Text = "Błąd wejścia";
            }
        }
         
    }
}
