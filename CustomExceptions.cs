using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionsAndExceptions
{
    public class CustomExceptions : Exception
    {
        public static string mensaje_predefinido = "Estimado Usuario: ";

        public CustomExceptions() : base(message: $"{mensaje_predefinido} De verdad, lo intenté, pero no se puede dividir por cero")
        { 
            
        }

    }
}
