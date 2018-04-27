using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App
{
    class Program
    {
        // Ejercicio 1
        public static void Main()
        {
            string nombre = "";
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola {0}", nombre);
            Console.WriteLine("Presione una tecla");
            Console.ReadKey();
            Console.Clear();
        }

        //// Ejercicio 2
        //public static void Main(string[] args)
        //{
        //    if (args.Length == 1)
        //    {
        //        Console.WriteLine("Hola " + args[0] + "!!");
        //    }
        //    else if (args.Length > 1)
        //    {
        //        for (int i = 0; i < args.Length; i++)
        //            Console.WriteLine("Hola " + args[i]);
        //    } 
        //    else 
        //    {
        //        Console.WriteLine("Hola raton con cola");
        //    }
        //    Console.ReadKey();
        //}

        // Ejercicio 3

    }
}
