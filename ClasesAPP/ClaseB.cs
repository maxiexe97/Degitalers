using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAPP
{
    class ClaseB: ClaseA
    {
        public ClaseB(int n) : base(n) { }
        public ClaseB(string c) : base(c) { }
        public ClaseB(int n,string c): base(n)
        {
            Console.WriteLine(" La ClaseB recibió: {0}", c);
        }
    }

}
