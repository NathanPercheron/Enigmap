using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Enigmap.Modéles
{
    class Défis
    {

        #region Attributs
        private int _id;
        private string nomDefis;
        private string descriptionDefis;

        public static ArrayList CollClassDéfis = new ArrayList();



        #endregion

        #region Constructeurs
        public Défis(int id, string NomDefis, string DescriptionDefis)
        {
            _id = id;
            nomDefis = NomDefis;
            descriptionDefis = DescriptionDefis;

            CollClassDéfis.Add(this);
        }

        #endregion

        #region Get-set
        public int Id { get => _id; set => _id = value; }
        public string NomDefis { get => NomDefis; set => NomDefis = value; }
        public string DescriptionDefis { get => descriptionDefis; set => descriptionDefis = value; }

        #endregion

        #region Méthodes

        public static ObservableCollection<Défis> ListeDesDéfis()
        {
            ObservableCollection<Défis> resultat = new ObservableCollection<Défis>();

            foreach (Défis _LeDéfis in Défis.CollClassDéfis)
            {
                resultat.Add(_LeDéfis);
            }

            return resultat;
        }


        #endregion

    }
}
