using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigmap.VuesModéles;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Enigmap.Vues
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AccueilAuthentification : ContentPage
	{
		public AccueilAuthentification ()
		{
			InitializeComponent ();
            BindingContext = new VuesModélesConnexionInscription();
		}

        private void BoutonConnexion_Clicked(object sender, EventArgs e)
        {
           
        }

        private void BoutonInscription_Clicked(object sender, EventArgs e)
        {
          
        }
    }
}