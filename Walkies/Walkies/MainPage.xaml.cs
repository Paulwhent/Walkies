using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Walkies

{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {

            InitializeComponent();
            //new NavigationPage(new  MainPage());

            //CameraButton.Clicked += CameraButton_Clicked;

            letsgoButton.Clicked += LetsgoButton_ClickedAsync;
        }

        private async void CameraButton_Clicked(object sender, EventArgs e)
        {
            var photo = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions() { });

            if (photo != null)
                PhotoImage.Source = ImageSource.FromStream(() => { return photo.GetStream(); });   
        }
        
        private async void LetsgoButton_ClickedAsync(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            await Navigation.PushAsync(new Page1());

        }

    }
}
