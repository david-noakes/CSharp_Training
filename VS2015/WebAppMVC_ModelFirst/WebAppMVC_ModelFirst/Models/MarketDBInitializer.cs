using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAppMVC_ModelFirst.Models
{
    public class MarketDBInitializer : DropCreateDatabaseAlways<MarketDBContext>
    {
        private DbContext dbContext;

        public MarketDBInitializer(DbContext dbContext):base()
        {
            this.dbContext = dbContext;
        }

        protected override void Seed(MarketDBContext context)
        {
            // Create supplier records
            var suppliers = new List<Supplier>
            {
                new Supplier {SupplierId = Guid.NewGuid(), CompanyName="Mars Farm", City="New Seattle", Country="Mars"},
                new Supplier {SupplierId = Guid.NewGuid(), CompanyName="Palamedes' Produce", City="New New York", Country="Mars"},
                new Supplier {SupplierId = Guid.NewGuid(), CompanyName="Brocadero", City="Tijuana", Country="Mexico"},
                new Supplier {SupplierId = Guid.NewGuid(), CompanyName="Wakayama Ramen", City="Nova Moskva", Country="Luna"},
                new Supplier {SupplierId = Guid.NewGuid(), CompanyName="Steel Magnolia", City="Marsopolis", Country="Mars"}

            };
            suppliers.ForEach(s => context.Suppliers.Add(s));
            context.SaveChanges();

            // create product records
            var products = new List<Product>
            {
                new Product {ProductName="Watermelon", SupplierId=suppliers.Single(s => s.CompanyName == "Mars Farm").SupplierId, UnitPrice=1.80m, UnitsInStock=25, ProductId = Guid.NewGuid() },
                new Product {ProductName="Lemon", SupplierId=suppliers.Single(s => s.CompanyName == "Mars Farm").SupplierId, UnitPrice=0.60m, UnitsInStock=26, ProductId = Guid.NewGuid() },
                new Product {ProductName="Apple", SupplierId=suppliers.Single(s => s.CompanyName == "Mars Farm").SupplierId, UnitPrice=0.65m, UnitsInStock=27, ProductId = Guid.NewGuid() },
                new Product {ProductName="Chorizo", SupplierId=suppliers.Single(s => s.CompanyName == "Palamedes' Produce").SupplierId, UnitPrice=0.97m, UnitsInStock=31, ProductId = Guid.NewGuid() },
                new Product {ProductName="Greek Evia (Figs)", SupplierId=suppliers.Single(s => s.CompanyName == "Palamedes' Produce").SupplierId, UnitPrice=1.13m, UnitsInStock=32, ProductId = Guid.NewGuid() },
                new Product {ProductName="Retsina", SupplierId=suppliers.Single(s => s.CompanyName == "Palamedes' Produce").SupplierId, UnitPrice=1.02m, UnitsInStock=33, ProductId = Guid.NewGuid() },
                new Product {ProductName="Comandaria", SupplierId=suppliers.Single(s => s.CompanyName == "Palamedes' Produce").SupplierId, UnitPrice=0.82m, UnitsInStock=34, ProductId = Guid.NewGuid() },
                new Product {ProductName="Frozen Enchiladas", SupplierId=suppliers.Single(s => s.CompanyName == "Brocadero").SupplierId, UnitPrice=2.02m, ProductId = Guid.NewGuid() },
                new Product {ProductName="Tonkatsu Ramen", SupplierId=suppliers.Single(s => s.CompanyName == "Wakayama Ramen").SupplierId, UnitPrice=0.42m, UnitsInStock=101, ProductId = Guid.NewGuid() },
                new Product {ProductName="Karaage Pork Ramen", SupplierId=suppliers.Single(s => s.CompanyName == "Wakayama Ramen").SupplierId, UnitPrice=0.43m, UnitsInStock=101, ProductId = Guid.NewGuid() },
                new Product {ProductName="Kagoshima Ramen", SupplierId=suppliers.Single(s => s.CompanyName == "Wakayama Ramen").SupplierId, UnitPrice=0.41m, UnitsInStock=101, ProductId = Guid.NewGuid() },
                new Product {ProductName="Champon  Ramen", SupplierId=suppliers.Single(s => s.CompanyName == "Wakayama Ramen").SupplierId, UnitPrice=0.47m, UnitsInStock=101, ProductId = Guid.NewGuid() },
                new Product {ProductName="Hokkaido Ramen", SupplierId=suppliers.Single(s => s.CompanyName == "Wakayama Ramen").SupplierId, UnitPrice=0.46m, UnitsInStock=101, ProductId = Guid.NewGuid() },
                new Product {ProductName="Hiyashi Chūka Ramen", SupplierId=suppliers.Single(s => s.CompanyName == "Wakayama Ramen").SupplierId, UnitPrice=0.45m, UnitsInStock=101, ProductId = Guid.NewGuid() },
                new Product {ProductName="Hakata Ramen", SupplierId=suppliers.Single(s => s.CompanyName == "Wakayama Ramen").SupplierId, UnitPrice=0.44m, UnitsInStock=101, ProductId = Guid.NewGuid() },
                new Product {ProductName="Katakana (sword)", SupplierId=suppliers.Single(s => s.CompanyName == "Steel Magnolia").SupplierId, UnitPrice=13.40m, UnitsInStock=101, ProductId = Guid.NewGuid() },
                new Product {ProductName="Phaser (pistol)", SupplierId=suppliers.Single(s => s.CompanyName == "Steel Magnolia").SupplierId, UnitPrice=27.40m, UnitsInStock=102, ProductId = Guid.NewGuid() },
                new Product {ProductName="Stunner (rod)", SupplierId=suppliers.Single(s => s.CompanyName == "Steel Magnolia").SupplierId, UnitPrice=75.40m, UnitsInStock=10, ProductId = Guid.NewGuid() },
                new Product {ProductName="Rail Gun", SupplierId=suppliers.Single(s => s.CompanyName == "Steel Magnolia").SupplierId, UnitPrice=502.40m, UnitsInStock=11, ProductId = Guid.NewGuid() },
                new Product {ProductName="Gravity Engine", SupplierId=suppliers.Single(s => s.CompanyName == "Steel Magnolia").SupplierId, UnitPrice=1234.56m, UnitsInStock=1, ProductId = Guid.NewGuid() }
             };
            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();



        }

    }
}