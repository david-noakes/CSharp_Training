using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppMVC_ModelFirst.Models;

namespace WebAppMVC_ModelFirst.Repositories
{
    public class ProductRepository : IProductRepository, IDisposable
    {
        // Define context as a class attribute
        private MarketDBContext ctx;

        // Constructor - initialize context
        public ProductRepository(MarketDBContext ctx)
        {
            this.ctx = ctx;
        }

        // Define GetProducts from IProductrepository interface
        public IEnumerable<Product> GetProducts()
        {
            // use LINQ to Entities query to retrieve all products
            var products = (from p in ctx.Products
                            orderby p.ProductName ascending
                            select p).ToList();

            return products;
        }

        // Define GetProductById
        public Product GetProductById(Guid ProductId)
        {
            // search for product matching id
            var product = ctx.Products.Find(ProductId);
            return product;
        }

        // define the Save method
        public void Save()
        {
            ctx.SaveChanges();
        }

        //dispose of database context
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing) { ctx.Dispose(); }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}