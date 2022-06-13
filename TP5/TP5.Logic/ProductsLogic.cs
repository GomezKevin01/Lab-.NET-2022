using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Data;
using TP5.Entities;

namespace TP5.Logic
{
    public class ProductsLogic : BaseLogic
    {
        public List<Products> SinStock()
        {
            var query = from p in context.Products
                        where p.UnitsInStock == 0
                        select p;
            return query.ToList();
        }

        public List<Products> ConStrockYcostoMayor3()
        {
            var query = context.Products.Where(p =>p.UnitsInStock > 0 & p.UnitPrice >3);
            return query.ToList(); 
        }
         
        public Products DevolverId789()
        {
            var query = context.Products.Find(789);
            return query;
        }
    }
}
