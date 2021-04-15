using System;
using System.Collections.Generic;
using System.Text;

namespace Transport_Execution
{
    // auto hereda transportes y luego separado por comas, las interfaces
    public class Automovil : Transportes, Transportes.IVehiculoTerrestre
    {

        private Random randm = new Random();

        public Automovil(int cantDeVehiculos) : base(cantDeVehiculos)
        {
            
        }
        public override string Avanzar()
        {

            int pasajerosAuto;
            int totalAutos=0;
            //impresiones den pantalla por bucle for
            Console.WriteLine("#######################################################################################################################");
            for (int i = 1; i < (cantDeVehiculos + 1); i++)
            {
                pasajerosAuto = randm.Next(1, 5);
                totalAutos += pasajerosAuto;
                Console.WriteLine($"#                                       El auto {i} avanza con {pasajerosAuto} pasajeros                                              #");
            }
            Console.WriteLine("#######################################################################################################################");
            return $"                                 El total de pasajeros que viajaron en auto es: {totalAutos}";
        }
        public override string Detenerce()
        {
            int pos_auto = randm.Next(1, 5);
            int[] numeroDeAuto =
            {
                1,
                2,
                3,
                4,
                5
            };
            //devuelvo una interpolación
            return $"                                        El Auto {numeroDeAuto[pos_auto]} se ha detenido";
        }
        public bool _esTerrestre()
        {
            return true;
        }

    }

    /*Las interfaces son estructuras obligatorias que son heredadas y deben ser implementadas dentro de las clases hijo. En su inicio no debe ser desarrollada 
   sólo indicar los métodos que deben ser usados y desarrollados en sus respectivas clases.
   Clase padre Transportes = aqui se crea la interface de manera publica para que pueda ser utilizada desde cualquier otro punto.
   Clases hijo (Avion y Automóvil) = aqui se instancia la interface creada en la clase padre, y desarrolla finalizando con un return.
    */
}
