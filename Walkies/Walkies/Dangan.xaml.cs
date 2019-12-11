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
	public partial class Dangan : ContentPage
	{
		public Dangan ()
		{
			InitializeComponent ();
            danganInfoButton.Clicked += DanganInfoButton_Clicked;
        }

        private async void DanganInfoButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DanganInfo());
        }
    }
}