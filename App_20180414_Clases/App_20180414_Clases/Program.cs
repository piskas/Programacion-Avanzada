using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App_20180414_Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno[] listaAlumnos = new Alumno[2];

            for (int i = 0; i < listaAlumnos.GetLength(0); i++)
            {
                do
                {
                    try
                    {
                        Alumno al = new Alumno();
                        al.LeerDatos();
                        listaAlumnos[i] = al;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Se ha producido la excepcion: {0}", ex.Message);
                    }
                } while (listaAlumnos[i] == null);
            }

            Console.WriteLine("Rut\tNombre\tApellidos\tPromedio");
            for (int i = 0; i < listaAlumnos.GetLength(0); i++)
            {
                listaAlumnos[i].DesplegarDatos();
            }

            Console.ReadKey();
        }
    }
}
