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
            Persona p1 = new Persona("11111111");
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

            //string Saludo = "Hola";
            /*Persona persona1 = new Persona();
            Persona persona2 = persona1;
            persona1.Nombre = "María";
            persona1.Apellido = "Perez";

            Console.WriteLine($"Hola mi nombre es {persona1.Nombre} {persona1.Apellido} ");*/
            // desde la clase Program
            //Persona p2 = new Persona();

            //p2.saludar();

            /*Persona p3 = new Persona();
            p3.setDni("40276025");
            Console.WriteLine("El DNI es: {0}", p3.getDni());*/

            // Console.WriteLine("Bienvenido a mi cervecería!");
            // p3.setEdad(14);
            /*if (p3.getEdad() < 18)
            {
                Console.WriteLine("No tenes edad suficiente para ingresar");
            }
            else
            {
                Console.WriteLine("Tienes la edad suficiente");
            }
*/
            //p3.Nombre="Maxi";
            //Console.WriteLine("Bienvenido a mi cervecería {0}!",p3.Nombre);

            Console.ReadKey();
            
        }
    }
}
