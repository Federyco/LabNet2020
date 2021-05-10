using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF.UI
{
    //extiende de Exceptions
    public class CustomMyExceptions : Exception
    {
        //constructor
        public CustomMyExceptions(string mensaje = "Practica con Excepciones") : base(mensaje)
        { 
        
        }
    }
}
