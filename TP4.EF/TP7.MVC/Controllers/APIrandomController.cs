using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using Newtonsoft.Json;
using TP7.MVC.Models;

namespace TP7.MVC.Controllers
{
    public class APIrandomController : Controller
    {
        // GET: APIrandom
        public ActionResult Index()
        {
            var url = "https://randomuser.me/api/?results=10";
            WebClient wc = new WebClient();
            var datos = wc.DownloadString(url);
            var resultado = JsonConvert.DeserializeObject<Resultado>(datos); 
            return View(resultado);
        }
    }
}