using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Modeles
{
    public class Coureur
    {
        #region Attributs

        public static List<Coureur> CollClasse = new List<Coureur>();

        private string _nom;
        private string _prenom;
        private DateTime _dateNaissance;
        private string _sexe;
        private string _email;
        private string _numeroTelephone;


        #endregion

        #region Constructeurs

        public Coureur(string nom, string prenom, DateTime dateNaissance, string sexe, string email, string numeroTelephone)
        {
            _nom = nom;
            _prenom = prenom;
            _dateNaissance = dateNaissance;
            _sexe = sexe;
            _email = email;
            _numeroTelephone = numeroTelephone;

            Coureur.CollClasse.Add(this);
        }

        #endregion

        #region Getters/Setters

        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set =>_prenom = value; }
        public DateTime DateNaissance { get => _dateNaissance; set => _dateNaissance = value; }
        public string Sexe { get => _sexe; set => _sexe = value; }
        public string Email { get => _email; set => _email = value; }
        public string NumeroTelephone { get => _numeroTelephone; set => _numeroTelephone = value; }


        #endregion

        #region Methodes

        // Vous pouvez ajouter des méthodes spécifiques à la classe ici.

        #endregion
    }
}
