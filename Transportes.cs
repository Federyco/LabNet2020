using System;
using System.Collections.Generic;
using System.Text;

namespace Transport_Execution
{
    public abstract class Transportes
    {

        private int pasajeros {  get; }
        


        //constructor de la clase transportes basado en la cantidad de pasajeros y vehiculos
        public Transportes(int pasajeros)
        {
            this.pasajeros = pasajeros;
        }
        //utilizo el metodo getPasajeros publico para extraer el número de pasajeros desde la clase abstracta Transportes.
        public int GetPasajeros()
        {
            return pasajeros;
        }

        public abstract string Avanzar();

        public abstract string Detenerce();

        public interface IVehiculoTerrestre
        {
            bool _esTerrestre();    
        }
    }
    /* Las clases abstractas siempre poseen métodos abstractos.
     */
}
