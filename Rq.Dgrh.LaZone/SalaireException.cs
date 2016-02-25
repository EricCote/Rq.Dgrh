using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rq.Dgrh.LaZone
{


    public class SalaireException : Exception
    {
        public SalaireException() { }
        public SalaireException(string message) : base(message) { }
        public SalaireException(string message, Exception inner) : base(message, inner) { }

    }

}
