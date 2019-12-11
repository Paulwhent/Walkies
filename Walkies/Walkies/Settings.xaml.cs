using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Walkies
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Settings : ContentPage
	{
		public Settings ()
		{
			InitializeComponent ();

            CameraButton.Clicked += CameraButton_Clicked;
        }
        private async void CameraButton_Clicked(object sender, EventArgs e)
        {
            var photo = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions() { });

            if (photo != null)
                PhotoImage.Source = ImageSource.FromStream(() => { return photo.GetStream(); });

                //PhotoImage.Save("C:/Users/Paul/OneDrive - GMIT\InternetAndMobileAppDev\repos\Walkies\Walkies\Walkies.Android\Resources\drawable\photo.png");
        }
        private void BtnStore_Clicked(object sender, EventArgs e)

        {
            // Store all  Values
            Application.Current.Properties["dogName"] = DogName.Text;
            DogName.Text = string.Empty;
            DisplayAlert("Success", "New Dog Name stored", "OK");
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
            {
            string dogName = DogName.Text;   // Use the Text property to get the (string) value of the entered text.

            DogName.Text = "dogName";
        }
            //private void Entry_Completed(object sender, EventArgs e)
            //{
            //    string DogName = ((Entry)sender).Text;
            //}
        }
    }

