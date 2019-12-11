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
	public partial class Knocknacarra : ContentPage
	{
		public Knocknacarra ()
		{
			InitializeComponent ();
		}

        private async void KnocknacarraInfoButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KnocknacarraInfo());
        }

        
    }
}