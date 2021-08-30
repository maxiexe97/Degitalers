using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAPP
{
    class Administrativo : Empleado
    {
        private const double bono = 2000;

        public override void setSueldo(double s)
        {
            Sueldo = s + bono;
        }
    }
}
