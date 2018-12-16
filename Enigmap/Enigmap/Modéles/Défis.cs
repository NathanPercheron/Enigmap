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
        private string _nom_defis;
        private string _description_defis;

        public static ArrayList CollClassDéfis = new ArrayList();



        #endregion

        #region Constructeurs
        public Défis(int id, string nom_defis, string description_defis)
        {
            _id = id;
            _nom_defis = nom_defis;
            _description_defis = description_defis;

            CollClassDéfis.Add(this);
        }

        #endregion

        #region Get-set
        public int Id { get => _id; set => _id = value; }
        public string Nom_defis { get => _nom_defis; set => _nom_defis = value; }
        public string Description_defis { get => _description_defis; set => _description_defis = value; }

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
