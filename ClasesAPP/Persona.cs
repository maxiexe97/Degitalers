using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAPP
{
    class Persona
    {
     
       public string Nombre { get; set; }
       public string Apellido { get; set; }
       
        private int edad; 
       private string dni;

       /* public void setDni(string dni_param)
        {
            dni = dni_param;
        }*/
        public string getDni()
        {
            return dni;
        }

        public void setEdad(int edad_param)
        {
            edad = edad_param;
           /* if (edad_param < 18)
            {
                Console.WriteLine("No tenes edad suficiente para ingresar");
                edad = 0;
            }
            else
            {
                Console.WriteLine("Tienes la edad suficiente");
            }*/

        }
        public int getEdad()
        {
            return edad;
        }

        public Persona(string dni_param)
        {
            dni = dni_param;
        }





    }
}
