using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App_20180407_Arreglos
{
    class Program
    {
        public static void Main()
        {
            int[,,] buses = new int[3, 5, 40];
            string respuesta = "S";
            int i, j, k, valor = 0, total = 0;

            try {
                while (respuesta == "S")
                {
                    try {
                        Console.Write("Ingrese n°Sucursal:");
                        i = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Ingrese n°Bus:");
                        j = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Ingrese n°Asiento:");
                        k = Convert.ToInt32(Console.ReadLine());
                        
                        if (i > 3 || i <= 0)
                            throw new Exception("N° Sucursal fuera de rango\n");
                        if (j > 5 || j <= 0)
                            throw new Exception("N° Bus fuera de rango\n");
                        if (k > 40 || k <= 0)
                            throw new Exception("N° Asiento fuera de rango\n");
                        
                        Console.Write("Ingrese 1, No Disponible:");
                        valor = Convert.ToInt32(Console.ReadLine());
                        
                        if (valor!=1)
                            throw new Exception("N° no Valido");

                        buses[i - 1, j - 1, k - 1] = valor;
                        Console.Write("Desea Continuar S/N");
                        respuesta = Console.ReadLine().Trim().ToUpper();

                    }
                    catch(Exception e)
                    {
                        Console.Write(e.Message);
                    }
                }
                for (i = 0; i < buses.GetLength(0); i++)
                {
                    for(j = 0; j < buses.GetLength(0); j++)
                    {
                        for (k = 0; k < buses.GetLength(0); k++)
                            if (buses[i, j, k] == 0)
                                total += 1;
                    }
                    Console.Write("Total de asientos disponibles sucursal {0} es {1}", i + 1, total);
                    total = 0;
                }
            }
            catch(Exception e)
            {
                Console.Write(e.Message);
            }
        }
    }
}
