using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionsAndExceptions
{
    public class Punto1
    {
        public static void ExceptionPuntoUnoyDos()
        {
            string variable1 = " ";
            string variable2 = " ";
            int parsevar1 = 0;
            int parsevar2 = 0;
            int resultado = 0;
            bool bloqueo1 = true;
            bool bloqueo2 = true;

            Console.WriteLine("A continuación, Ingrese los 2 valores que serán utilizados para calcular la razón entre ellos");
            // Mientras el bloqueo este activo va a serguir piriendo el valor de la variable 1
            // los siguientes bloques while corresponden a la validación de ingreso por teclado
            while (bloqueo1 == true)
            {
                variable1 = Console.ReadLine();
                if (emIAnInteger(variable1) == true)
                {

                    Console.WriteLine("Valor 1 ingresado exitosamente");
                    Console.WriteLine("Ingrese el valor 2, y presione Enter para continuar");
                    bloqueo1 = false;
                }
                else
                {
                    ArgumentNullException argumento = new ArgumentNullException();
                    Console.WriteLine(argumento.Message);
                    Console.WriteLine(argumento.StackTrace);
                    Console.WriteLine("Ingreso no válido, sólo se permiten números, intente nuevamente");
                    bloqueo1 = true;
                }
            }
            while (bloqueo2 == true)
            {
                variable2 = Console.ReadLine();
                if (emIAnInteger(variable2) == true)
                {
                    Console.WriteLine("Valor 2 ingresado exitosamente");
                    bloqueo2 = false;
                }
                else
                {
                    Console.WriteLine("Ingreso no válido, sólo se permiten números, intente nuevamente");

                    bloqueo2 = true;
                }
            }


            try
            {
                parsevar1 = Convert.ToInt32(variable1);
                parsevar2 = Convert.ToInt32(variable2);
                resultado = parsevar1 / parsevar2;


            }

            catch (Exception ex)
            {
                Console.WriteLine($"\nMensaje propio: {ex.Message}");
                Console.WriteLine($"\nStrack Trace: {ex.StackTrace}");
                Console.WriteLine("\nLas divisiones por 0, no están permitidas.");
                Console.WriteLine("\nSolo Chuck Norris divide por cero!");
            }

            finally
            {
                if (parsevar2 != 0)
                {
                    Console.WriteLine("\nOperación exitosa");
                    Console.WriteLine($"\nEl resultado es {resultado}");
                }
                else
                {
                    Console.WriteLine("\nLa operación Falló");
                }
            }







        }
        // utilizo un método para chequear si el ingreso es válido
        public static bool emIAnInteger(string input)
        {
            int number = 0;
            try
            {
                return int.TryParse(input, out number);
            }
            
            catch (Exception ex)
            {
                throw ex;
            }
            

        }

    }
}
