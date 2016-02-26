using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rq.Dgrh
{
    public interface ILecteur
    {
        void Play(int noPiste);
        void Stop();
    }
}
