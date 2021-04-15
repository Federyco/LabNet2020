using System;
using System.Collections.Generic;

namespace Transport_Execution
{
    class Program
    {
        static void Main(string[] args)
        {

            string ingreso = " ";
            int aviones = 5;
            int autos = 5;


            Console.WriteLine("#######################################################################################################################");
            Console.WriteLine("#                                             Ejercicio 1 Transportes                                                 #");
            Console.WriteLine("#                                         ******* Menu Principal ********                                             #");
            Console.WriteLine("#                                       Ingrese 1 para ver los resultados del día                                     #");
            Console.WriteLine("#                                       Para salir, ingrese un valor distinto de 1.                                   #");
            Console.WriteLine("#######################################################################################################################");
            ingreso = Console.ReadLine();
            //ingreso por teclado, menu principal.
            if (ingreso == "1")
            {
                Program.ListadoDeVehiculos(aviones, autos);
            }
            else 
            {
                Console.WriteLine("                                     Saliendo, gracias por utilizar el sistema.");
            }
            
        }

        private static void ListadoDeVehiculos(int aviones, int autos)
        {
           
            List<Transportes> vehiculos = new List<Transportes>
                {
                //cantidad de vehiculos ya que los pasajeros los genero de manera random en su correspondiente clase
                new Avion(aviones),
                new Automovil(autos)
             };
            
            foreach (var item in vehiculos)
            {
                Console.WriteLine(item.Avanzar());
                
            }
            
            foreach (var item in vehiculos)
            {
                Console.WriteLine(item.Detenerce());
            }            
            Console.ReadLine();
        }
    }
}
