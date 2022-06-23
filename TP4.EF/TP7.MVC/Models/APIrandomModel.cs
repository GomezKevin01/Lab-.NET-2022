using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP7.MVC.Models
{
    public class Location
    {
        public Street Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Postcode { get; set; }
    }

    public class Name
    {
        public string Title { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
    }

    public class Picture
    {
        public string Large { get; set; }
        public string Medium { get; set; }
        public string Thumbnail { get; set; }
    }

    public class Result
    {
        public string Gender { get; set; }
        public Name Name { get; set; }
        public Location Location { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Cell { get; set; }
        public Picture Picture { get; set; }
    }

    public class ListaResultado
    {
        public List<Result> Results { get; set; }
    }

    public class Street
    {
        public int Number { get; set; }
        public string Name { get; set; }
    }

}