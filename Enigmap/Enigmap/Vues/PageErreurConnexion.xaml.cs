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
	public partial class PageErreurConnexion : ContentPage
	{
		public PageErreurConnexion ()
		{
			InitializeComponent ();
            BindingContext = new VuesModélesErreurConnexion();
		}

        private void RetourConnexion_Clicked(object sender, EventArgs e)
        {
            
        }

        private void AllerInscription_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}