using System;
using System.Collections.Generic;
using System.Text;
using Transport_Execution;

namespace Transport_Execution
{

    // avion hereda transportes y luego separado por comas, las interfaces
    public class Avion : Transportes, Transportes.IVehiculoTerrestre
    {

        private Random randm = new Random();

        public Avion(int cantDeVehiculos) : base(cantDeVehiculos)
        {
            
        }
        public override string Avanzar()
        {

            int pasajerosAvion;
            int totalAvion = 0;

            Console.WriteLine("#######################################################################################################################");
            //devuelvo una interpolación
            for (int i = 1; i < (cantDeVehiculos + 1); i++)
            {
                pasajerosAvion = randm.Next(1, 200);
                totalAvion += pasajerosAvion;
               
                Console.WriteLine($"#                                       El Avión {i} avanza con {pasajerosAvion} pasajeros                                           #");
               
            }
            Console.WriteLine("#######################################################################################################################");
            return $"                                 El total de pasajeros que viajaron en avión es: {totalAvion}";
        }
        public override string Detenerce()
        {
            int pos_avion = randm.Next(1, 5);
            int[] numeroDeNave =
            {
                1,
                2,
                3,
                4,
                5
            };
            //devuelvo una interpolación
            return $"                                        El avion {numeroDeNave[pos_avion]} se ha detenido";

        }

        public bool _esTerrestre()
        {
            return false;
        }
    }

    /*Las interfaces son estructuras obligatorias que son heredadas y deben ser implementadas dentro de las clases hijo. En su inicio no debe ser desarrollada 
    sólo indicar los métodos que deben ser usados y desarrollados en sus respectivas clases.
    Clase padre Transportes = aqui se crea la interface de manera publica para que pueda ser utilizada desde cualquier otro punto.
    Clases hijo (Avion y Automóvil) = aqui se instancia la interface creada en la clase padre, y desarrolla finalizando con un return.
     */

}
