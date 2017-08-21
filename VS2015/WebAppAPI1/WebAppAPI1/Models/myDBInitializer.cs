using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAppAPI1.Models
{
    public class myDBInitializer : DropCreateDatabaseAlways<myDBContext>
    {
        private DbContext dbContext;

        public myDBInitializer(DbContext dbContext) : base()
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
        }
    }
}