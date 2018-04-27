using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App_20180414_Clases
{
    class Alumno
    {
        public String Rut;
        public String Nombre;
        public String Apellidos;
        public double Promedio;

        public Alumno()
        {
            Rut = "";
            Nombre = "";
            Apellidos = "";
            Promedio = 0.0;
        }

        public void LeerDatos()
        {
            try
            {
                Console.Write("Ingrese Rut:");
                Rut = Console.ReadLine();

                Console.Write("Ingrese Nombre:");
                Nombre = Console.ReadLine();

                Console.Write("Ingrese Apellidos:");
                Apellidos = Console.ReadLine();

                Console.Write("Ingrese Promedio:");
                Promedio = Convert.ToDouble(Console.ReadLine());


            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DesplegarDatos()
        {
            Console.WriteLine("{0}\t{1}\t{2}\t\t{3}", Rut, Nombre, Apellidos, Promedio);
        }
    }
}
