using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App_20180421_Conexion
{
    class Program
    {
        static void Main(string[] args)
        {
            string strConnection = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=20180421_PrograAV;Data Source=.";
            string strQuery = "";

            OleDbConnection connection = new OleDbConnection(strConnection);
            OleDbCommand command = new OleDbCommand("", connection);
            OleDbDataReader reader;

            try
            {
                strQuery = "SELECT * FROM Alumnos";
                command.CommandText = strQuery;
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    int contadorDatos = 0;
                    reader = command.ExecuteReader();

                    Console.WriteLine("========================================== Lista de Alumnos ==========================================");
                    Console.WriteLine(" \t    Rut\t\t\t Nombre\t\t\tApellido\t\tPromedio");
                    Console.WriteLine("======================================================================================================");
                    //Console.WriteLine(" \t===\t\t\t======\t\t\t========\t\t========");

                    while (reader.Read())
                    {
                        Console.WriteLine(" \t{0}\t\t{1}\t\t{2}\t\t\t{3}",
                            reader.GetString(0).Trim(),
                            reader.GetString(1).Trim(),
                            reader.GetString(2).Trim(),
                            reader.GetValue(3).ToString().Trim());
                        contadorDatos++;
                    }
                    if (contadorDatos == 0)
                        Console.WriteLine("No hay datos en la tabla alumno");
                }
                else
                {
                    Console.WriteLine("La conexion no se ha podido establecer");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Se ha producido la excepcion: {0}", ex.Message);
            }

            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            Console.ReadKey();
        }
    } 
}