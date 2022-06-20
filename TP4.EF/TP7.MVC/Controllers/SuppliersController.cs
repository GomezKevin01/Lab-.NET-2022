using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP4.EF.Entities;
using TP4.EF.Logic;
using TP7.MVC.Models;

namespace TP7.MVC.Controllers
{
    public class SuppliersController : Controller
    {
        SupplitersLogic suppliersLogic = new SupplitersLogic();
        public ActionResult Index()
        {           
            List<Suppliers> suppliers = suppliersLogic.GetAll();    
            List<SuppliersModel> suppliersModel = suppliers.Select(s => new SuppliersModel
            {
                id = s.SupplierID,
                nombre = s.CompanyName,
                pais = s.Country
            }).ToList();
            return View(suppliersModel);
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(SuppliersModel suppliersModel)
        {
            var suppliersEntity = new Suppliers
            {
                CompanyName = suppliersModel.nombre,
                Country = suppliersModel.pais
            };

            suppliersLogic.Add(suppliersEntity);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            try
            {
                suppliersLogic.Delete(id);

                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                return RedirectToAction("Index","Error");
            }         
        }
        
        public ActionResult ErrorDeEliminacion()
        {
            return View();
        }
    }
}