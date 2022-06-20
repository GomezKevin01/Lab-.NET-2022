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

        public void Update(Suppliers newSuppliers)
        {
            context.Entry(newSuppliers).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();

        }       
    }
}
