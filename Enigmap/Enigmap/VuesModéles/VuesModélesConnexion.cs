using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Enigmap.Apirest;
using Enigmap.Vues;

namespace Enigmap.VuesModéles
{
    class VuesModélesConnexion : INotifyPropertyChanged
    {
        #region variables

        public string Pseudo { get; set; }
        public string Mdp { get; set; }
        private readonly ApiUser _apiServices = new ApiUser();

        #endregion

        #region notification

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region commandes
        public ICommand BoutonPageConnexion
        {
            get
            {
                return new Command(async () =>
                {

                    bool resultat = await _apiServices.LoginAsync(Pseudo, Mdp);
                    if (resultat)
                    {
                        Application.Current.MainPage = new MenuPage();
                    }

                });
            }
        }

        #endregion

    }
}
