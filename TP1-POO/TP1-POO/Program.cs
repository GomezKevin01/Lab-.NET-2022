using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Transporte> transporteList = new List<Transporte>
            {
                new Omnibus(25,"Omnibus","Omnibus 1"),
                new Omnibus(5,"Omnibus","Omnibus 2"),
                new Omnibus(100,"Omnibus","Omnibus 3"),
                new Omnibus(1,"Omnibus","Omnibus 4"),
                new Omnibus(30,"Omnibus","Omnibus 5"),
                new Taxi(300,"Taxi","Taxi 1"),
                new Taxi(10,"Taxi","Taxi 2"),
                new Taxi(9,"Taxi","Taxi 3"),
                new Taxi(51,"Taxi","Taxi 4"),
                new Taxi(251,"Taxi","Taxi 5")
        };

            foreach (var item in transporteList)
            {
                Console.WriteLine(item.ListarTransporte());
            } 
            Console.ReadLine();
        }
    }
}
