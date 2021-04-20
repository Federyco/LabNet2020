using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_Transportes_2._0
{
    //auto hereda de transportes
    public class Auto : Transportes
    {
        //constructor de la clase Auto recibe(pasajeros y un Id de vehiculo) : base heredada (pasajeros, id de vehiculo)
        public Auto(int pasajerosAuto, int id) : base(pasajerosAuto, id)
        { 
        
        
        }

        public override string Avanzar() 
        {
            return $"Avanza el auto {vehicle_id} con {getPasajeros()} pasajeros";
        }
        public override string Detenerse()
        {
            return $"El auto {vehicle_id} se detuvo";
        }
        public bool _esTerrestre()
        {
            return true;
        }

    }
}
