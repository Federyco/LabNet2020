using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_Transportes_2._0
{
    public abstract class Transportes
    {
        private int pasajeros {get;}

        public int getPasajeros() {

            return this.pasajeros;
        }
        public int vehicle_id { get; }

        //constructor de la clase Transportes
        public Transportes(int pasajerosxvehiculo, int id_vehiculo)
        {
            this.pasajeros = pasajerosxvehiculo;
            this.vehicle_id = id_vehiculo;
        }

        public abstract string Avanzar();
        public abstract string Detenerse();

    }

    public interface IVehiculoTerrestre
    {
        bool _esTerrestre();
    }
}
