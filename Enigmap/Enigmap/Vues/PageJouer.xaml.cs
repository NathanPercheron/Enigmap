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
	public partial class PageJouer : ContentPage
	{
		public PageJouer ()
		{
			InitializeComponent ();
            BindingContext = new DéfisVuesModéles();
		}
	}
}