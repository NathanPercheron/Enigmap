using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Enigmap.Vues;

namespace Enigmap.VuesModéles
{
    class VuesModélesConnexionInscription
    {
        #region Commandes

        // Binding du bouton "Connexion" pour pouvoir aller sur la page "Connexion"
        public ICommand AllerConnexion
        {
            get
            {
                return new Command(async () =>
                {
                    {
                        Application.Current.MainPage = new Connexion();
                    }

                });
            }
        }

        // Binding du bouton "Inscription" Pour aller sur la page "Inscription"
        public ICommand AllerInscription
        {
            get
            {
                return new Command(async () =>
                {
                    {
                        Application.Current.MainPage = new Inscription();
                    }

                });
            }
        }
        #endregion
    }
}
