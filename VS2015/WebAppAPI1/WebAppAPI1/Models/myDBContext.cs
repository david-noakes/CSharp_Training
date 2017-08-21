using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAppAPI1.Models
{
    public class myDBContext : DbContext
    {

        public myDBContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }
        public myDBContext() : base()
        {
        }

        public DbSet<Supplier> Supplier { get; set; }
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
}