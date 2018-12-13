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
	public partial class MenuPage : ContentPage
	{
		public MenuPage ()
		{
			InitializeComponent ();
            BindingContext = new DéfisVuesModéles();
		}

        private void ButtonJouer_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}