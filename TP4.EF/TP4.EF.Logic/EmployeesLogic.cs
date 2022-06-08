using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.EF.Data;
using TP4.EF.Entities;

namespace TP4.EF.Logic
{
    public class EmployeesLogic
    {
        private readonly NorthwindContext context;

        public EmployeesLogic()
        {
            context = new NorthwindContext();
        }

        public List<Employees> GetAll()
        {
            return context.Employees.ToList();
        }
    }
}
