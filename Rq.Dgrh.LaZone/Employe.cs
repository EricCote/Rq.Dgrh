using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rq.Dgrh.LaZone
{
    public class Employe
    {
        #region Champs
        private int salaire;
        #endregion

        #region Proprietes
        public string Nom { get; set; }
        public DateTime Embauche { get; set; }

        public int Salaire
        {
            get { return salaire; }
            set
            {
                if (value < 0)
                    throw new SalaireException("Pas de salaire négatif");
                salaire = value;
            }
        }
        #endregion

        #region Constructeurs
        public Employe() : this("Inconnu", DateTime.Now, 20000)
        {
        }

        public Employe(string nom, DateTime embauche, int salaire)
        {
            Nom = nom;
            Embauche = embauche;
            Salaire = salaire;
        }

        #endregion

        #region Methodes
        public void Afficher()
        {
            MessageBox.Show(string.Format("{0} gagne {1:c}", Nom,Salaire));
        }
        #endregion

    }
}
