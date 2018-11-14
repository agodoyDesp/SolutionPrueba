using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// La clase Program es una clase que tiene por objetivo
    /// mostrar en consola un Hola Mundo
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main es el método principal de la clase Program y
        /// es el método que se ejecuta al invocar el ejecutable
        /// </summary>
        /// <param name="args">
        /// Un arreglo de strings que contienen los
        /// parámetros de la aplicación
        /// </param>
        /// <returns> Se explica el valor retornado. En un procedimiento
        /// void esto no tiene sentido</returns>
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo");
            Console.ReadLine();
            Console.WriteLine("Hola Mundo2");
            Console.ReadLine();
        }
    }
}
