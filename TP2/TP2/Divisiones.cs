using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class Divisiones
    {

        public static void DividirPorCero(int numero)
        {
            try
            {
                int resultado = numero / 0;
                Console.WriteLine($"NUNCA VA A PASAR POR ACA");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"OPERACIÓN FALLIDA");
                Console.WriteLine(ex.Message);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"OPERACIÓN FALLIDA");
                Console.WriteLine(ex.Message);
            }
        }

        public static void DividirNumeros(int num1, int num2)
        {
            try
            {
                int resultado = num1 / num2;
                Console.WriteLine($"El resultado de {num1} / {num2} es {resultado}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"OPERACIÓN FALLIDA");
                Console.WriteLine($"Solo Chuck Norris divide por cero!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"OPERACIÓN FALLIDA");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
