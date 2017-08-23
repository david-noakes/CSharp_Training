using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAppJson1.Models
{
    public class TheDBContext : DbContext
    {
        public static string theConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebAppJson;Integrated Security=True";
        public TheDBContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }
        public TheDBContext() : base(theConnectionString)
        {
        }

        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<Product> Product { get; set; }
    }

    [Table("Supplier")]
    public class Supplier
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int SupplierId { get; set; }

        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }
        [Display(Name = "Supplier City")]
        public string City { get; set; }
        [Display(Name = "Supplier Country")]
        public string Country { get; set; }


    }

    [Table("Product")]
    public class Product
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        public string Name { get; set; }
        public string SupplierName { get; set; }
    }
}
