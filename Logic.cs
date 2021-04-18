using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionsAndExceptions
{
    class Logic
    {

        public static void Punto3()
        {
            int numero1 = 25;
            int numero2 = 0;
            double resultado = 0;

            try
            {
                resultado = numero1 / numero2;
            }
            catch (DivideByZeroException ex)
            
            {
                Console.WriteLine($"\nMensaje Específico: {ex.Message}");
                Console.WriteLine($"\nMensaje de excepción específica: {ex.GetType()}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nMensaje general: {ex.Message}");
                Console.WriteLine($"\nMensaje de excepción general: {ex.GetType()}");
            }
        

        }
        public static void Punto4()
        {
            int numero1 = 25;
            int numero2 = 0;
            double resultado = 0;

            try
            {
                resultado = numero1 / numero2;
            }
            catch (Exception)

            {
                throw new CustomExceptions();

            }

        }

    }
}
