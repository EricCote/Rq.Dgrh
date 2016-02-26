using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rq.Dgrh
{
    public class LecteurCd : ILecteur, IDisposable
    {
        public void Play(int noPiste)
        { MessageBox.Show(String.Format("Lecteur cd joue la piste {0}", 
                                                              noPiste)); }
        public void Stop()
        { MessageBox.Show("lecteur CD Arrête"); }

        public void Eject()
        { MessageBox.Show("lecteur CD éjecte le disque"); }

        void IDisposable.Dispose()
        {
            Eject();
        }
    }
}
