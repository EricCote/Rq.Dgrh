using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rq.Dgrh.LaZone
{
    public class Patron : Employe
    {
        public int Bonus { get; set; }

        //modification du code
        //deux techniques:  Override, member hiding

        public override void Afficher()
        {
           OnDisplay(this.ToString());
        }

        public override string ToString()
        {
            return base.ToString() + 
                string.Format( 
                    " et un bonus de {0:c0}",Bonus);
        }

        public Patron() : this("inconnu", DateTime.Now, 50000, 5000)
        {
        }

        public Patron(string nom, DateTime embauche, int salaire, int bonus)
            : base(nom, embauche, salaire)
        {
            Bonus = bonus;
        }

    }
}
