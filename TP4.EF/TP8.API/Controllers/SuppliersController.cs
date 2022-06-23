using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using TP4.EF.Entities;
using TP4.EF.Logic;
using TP7.MVC.Models;

namespace TP8.API.Controllers
{
    public class SuppliersController : ApiController
    {
        SuppliersLogic suppliersLogic = new SuppliersLogic();
        
        // GET: api/Suppliers
        public List<SuppliersModel> GetSuppliers()
        {
            List<Suppliers> suppliers = suppliersLogic.GetAll();
            List<SuppliersModel> suppliersModel = suppliers.Select(s => new SuppliersModel
            {
                id = s.SupplierID,
                nombre = s.CompanyName,
                pais = s.Country
            }).ToList();
            return suppliersModel;
        }

        // POST: api/Suppliers
        public IHttpActionResult PostSuppliers(SuppliersModel suppliersModel)
        {
            try
            {
                var suppliers = new Suppliers
                {
                    CompanyName = suppliersModel.nombre,
                    Country = suppliersModel.pais
                };
                suppliersLogic.Add(suppliers);
                suppliersModel.id = suppliers.SupplierID;
                return Ok(suppliersModel);
            }
            catch (Exception)
            {
                return BadRequest();
            }           
        }

        // PUT: api/Suppliers/id
        public IHttpActionResult PutSuppliers(int id, SuppliersModel suppliersModel)
        {
            try
            {
                var suppliers = new Suppliers
                {
                    SupplierID = id,
                    CompanyName = suppliersModel.nombre,
                    Country = suppliersModel.pais
                };
                suppliersModel.id = id;
                suppliersLogic.Update(suppliers);
                return Ok(suppliersModel);
            }
            catch (Exception)
            {
                return BadRequest();
            }            
        }

        // DELETE: api/Suppliers/id
        public IHttpActionResult DeleteSuppliers(int id)
        {
            try
            {
                suppliersLogic.Delete(id);              
                return Ok("Se elimino al proveedor");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
