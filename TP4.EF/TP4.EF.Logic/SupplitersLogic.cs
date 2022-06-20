using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.EF.Data;
using TP4.EF.Entities;

namespace TP4.EF.Logic
{
    public class SupplitersLogic : BaseLogic
    {
        public List<Suppliers> GetAll()
        {
            return context.Suppliers.ToList();
        }

        public void Add(Suppliers newSuppliers)
        {
            try
            {
                context.Suppliers.Add(newSuppliers);
                context.SaveChanges();
            }
            catch (Exception)
            {
                Console.WriteLine($"\nERROR!!! No se completaron los datos obligatorios (*).");
            }
        }

        public void Delete(int id)
        {
                var supliers = context.Suppliers.Find(id);
                context.Suppliers.Remove(supliers);
                context.SaveChanges();    
        }

        public void Update(int id)
        {
            var suppliersUpdate = context.Suppliers.Find(id);

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

            suppliersUpdate.CompanyName = nombreCompania;
            suppliersUpdate.ContactName = nombreContacto;
            suppliersUpdate.ContactTitle = tituloContacto;
            suppliersUpdate.Address = direccion;
            suppliersUpdate.City = ciudad;
            suppliersUpdate.Region = region;
            suppliersUpdate.PostalCode = cdPostal;
            suppliersUpdate.Country = pais;
            suppliersUpdate.Phone = telefono;
            suppliersUpdate.Fax = fax;
            suppliersUpdate.HomePage = web;

            try
            {
                context.Entry(suppliersUpdate).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                Console.WriteLine($"\n¡El proveedor se actualizo correctamente!");
            }
            catch (Exception)
            {
                Console.WriteLine($"\nERROR!!! No se completaron los datos obligatorios (*).");
            }

        }
        
    }
}
