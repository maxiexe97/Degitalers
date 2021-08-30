using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAPP
{
    class Empleado
    {
        public string Nombre { get; set; }
        public int Legajo { get; set; }
        protected double Sueldo;

        public virtual void setSueldo(double s)
        {
            Sueldo = s;
        }
        public double getSueldo()
        {
            return Sueldo;
        }

        public virtual string MetodoPadre()
        {
            return "Hola ";
        }


        public void Trabajar()
        {
            Console.WriteLine("Estoy trabajando como un Empleado");
        }
    }
}
