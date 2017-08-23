using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAppJson1.Models;

namespace WebAppJson1.Models
{
    public class TheDBInitializer : DropCreateDatabaseAlways<TheDBContext>
    {
        private DbContext dbContext;

        public TheDBInitializer(DbContext dbContext) : base()
        {
            this.dbContext = dbContext;
        }
        public TheDBInitializer() : base()
        {
            this.dbContext = new TheDBContext();
        }


        protected override void Seed(TheDBContext context)
        {
            base.Seed(context);
            // Create supplier records
            var suppliers = new List<Supplier>
            {
                new Supplier {CompanyName="Mars Farm", City="New Seattle", Country="Mars"},
                new Supplier {CompanyName="Palamedes' Produce", City="New New York", Country="Mars"},
                new Supplier {CompanyName="Brocadero", City="Tijuana, Mexico", Country="Earth"},
                new Supplier {CompanyName="Wakayama Ramen", City="Nova Moskva", Country="Luna"},
                new Supplier {CompanyName="Steel Magnolia", City="Marsopolis", Country="Mars"},
                new Supplier {CompanyName="Mental As Anything", City="Lunopolis", Country="Luna"},
                new Supplier {CompanyName="Fugue State", City="Erehwon", Country="Shadowlands"},
                new Supplier {CompanyName="Edge of Realty", City="Weeping Waste", Country="Shadowlands"}

            };
            suppliers.ForEach(s => context.Supplier.Add(s));
            context.SaveChanges();
        }
    }
}