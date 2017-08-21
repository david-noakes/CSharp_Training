using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using WebAppAPI2.Models;

namespace WebAppAPI2.Controllers
{
    public class SupplierController : ApiController
    {
        Supplier[] suppliers = new Supplier[5]
        {
            new Supplier {CompanyName="Mars Farm", City="New Seattle", Country="Mars", SupplierId = 1},
            new Supplier {CompanyName="Palamedes' Produce", City="New New York", Country="Mars", SupplierId = 2},
            new Supplier {CompanyName="Brocadero", City="Tijuana", Country="Mexico", SupplierId = 3},
            new Supplier {CompanyName="Wakayama Ramen", City="Nova Moskva", Country="Luna", SupplierId = 4},
            new Supplier {CompanyName="Steel Magnolia", City="Marsopolis", Country="Mars", SupplierId = 5}
        };

        // GET api/supplier
        public IEnumerable<Supplier> GetAllSuppliers()
        {
            return suppliers;
            //return View("Index", suppliers);  <-- not defined for apiController
        }

        // GET api/supplier/5
        public Supplier GetSupplierById(int id)
        {
            var supplier = suppliers.FirstOrDefault((p) => p.SupplierId == id);
            return supplier;
        }
    }
}
