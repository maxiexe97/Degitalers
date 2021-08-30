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


            //Desde la clase Program.cs
            /* Administrativo a1 = new Administrativo();
             a1.Nombre = "Roberto";
             a1.Legajo = 22837;
             a1.setSueldo(30000);*/

            /* Vendedor v1 = new Vendedor();
             v1.Nombre = "Marcos";
             v1.Legajo = 267647;
             v1.setSueldo(20000);*/

            //Console.WriteLine("Nombre: {0}, Leg.: {1}, Sueldo: ${2}", a1.Nombre, a1.Legajo, a1.getSueldo());
            //Console.WriteLine("\nNombre: {0}, Leg.: {1}, Sueldo: ${2}", v1.Nombre, v1.Legajo, v1.getSueldo());

            //Vendedor v1 = new Vendedor();
            //Console.WriteLine(v1.MetodoPadre());

            // v1.Ventas = 1000000;
            //v1.setSueldo(20000);
            //Console.WriteLine("Sueldo del vendedor: ${0}", v1.getSueldo());

            //ClaseA ca = new ClaseA(5);

            //en Program.cs
            //ClaseB cb1 = new ClaseB(12);
            //ClaseB cb2 = new ClaseB(" Saludos! ");
            ClaseB cb2 = new ClaseB(1234,"CadenaLoca");


            //ClaseB cb3 = new ClaseB(3.14);


            Console.ReadKey();
            
        }
    }
}
