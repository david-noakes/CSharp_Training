﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAppMvcModel1.Models
{
    public class myDBContext : DbContext
    {
        public myDBContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Product> Products { get; set; }
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

        // Navigation property: Implement Supplier side of the relationship
        // Many products can be supplied by one supplier
        public virtual ICollection<Product> Products { get; set; }

    }

    [Table("Product")]
    public class Product
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [Display(Name = "Product Name")]
        public string Productname { get; set; }
        [Display(Name = "Unit Price")]
        [DataType(DataType.Currency)]
        public Nullable<double> UnitPrice { get; set; }
        [Display(Name ="Supplier ID")]
        public Nullable<int> SupplierId { get; set; }

        // Navigation property: Implement Product side of the relationship
        // Many products can be supplied by one supplier
        public virtual Supplier Supplier { get; set; }
    }

}