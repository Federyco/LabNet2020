using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_Transportes_2._0
{
    class Program
    {
        static void Main(string[] args)
        {


            ListManagement();
            Console.ReadLine();


        }

        private static void ListManagement() 
        {
            List<Transportes> Vechiculos = new List<Transportes>() {

                new Avion(100, 1),
                new Avion(86, 2),
                new Avion(64, 3),
                new Avion(50, 4),
                new Avion(95, 5),
                new Auto(4, 1),
                new Auto(3, 2),
                new Auto(3, 3),
                new Auto(1, 4),
                new Auto(1, 5)

            };

            foreach (var item in Vechiculos)
            {
                if (item.ToString().Contains("Auto"))
                {
                    Console.WriteLine($"Automóvil {item.vehicle_id} : {item.getPasajeros()} pasajeros y es Terrestre ");
                }
                else
                {
                    Console.WriteLine($"Avión {item.vehicle_id} : {item.getPasajeros()} pasajeros y es Aereo");
                }

            }
        }

   

    }
}
    
