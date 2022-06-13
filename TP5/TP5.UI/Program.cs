using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Entities;
using TP5.Logic;

namespace TP5.UI
{
    internal class Program
    {
        static int op;
        static void Main(string[] args)
        {
            Opciones();
        }

        static void Opciones()
        {
            try
            {
                Console.WriteLine($"(2) Mostrar productos sin stock.");
                Console.WriteLine($"(3) Mostrar productos con stock y con un costo mayor a 3$.");
                Console.WriteLine($"(4) Mostrar customers de la Región WA.");
                Console.WriteLine($"(5) Mostar el primer elemento o nulo de una lista de productos" +
                                  $" donde el ID del producto sea igual a 789.");
                Console.WriteLine($"(6) Mostrar nombres de los Customers en mayuscula y minuscula.");
                Console.WriteLine($"(7) Mostrar Join entre Customers y Orders donde los customers sean");
                Console.WriteLine($"    de la Región WA y la fecha de orden sea mayor a 1 / 1 / 1997.");
                Console.WriteLine($"(0) Salir.");
                Console.Write($"\nIngrese una opción, mediante numeros: ");
                op = int.Parse(Console.ReadLine());

            }
            catch (Exception ex)
            {
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine(ex.Message);
                op = 999;
                Console.Write($"\nPresione ENTER para continuar");
                Console.ReadLine();
            }
            Menu();
        }

        static void Menu()
        {
            ProductsLogic productsLogic = new ProductsLogic();
            CustomersLogic customersLogic = new CustomersLogic();
            switch (op)
            {
                case 0:
                    Environment.Exit(0);
                    break;

                case 2:
                    Console.WriteLine($"\nProductos sin stock:");
                    foreach (var item in productsLogic.SinStock())
                    {
                        Console.WriteLine($"Nombre: {item.ProductName}\tPrecio: {item.UnitPrice}");
                    }
                    Console.Write($"\nPresione ENTER para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    Opciones();
                    break;

                case 3:
                    Console.WriteLine($"\nProductos con stock y con un costo mayor a 3$:");
                    foreach (var item in productsLogic.ConStrockYcostoMayor3())
                    {
                        Console.WriteLine($"Nombre: {item.ProductName}\tPrecio: {item.UnitPrice}\tStock: {item.UnitsInStock}");
                    }
                    Console.Write($"\nPresione ENTER para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    Opciones();
                    break;

                case 4:
                    Console.WriteLine($"\nCustomers de la Región WA:");
                    foreach (var item in customersLogic.CustomersRegionWA())
                    {
                        Console.WriteLine($"{item.CompanyName}");
                    }
                    Console.Write($"\nPresione ENTER para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    Opciones();
                    break;

                case 5:
                    Console.WriteLine($"\nProducto con ID = 789:");                  
                    Console.WriteLine($"Nombre del producto: {productsLogic.DevolverId789().ProductName}\tPrecio:{productsLogic.DevolverId789().UnitPrice} ");
                    if(productsLogic.DevolverId789() == null)
                        Console.WriteLine($"No existe un producto con ese ID!!!");
                    Console.Write($"\nPresione ENTER para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    Opciones();
                    break;

                case 6:
                    Console.WriteLine($"\nNombres de los customers en Mayúscula:");
                    foreach (var item in customersLogic.CustomersName())
                    {
                        Console.WriteLine($"{item.ToUpper()}");
                    }
                    Console.WriteLine($"\nNombres de los customers en Minuscula:");
                    foreach (var item in customersLogic.CustomersName())
                    {
                        Console.WriteLine($"{item.ToLower()}");
                    }
                    Console.Write($"\nPresione ENTER para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    Opciones();
                    break;

                case 7:
                    Console.WriteLine($"\nJoin entre Customers y Orders donde los customers" +
                                      $" sean de la Región WA y la fecha de orden sea mayor a 1 / 1 / 1997:");
                    foreach (var item in customersLogic.CustomersJoinOrders())
                    {
                        Console.WriteLine($"{item.orderID}\t{item.customerID}\t{item.companyName}");
                    }
                    Console.Write($"\nPresione ENTER para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    Opciones();
                    break;

                default:
                    Console.Clear();
                    if (op != 999)
                        Console.WriteLine($"Opción invalida, seleccione la opción deseada nuevamente.\n");
                    Opciones();
                    break;
            }
        }
    }
}
