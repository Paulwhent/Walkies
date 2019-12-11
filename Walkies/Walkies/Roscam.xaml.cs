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
	public partial class Roscam : ContentPage
	{
		public Roscam ()
		{
			InitializeComponent ();
		}

        private async void RoscamInfoButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RoscamInfo());
        }
    }
}