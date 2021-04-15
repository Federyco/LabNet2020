using System;
using System.Collections.Generic;
using System.Text;

namespace Transport_Execution
{
    public abstract class Transportes
    {
        public int cantDeVehiculos;


        //constructor de la clase transportes basado en la cantidad de pasajeros y vehiculos
        public Transportes(int cantDeVehiculos)
        {
            this.cantDeVehiculos = cantDeVehiculos;
        }

        public abstract string Avanzar();

        public abstract string Detenerce();

        public  interface IVehiculoTerrestre
        {
            bool _esTerrestre();    
        }
    }
    /* Las clases abstractas siempre poseen métodos abstractos.
     */
}
