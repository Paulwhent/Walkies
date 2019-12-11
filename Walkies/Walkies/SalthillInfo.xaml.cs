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
	public partial class SalthillInfo : ContentPage
	{
		public SalthillInfo ()
		{
			InitializeComponent ();
		}

        private async void HomeButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}
