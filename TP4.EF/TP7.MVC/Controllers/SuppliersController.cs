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
        public static int banderaEliminar = 999;
        public static int banderaInsertar = 999;
        public static int idSupplier;
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
            banderaInsertar = 0;
            return RedirectToAction("Index");

        }
        
        public ActionResult Update(int id)
        {
            SuppliersController.idSupplier = id;
            List<Suppliers> suppliers = suppliersLogic.GetAll();
            List<SuppliersModel> suppliersModel = suppliers.Where(s => s.SupplierID == id).Select(s => new SuppliersModel
            {
                id = s.SupplierID,
                nombre = s.CompanyName,
                pais = s.Country
            }).ToList();
            return View(suppliersModel);
        }

        [HttpPost]
        public ActionResult ConfirmUpdate(SuppliersModel suppliersModel)
        {
            var suppliersEntity = new Suppliers
            {
                SupplierID = idSupplier,
                CompanyName = suppliersModel.nombre,
                Country = suppliersModel.pais
            };
            suppliersLogic.Update(suppliersEntity);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            try
            {
                suppliersLogic.Delete(id);
                banderaEliminar = 0;
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                banderaEliminar = 1;
                return RedirectToAction("Index");
            }
        }
    }
}