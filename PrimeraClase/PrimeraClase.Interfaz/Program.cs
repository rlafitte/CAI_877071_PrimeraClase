using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeraClase.LibreriaClases;

namespace PrimeraClase.Interfaz
{
    class Program
    {
        static void Main(string[] args)
        {
            //cada proyecto tiene su propio assembly
            //sólo uno tiene un ejecutable, cada solución tiene un sólo ejecutable

            //para linkear los proyectos, tengo que usar las referencias en el solution explorer
            // la referencia sólo se debe crear en el proyecto que tenga el .exe, salvo que creemos más de un proyecto

            //Tomar variables (nro A, nro B, tipo operacion)
            // validaciones (TIENEN QUE ESTAR EN EL OTRO PROYECTO)
            // Procesar esas variables en un archivo que este en el otro proyecto
            // Consola viva, el programa no se puede terminar a menos que el usuario ingrese una X

            string s_nro1 = "";
            string s_nro2 = "";
            string s_ope = "";

            do
            {
                Console.WriteLine("Por favor ingrese un número:");
                s_nro1 = Console.ReadLine();
            } while (!Class1.ValidaNumero(s_nro1));

            do
            {
                Console.WriteLine("Por favor ingrese otro número:");
                s_nro2 = Console.ReadLine();
            } while (!Class1.ValidaNumero(s_nro2));

            do
            {
                Console.WriteLine("Por favor ingrese un operador:");
                s_ope = Console.ReadLine();

            } while (!Class1.ValidaOperador(s_ope));

            Console.ReadKey();
        }
    }
}
