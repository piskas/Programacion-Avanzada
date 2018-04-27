using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App_20180414_Struct
{
    class Program
    {
        struct Alumno {
            public String Rut;
            public String Nombre;
            public String Apellidos;
            public double Promedio;
        }

        static void Main(string[] args)
        {
            Alumno[] listaAlumnos = new Alumno[2];
            
            for (int i = 0; i < listaAlumnos.GetLength(0); i++)
            {
                Console.Write("Ingrese Rut:");
                listaAlumnos[i].Rut = Console.ReadLine();

                Console.Write("Ingrese Nombre:");
                listaAlumnos[i].Nombre = Console.ReadLine();

                Console.Write("Ingrese Apellidos:");
                listaAlumnos[i].Apellidos = Console.ReadLine();

                Console.Write("Ingrese Promedio:");
                listaAlumnos[i].Promedio = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Rut\tNombre\tApellidos\tPromedio");
            for (int i = 0; i < listaAlumnos.GetLength(0); i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t\t{3}", listaAlumnos[i].Rut, listaAlumnos[i].Nombre, listaAlumnos[i].Apellidos, listaAlumnos[i].Promedio);
            }

            Console.ReadKey();
        }
    }
}
