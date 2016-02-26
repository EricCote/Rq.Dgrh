using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rq.Dgrh
{
    public class LecteurMp3 : ILecteur
    {
        public void Play(int noPiste)
        {
            MessageBox.Show(String.Format("Lecteur MP3 joue la piste {0}",
                                                                noPiste));
        }

        public void Stop()
        { MessageBox.Show("Lecteur MP3 Arrête"); }

        public void Sync()
        { MessageBox.Show("Lecteur MP3 se synchronise sur le PC"); }
    }
}
