using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            string Saludo = "Hola";
            /*Persona persona1 = new Persona();
            Persona persona2 = persona1;
            persona1.Nombre = "María";
            persona1.Apellido = "Perez";

            Console.WriteLine($"Hola mi nombre es {persona1.Nombre} {persona1.Apellido} ");*/
           // desde la clase Program
            Persona p2 = new Persona();
            //p2.saludar();

            Persona p3 = new Persona();
            p3.setDni("40276025");
            Console.WriteLine("El DNI es: {0}", p3.getDni());

            Console.ReadKey();
        }
    }
}
