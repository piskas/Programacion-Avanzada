using System;
using System.Data;
using System.Data.OleDb;

namespace App_20180421_InsertarDB
{
    class Program
    {
        static void Main(string[] args)
        {
            string strConnection = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=PrograAV_20180421;Data Source=.";
            string strQuery = "";
            OleDbConnection connection = new OleDbConnection(strConnection);
            OleDbCommand command = new OleDbCommand("", connection);
            
            string rut = "", nombre = "", apellido = "", respuesta = "";
            float promedio;
            bool continua = true;

            try
            {
                while (continua)
                {
                    Console.Clear();
                    Console.WriteLine("============== Ingreso de Datos de Alumnos ==============\n");

                    Console.Write("Ingrese Rut:");
                    rut = Console.ReadLine();

                    Console.Write("Ingrese Nombre:");
                    nombre = Console.ReadLine();

                    Console.Write("Ingrese Apellido:");
                    apellido = Console.ReadLine();

                    Console.Write("Ingrese Promedio:");
                    promedio = float.Parse(Console.ReadLine());


                    // Se escribe la consulta
                    strQuery = String.Format("INSERT INTO ALUMNOS VALUES('{0}','{1}','{2}',{3})",
                        rut,
                        nombre,
                        apellido,
                        promedio);

                    command.CommandText = strQuery;
                    if (connection.State != ConnectionState.Open)
                        connection.Open();


                    // Se verifica estado de conexion
                    if (connection.State == ConnectionState.Open)
                    {
                        int contadorDatos = command.ExecuteNonQuery();

                        if (contadorDatos == 0)
                            Console.WriteLine("Los datos no fueron insertador en la tabla alumno");
                        else
                            Console.WriteLine("Los datos se insertaron correcatmente");
                    }
                    else
                    {
                        Console.WriteLine("La conexion no se ha podido establecer");
                    }


                    do
                    {
                        Console.Clear();
                        Console.Write("\n\nDesea ingresar otro alumno [S/N]:");
                        respuesta = Console.ReadLine().Trim().ToUpper();

                        if (respuesta.Equals("S"))
                            continua = true;
                        else if (respuesta.Equals("N"))
                            continua = false;
                        else
                        {
                            Console.WriteLine("Respuesta erronea debe ser S o N");
                            Console.ReadKey();
                        }
                    } while (!respuesta.Equals("S") && !respuesta.Equals("N"));
                    connection.Close();
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
