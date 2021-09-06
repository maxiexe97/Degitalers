using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAPP
{
    class ClaseC: object
    {
        public void imprimirMensaje()
        {
            Console.WriteLine(" Método imprimir de ClaseC ");
        }
        public override string ToString()
        {
            return " Método ToString() de la ClaseC";
        }
    }
}
