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
	public partial class Page1 : ContentPage

	{
		public Page1()
		{
			InitializeComponent ();

            knocknacarraButton.Clicked += KnocknacarraButton_Clicked;
            salthillButton.Clicked += SalthillButton_Clicked;
            danganButton.Clicked += DanganButton_Clicked;
            roscamButton.Clicked += RoscamButton_Clicked;
            homeButton.Clicked += HomeButton_Clicked;
        }

        private async void HomeButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
            //throw new NotImplementedException();
        }

        private async void RoscamButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Roscam());
            //throw new NotImplementedException();
        }

        private async void DanganButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Dangan());
            //throw new NotImplementedException();
        }

        private async void KnocknacarraButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Knocknacarra());
            //throw new NotImplementedException();
        }

        private async void SalthillButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Salthill());
            //throw new NotImplementedException();
        }
        private async void SettingsButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Settings());
        }
        private async void GalleryButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Gallery());
        }
    
     }
}