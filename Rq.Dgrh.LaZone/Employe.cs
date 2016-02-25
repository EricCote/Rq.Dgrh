using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.UI.WebControls;
using win=System.Windows.Forms;
using web=System.Web.UI.WebControls;

namespace Rq.Dgrh.LaZone
{
    public class Employe
    {
        #region Champs
        private int salaire;
        #endregion

        #region Static
        public static string NomCompagnie { get; set; }

        static Employe()
        {
            NomCompagnie = "Revenu Québec";
        }
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
        public virtual void Afficher()
        {
            MessageBox.Show(this.ToString());
        }

        public override string ToString()
        {
            return string.Format("{0} gagne {1:c}",Nom,Salaire);
        }






        public void test()
        {
            int x=5, y ;
            y = doubler( x);
            MessageBox.Show(string.Format("{0} doublé est: {1}", x, y));

        }

        public double doubler(double n)
        {
            double result = n * 2;
            return  result;
        }

        public int doubler(int n)
        {
            int result = n * 2;
            return result;
        }


        #endregion

    }
}
