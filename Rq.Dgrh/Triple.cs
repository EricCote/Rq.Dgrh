using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rq.Dgrh
{
    public class Triple<T,U,V>
    {
        public T A { get; set; }
        public U B { get; set; }
        public V C { get; set; }

        public Triple(T a, U b, V c)
        {
            A = a;
            B = b;
            C = c;
        }
    }
}
