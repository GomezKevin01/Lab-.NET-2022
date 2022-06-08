using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.EF.Logic;

namespace TP4.EF.UI
{
    internal class Program
    {
        static int op;
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            EmployeesLogic employees = new EmployeesLogic();
            SupplitersLogic suppliters = new SupplitersLogic();           
            try
            {
                Console.WriteLine($"(1) Muestra a todos los empleados.");
                Console.WriteLine($"(2) Muestra a todos los proveedores.");
                Console.WriteLine($"\nIngrese una opción, mediante numeros:");
                op = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                op = 999;
                Console.ReadLine();
            }

            switch (op)
            {
                case 1:
                    try
                    {
                        Console.WriteLine($"\nNombre y apellido de los empleados:");
                        foreach (var item in employees.GetAll())
                        {
                            Console.WriteLine($"{item.FirstName} {item.LastName}");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    Console.ReadLine();
                    Console.Clear();
                    Menu();
                    break;

                case 2:
                    try
                    {
                        Console.WriteLine($"\nProveedores:");
                        foreach (var item in suppliters.GetAll())
                        {
                            Console.WriteLine($"\nNombre: {item.CompanyName}\nPais: {item.Country}\nCiudad: {item.City}\nDirección: {item.Address}");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    Console.ReadLine();
                    Console.Clear();
                    Menu();
                    break;

                default:
                    Console.Clear();
                    if(op != 999)
                    Console.WriteLine($"Opción invalida, seleccione la opción deseada nuevamente.\n\n");
                    Menu();
                    break;
            }
        }
    }
}
