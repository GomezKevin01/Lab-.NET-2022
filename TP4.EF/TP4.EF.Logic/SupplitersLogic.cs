using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.EF.Data;
using TP4.EF.Entities;

namespace TP4.EF.Logic
{
    public class SupplitersLogic
    {
        private readonly NorthwindContext context;

        public SupplitersLogic()
        {
            context = new NorthwindContext();
        }

        public List<Suppliers> GetAll()
        {
            return context.Suppliers.ToList();
        }
    }
}
