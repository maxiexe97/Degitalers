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
            /* Persona p1 = new Persona("11111111");
             Persona p2 = new Persona("22222222");
             Persona p3 = new Persona("33333333");

             p1.Nombre = "Juan";
             p1.setEdad(20);
             p2.Nombre = "Ramiro";
             p2.setEdad(24);
             p3.Nombre = "Lucia";
             p3.setEdad(33);

             Console.WriteLine("Nombre: {0}, Edad: {1}, DNI: {2}", p1.Nombre, p1.getEdad(), p1.getDni());
             Console.WriteLine("Nombre: {0}, Edad: {1}, DNI: {2}", p2.Nombre, p2.getEdad(), p2.getDni());
             Console.WriteLine("Nombre: {0}, Edad: {1}, DNI: {2}", p3.Nombre, p3.getEdad(), p3.getDni());
             */

            //Persona p1 = new Persona();
            //Persona p2 = new Persona("111111111");
            //Persona p3 = new Persona("22222222",34);
            
            //Desde la clase Program.cs
            Administrativo a1 = new Administrativo();
            a1.Nombre = "Roberto";
            a1.Legajo = 22837;
            a1.setSueldo(30000);

            Vendedor v1 = new Vendedor();
            v1.Nombre = "Marcos";
            v1.Legajo = 267647;
            v1.setSueldo(20000);

            Console.WriteLine("Nombre: {0}, Leg.: {1}, Sueldo: ${2}", a1.Nombre, a1.Legajo, a1.getSueldo());
            Console.WriteLine("\nNombre: {0}, Leg.: {1}, Sueldo: ${2}", v1.Nombre, v1.Legajo, v1.getSueldo());

            Console.ReadKey();
            
        }
    }
}
