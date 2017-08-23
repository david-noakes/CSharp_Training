using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAppJson1.Models;

namespace WebAppJson1.Controllers
{
    public class ProductsController : ApiController
    {
        public IEnumerable<Product> GetProduct()
        {
            var products = new List<Product>
            {
                new Product() { Name = "Apricot" , SupplierName = "Earth Farm", ProductId = 1},
                new Product() { Name = "Apples" , SupplierName = "Mars Farm", ProductId = 2},
                new Product() { Name = "Tequilla" , SupplierName = "Brocadero", ProductId = 3}
            };

            return products;
        }
        public Product GetProduct(int id)
        {
            Product apricot = new Product() { Name = "Apricot" };
            Supplier earthfarm = new Supplier() { CompanyName = "Earth Farm", SupplierId = 0, City = "New London", Country = "Luna" };
            // earthfarm.Product = apricot; // create a circular reference
            apricot.SupplierName = earthfarm.CompanyName;
            return apricot;
        }
    }
}
