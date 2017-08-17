using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppMVC_ModelFirst.Models;

namespace WebAppMVC_ModelFirst.Repositories
{
    public interface IProductRepository : IDisposable
    {
        // Get all products (Index View)
        IEnumerable<Product> GetProducts();

        // get a specific product by ID (Details View)
        Product GetProductById(Guid ProductId);

        // Save changes
        void Save();
    }
}