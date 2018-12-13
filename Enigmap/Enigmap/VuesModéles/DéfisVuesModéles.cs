using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Enigmap.Modéles;
using Enigmap.Apirest;
using System.Windows.Input;
using Xamarin.Forms;
using Enigmap.Vues;

namespace Enigmap.VuesModéles
{
    class DéfisVuesModéles : INotifyPropertyChanged
    {
        #region Attributs
        private ObservableCollection<Défis> _LesDéfis;

        #endregion

        #region Constructeurs
        public DéfisVuesModéles()
        {
            Task.Run(async () => await ListerDéfis());
        }

        #endregion

        #region Get - Set

        public ObservableCollection<Défis> LesDéfis
        {
            get
            {
                return _LesDéfis;
            }
            set
            {
                _LesDéfis = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Notification

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region commandes

        public ICommand BoutonJouer
        {
            get
            {
                return new Command(async () =>
                {
                    {
                        Application.Current.MainPage = new PageJouer();
                    }

                });
            }
        }

        public async Task ListerDéfis()
        {
            await ApiDéfis.GetDéfisAsync();
            LesDéfis = Défis.ListeDesDéfis();
        }

        #endregion

    }
}
