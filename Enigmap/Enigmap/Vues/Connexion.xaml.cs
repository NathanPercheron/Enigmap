using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigmap.VuesModéles;
using Enigmap.Vues;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Enigmap.Vues
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Connexion : ContentPage
	{
		public Connexion ()
		{
			InitializeComponent ();
            BindingContext = new VuesModélesConnexion();
            
		}
	}
}