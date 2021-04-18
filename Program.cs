using ExtensionsAndExceptions;
using System;

namespace ExtensionsAndExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Punto Uno y Dos");
            Punto1.ExceptionPuntoUnoyDos();
            Console.WriteLine("\n");



            Console.WriteLine("\nPunto 3");
            try
            {
                Logic.Punto3();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
            Console.WriteLine("\n");


            Console.WriteLine("\nPunto 4");
            Logic.Punto4();
            Console.WriteLine("\n");
        }
       
    }
}

