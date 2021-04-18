using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionsAndExceptions
{
    public class CustomExceptions : Exception
    {
        public CustomExceptions() : base("De verdad, lo intenté, pero no se puede dividir por cero")
        { 
            
        }

    }
}
