using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Enigmap.Vues;

namespace Enigmap.VuesModéles
{
    class VuesModélesErreurConnexion
    {
        #region commandes

        // Binding du bouton "Se Reconnecter" pour pouvoir retourner sur la page "connexion"
        public ICommand BoutonRetourConnexion
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

        // Binding du bouton "S'inscrire" pour pouvoir aller à la page "Inscription" si le joueur n'est finalement pas inscrit
        public ICommand BoutonRetourInscription
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
