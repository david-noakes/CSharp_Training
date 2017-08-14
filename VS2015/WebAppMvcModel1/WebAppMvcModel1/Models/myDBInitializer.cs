using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAppMvcModel1.Models
{
    public class myDBInitializer : DropCreateDatabaseAlways<myDBContext>
    {
        private DbContext dbContext;

        public myDBInitializer(DbContext dbContext):base()
        {
            this.dbContext = dbContext;
        }

        protected override void Seed(myDBContext context)
        {
            base.Seed(context);
            // Create supplier records
            var suppliers = new List<Supplier>
            {
                new Supplier {CompanyName="Mars Farm", City="New Seattle", Country="Mars"},
                new Supplier {CompanyName="Palamedes' Produce", City="New New York", Country="Mars"},
                new Supplier {CompanyName="Brocadero", City="Tijuana", Country="Mexico"},
                new Supplier {CompanyName="Wakayama Ramen", City="Nova Moskva", Country="Luna"},
                new Supplier {CompanyName="Steel Magnolia", City="Marsopolis", Country="Mars"}

            };
            suppliers.ForEach(s => context.Supplier.Add(s));
            context.SaveChanges();

            // create product records
            var products = new List<Product>
            {
                new Product {Productname="Watermelon", SupplierId=suppliers.Single(s => s.CompanyName == "Mars Farm").SupplierId, UnitPrice=1.80 },
                new Product {Productname="Lemon", SupplierId=suppliers.Single(s => s.CompanyName == "Mars Farm").SupplierId, UnitPrice=0.60 },
                new Product {Productname="Apple", SupplierId=suppliers.Single(s => s.CompanyName == "Mars Farm").SupplierId, UnitPrice=0.65 },
                new Product {Productname="Chorizo", SupplierId=suppliers.Single(s => s.CompanyName == "Palamedes' Produce").SupplierId, UnitPrice=0.97 },
                new Product {Productname="Greek Evia (Figs)", SupplierId=suppliers.Single(s => s.CompanyName == "Palamedes' Produce").SupplierId, UnitPrice=1.13 },
                new Product {Productname="Retsina", SupplierId=suppliers.Single(s => s.CompanyName == "Palamedes' Produce").SupplierId, UnitPrice=1.02 },
                new Product {Productname="Comandaria", SupplierId=suppliers.Single(s => s.CompanyName == "Palamedes' Produce").SupplierId, UnitPrice=0.82 },
                new Product {Productname="Frozen Enchiladas", SupplierId=suppliers.Single(s => s.CompanyName == "Brocadero").SupplierId, UnitPrice=2.02 },
                new Product {Productname="Tonkatsu Ramen", SupplierId=suppliers.Single(s => s.CompanyName == "Wakayama Ramen").SupplierId, UnitPrice=0.42 },
                new Product {Productname="Tonkatsu Ramen", SupplierId=suppliers.Single(s => s.CompanyName == "Wakayama Ramen").SupplierId, UnitPrice=0.43 },
                new Product {Productname="Kagoshima Ramen", SupplierId=suppliers.Single(s => s.CompanyName == "Wakayama Ramen").SupplierId, UnitPrice=0.41 },
                new Product {Productname="Champon  Ramen", SupplierId=suppliers.Single(s => s.CompanyName == "Wakayama Ramen").SupplierId, UnitPrice=0.47 },
                new Product {Productname="Hokkaido Ramen", SupplierId=suppliers.Single(s => s.CompanyName == "Wakayama Ramen").SupplierId, UnitPrice=0.46 },
                new Product {Productname="Hiyashi Chūka Ramen", SupplierId=suppliers.Single(s => s.CompanyName == "Wakayama Ramen").SupplierId, UnitPrice=0.45 },
                new Product {Productname="Hakata Ramen", SupplierId=suppliers.Single(s => s.CompanyName == "Wakayama Ramen").SupplierId, UnitPrice=0.44 },
                new Product {Productname="Katakana (sword)", SupplierId=suppliers.Single(s => s.CompanyName == "Steel Magnolia").SupplierId, UnitPrice=13.40 },
                new Product {Productname="Phaser (pistol)", SupplierId=suppliers.Single(s => s.CompanyName == "Steel Magnolia").SupplierId, UnitPrice=27.40 },
                new Product {Productname="Stunner (rod)", SupplierId=suppliers.Single(s => s.CompanyName == "Steel Magnolia").SupplierId, UnitPrice=75.40 },
                new Product {Productname="Rail Gun", SupplierId=suppliers.Single(s => s.CompanyName == "Steel Magnolia").SupplierId, UnitPrice=502.40 },
                new Product {Productname="Gravity Engine", SupplierId=suppliers.Single(s => s.CompanyName == "Steel Magnolia").SupplierId, UnitPrice=1234.56 }
             };
            products.ForEach(s => context.Product.Add(s));
            context.SaveChanges();

            var itemList = new List<ItemList>
            {
                new ItemList {Title="Grocery Shopping", ListItemEntry="Bread, Cheese, Chianti, Grapes and Shunka", UnitPrice=14.65, CreateDate=DateTime.Now},
                new ItemList {Title="Things to do", ListItemEntry="Wash the windows, clean the carpets, mop the tiles", UnitPrice=41.57, CreateDate=DateTime.Now }
            };
            itemList.ForEach(i => context.ItemList.Add(i));
            context.SaveChanges();
        }
    }
}