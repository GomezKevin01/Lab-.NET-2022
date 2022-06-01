using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
            Console.WriteLine($"Ingrese una opción, mediante numeros:");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    try
                    {
                        Console.WriteLine($"Ingrese un número:");
                        int numero = int.Parse(Console.ReadLine());
                        Divisiones.DividirPorCero(numero);
                        
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    Console.ReadLine();
                    break;
                    
                case 2:
                    try
                    {
                        Console.WriteLine($"Ingrese un número:");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Ingrese otro número:");
                        int num2 = int.Parse(Console.ReadLine());
                        Divisiones.DividirNumeros(num1, num2);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine($"Seguro Ingreso una letra o no ingreso nada!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    Console.ReadLine();
                    break;

                case 3:
                    try
                    {
                        Logic.DispararExceptionX();
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                    }                   
                    Console.ReadLine();
                    break;

                case 4:
                    try
                    {
                        Logic.CustomException();
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                    Console.ReadLine();
                    break;
            }

             void Menu()
            {
                Console.WriteLine($"(1) Método que divide por cero y devuelve un mensaje de excepción.");
                Console.WriteLine($"(2) Método que divide dos numeros y devuelve un mensaje de excepción si fallo algo.");
                Console.WriteLine($"(3) Método que muestra una excepción  X.");
                Console.WriteLine($"(4) Método que muestra mi excepción personalizada.");
            }
    }   }
}
