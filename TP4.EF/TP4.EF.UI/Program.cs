using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.EF.Entities;
using TP4.EF.Logic;

namespace TP4.EF.UI
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
                Console.WriteLine($"(1) Muestra a todos los empleados.");
                Console.WriteLine($"(2) Muestra a todos los proveedores.");
                Console.WriteLine($"(3) Agregar un nuevo proveedor a la base de datos.");
                Console.WriteLine($"(4) Eliminar proveedor por su ID.");
                Console.WriteLine($"(5) Actualizar datos del proveedor por su ID.");
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
            int id;
            EmployeesLogic employees = new EmployeesLogic();
            SupplitersLogic suppliters = new SupplitersLogic();
            switch (op)
            {
                case 0:
                     Environment.Exit(0);
                     break;

                case 1:
                     Console.WriteLine($"\nNombre y apellido de los empleados:");
                     foreach (var item in employees.GetAll())
                     {
                         Console.WriteLine($"{item.FirstName} {item.LastName}");
                     }
                     Console.Write($"\nPresione ENTER para continuar");
                     Console.ReadLine();

                     Console.Clear();
                     Opciones();
                     break;

                case 2:
                    Console.WriteLine($"\nProveedores:");
                    foreach (var item in suppliters.GetAll())
                    {
                        Console.WriteLine($"\niD: {item.SupplierID}\nNombre: {item.CompanyName}\nPais: {item.Country}" +
                        $"\nCiudad: {item.City}\nDirección: {item.Address}");
                    }
                    Console.Write($"\nPresione ENTER para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    Opciones();
                    break;

                case 3:
                    Console.WriteLine($"\n* Campo requerido");
                    Console.Write($"\nIngresar nombre de la Compania:* ");
                    string nombreCompania = Console.ReadLine();
                    Console.Write($"\nIngresar nombre de contacto: ");
                    string nombreContacto = Console.ReadLine();
                    Console.Write($"\nIngresar título del contacto: ");
                    string tituloContacto = Console.ReadLine();
                    Console.Write($"\nIngresar la dirección: ");
                    string direccion = Console.ReadLine();
                    Console.Write($"\nIngresar la ciudad: ");
                    string ciudad = Console.ReadLine();
                    Console.Write($"\nIngresar la región: ");
                    string region = Console.ReadLine();
                    Console.Write($"\nIngresar código postal: ");
                    string cdPostal = Console.ReadLine();
                    Console.Write($"\nIngresar el país: ");
                    string pais = Console.ReadLine();
                    Console.Write($"\nIngresar número de telefono: ");
                    string telefono = Console.ReadLine();
                    Console.Write($"\nIngresar Fax: ");
                    string fax = Console.ReadLine();
                    Console.Write($"\nIngresar dirección de página web: ");
                    string web = Console.ReadLine();

                    suppliters.Add(new Suppliers
                    {CompanyName = nombreCompania, ContactName = nombreContacto, ContactTitle = tituloContacto,
                    Address = direccion, City = ciudad, Region = region, PostalCode = cdPostal,
                    Country = pais, Phone = telefono, Fax = fax, HomePage = web
                    });
                    Console.Write($"\nPresione ENTER para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    Opciones();
                    break;

                case 4:
                    Console.Write($"\nIngresa el ID del proveedor que desea eliminar: ");
                    id = int.Parse(Console.ReadLine());

                    suppliters.Delete(id);
                    Console.Write($"\nPresione ENTER para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    Opciones();
                    break;

                case 5:
                    Console.Write($"\nIngresa el ID del proveedor que desea modificar: ");
                    id = int.Parse(Console.ReadLine());

                    suppliters.Update(id);
                    Console.Write($"\nPresione ENTER para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    Opciones();
                    break;

                default:
                    Console.Clear();
                    if(op != 999)
                    Console.WriteLine($"Opción invalida, seleccione la opción deseada nuevamente.\n");
                    Opciones();
                    break;
            }
        }
    }
}
