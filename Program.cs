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
                System.Console.Clear();
                Program.ListadoDeVehiculos(aviones, autos);
               
            }
            else 
            {
                Console.WriteLine("                                     Saliendo, gracias por utilizar el sistema.");
            }
        }


        private static void ListadoDeVehiculos(int aviones, int autos)
        {
            Avion avionsito = new Avion(5);
            Automovil autito = new Automovil(5);
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
            Console.WriteLine("Implementación de la interface 'IVehiculoTerrestre'");
            if (avionsito._esTerrestre() == false)
            {
                Console.WriteLine("Los Aviones son Transportes aereos");
            }
            if (autito._esTerrestre() == true)
            {
                Console.WriteLine("Los Automóviles son Transportes terrestres");
            }
            Console.ReadLine();
        }
    }
}
