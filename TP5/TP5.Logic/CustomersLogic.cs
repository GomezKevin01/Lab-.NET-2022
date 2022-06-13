using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Entities;

namespace TP5.Logic
{
    public class CustomersLogic : BaseLogic
    {
        public List<Customers> CustomersRegionWA()
        {
            var query = context.Customers.Where(c => c.Region == "WA");
            return query.ToList();
        }

        public List<String> CustomersName()
        {
            var query = from c in context.Customers
                        select c.CompanyName;
            return query.ToList();        
        }

        public class Customers_Orders
        {
            public int orderID { get; set; }
            public string customerID { get; set; }
            public string companyName { get; set; }
        }
        public List<Customers_Orders> CustomersJoinOrders()
        {
            var query = from customers in context.Customers
                        join orders in context.Orders
                        on customers.CustomerID equals orders.CustomerID
                        select new Customers_Orders
                        {
                            orderID = orders.OrderID,
                            customerID = orders.CustomerID,
                            companyName = customers.CompanyName
                        };
            return query.ToList();

        }
    }
}
