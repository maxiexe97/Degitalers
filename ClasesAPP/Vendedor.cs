using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAPP
{
    class Vendedor : Empleado
    {
        public double Ventas { get; set; }
        public override void setSueldo(double s)
        {
            Sueldo = s + (Ventas * 0.01);

        }

        public override string MetodoPadre()
        {
            return base.MetodoPadre() + "Mundo";
        }
    }
}
