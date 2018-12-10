using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Enigmap.Vues
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageErreurConnexion : ContentPage
	{
		public PageErreurConnexion ()
		{
			InitializeComponent ();
		}

        private void RetourConnexion_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Connexion());
        }

        private void AllerInscription_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Inscription());
        }
    }
}