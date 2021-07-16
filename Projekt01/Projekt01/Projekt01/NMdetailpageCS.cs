using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

/*
namespace Projekt01
{
	public class NMdetailpageCS : ContentPage
	{
		public NMdetailpageCS ()
		{
			Content = new StackLayout {
				Children = {
					new Label { Text = "Hello Page" }
				}
			};
		}
	}
}
*/


namespace ModalNavigation
{
    public class DetailPageCS : ContentPage
    {
        public DetailPageCS()
        {
            var nameLabel = new Xamarin.Forms.Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Xamarin.Forms.Label)),
                FontAttributes = FontAttributes.Bold
            };
            nameLabel.SetBinding(Xamarin.Forms.Label.TextProperty, "Name");

            var ageLabel = new Xamarin.Forms.Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Xamarin.Forms.Label)),
                FontAttributes = FontAttributes.Bold
            };
            ageLabel.SetBinding(Xamarin.Forms.Label.TextProperty, "Age");

            var occupationLabel = new Xamarin.Forms.Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Xamarin.Forms.Label)),
                FontAttributes = FontAttributes.Bold
            };
            occupationLabel.SetBinding(Xamarin.Forms.Label.TextProperty, "Occupation");

            var countryLabel = new Xamarin.Forms.Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Xamarin.Forms.Label)),
                FontAttributes = FontAttributes.Bold
            };
            countryLabel.SetBinding(Xamarin.Forms.Label.TextProperty, "Country");

            var dismissButton = new Button { Text = "Dismiss" };
            dismissButton.Clicked += OnDismissButtonClicked;

            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);
            Content = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Children = {
                    new StackLayout {
                        Orientation = StackOrientation.Horizontal,
                        Children = {
                            new Xamarin.Forms.Label {
                                Text = "Name:",
                                FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Xamarin.Forms.Label)),
                                HorizontalOptions = LayoutOptions.FillAndExpand
                            },
                            nameLabel
                        }
                    },
                    new StackLayout {
                        Orientation = StackOrientation.Horizontal,
                        Children = {
                            new Xamarin.Forms.Label {
                                Text = "Age:",
                                FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Xamarin.Forms.Label)),
                                HorizontalOptions = LayoutOptions.FillAndExpand
                            },
                            ageLabel
                        }
                    },
                    new StackLayout {
                        Orientation = StackOrientation.Horizontal,
                        Children = {
                            new Xamarin.Forms.Label {
                                Text = "Occupation:",
                                FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Xamarin.Forms.Label)),
                                HorizontalOptions = LayoutOptions.FillAndExpand
                            },
                            occupationLabel
                        }
                    },
                    new StackLayout {
                        Orientation = StackOrientation.Horizontal,
                        Children = {
                            new Xamarin.Forms.Label {
                                Text = "Country:",
                                FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Xamarin.Forms.Label)),
                                HorizontalOptions = LayoutOptions.FillAndExpand
                            },
                            countryLabel
                        }
                    },
                    dismissButton
                }
            };
        }

        async void OnDismissButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
        }
    }
}
