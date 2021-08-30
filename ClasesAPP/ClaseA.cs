using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAPP
{
    class ClaseA
    {
        public ClaseA(int n)
        {
            Console.WriteLine(" Entero recibido: {0}",n);
        }
        public ClaseA(string c)
        {
            Console.WriteLine(" String recibido: {0}", c);
        }
        public ClaseA(double num)
        {
            Console.WriteLine(" numero recibido: {0}",num);
        }
    }
}
