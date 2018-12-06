using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Enigmap.Vues;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Enigmap
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new AccueilAuthentification());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
