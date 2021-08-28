using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAPP
{
    class Persona
    {
       private string Nombre;
       private string Apellido;
       private string dni;

        public void setDni(string dni_param)
        {
            dni = dni_param;
        }
        public string getDni()
        {
            return dni;
        }

        public void saludar()
        {
            Console.WriteLine("Hola Mundo!");
        }
    }
}
