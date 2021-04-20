using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_Transportes_2._0
{
    public class Avion : Transportes
    {
        //constructor de la clase Avion recibe(pasajeros y un Id de vehiculo) : base heredada (pasajeros, id de vehiculo)
        public Avion(int pasajerosAuto, int id) : base(pasajerosAuto, id)
        {


        }

        public override string Avanzar()
        {
            return $"Avanza el Avion {vehicle_id} con {getPasajeros()} pasajeros";
        }
        public override string Detenerse()
        {
            return $"El Avion {vehicle_id} se detuvo";
        }
        public bool _esTerrestre()
        {
            return false;
        }
    }
}
