using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.UI.WebControls;
using win = System.Windows.Forms;
using web = System.Web.UI.WebControls;
using System.IO;
using System.Drawing;

namespace Rq.Dgrh.LaZone
{

    //public delegate void Affichage(string msg);

    public partial class Employe:IDisposable
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

        //Deux delegate generiques: Action et Func
        #region Delegates and events
        public event Action<string> Display;
        #endregion 

        #region Proprietes
        public Bitmap Photo { get; set; }
        public string Nom { get; set; }
        public DateTime Embauche { get; set; }

        public int Salary
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
            Salary = salaire;
        }

        #endregion

        #region Methodes

        protected virtual void OnDisplay(string msg)
        {
            if (Display != null)
            {
                Display(msg);
            }
       
        }
        public void test555(int nombre)
        {
        }


        public async virtual void Afficher()
        {
            List<Task> taches = new List<Task>();
            taches.Add(Task.Delay(1000));
            taches.Add(Task.Delay(1000));
            taches.Add(Task.Delay(1000));
            taches.Add(Task.Delay(1000));
            taches.Add(Task.Delay(1000));
            taches.Add(Task.Delay(1000));
            taches.Add(Task.Delay(1000));
            taches.Add(Task.Delay(1000));

            await Task.WhenAll(taches);

            OnDisplay(this.ToString());
           
        }

        public override string ToString()
        {
            return string.Format("{0} gagne {1:c}",Nom,Salary);
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

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    Photo.Dispose();
                }

                Photo = null;
                disposedValue = true;
            }
        }


        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
        
        }
        #endregion


        #endregion

    }
}
