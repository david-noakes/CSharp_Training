using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebAppMVC_ModelFirst.Models
{
    public class MarketDBContext : MarketContainer
    {
        public MarketDBContext() : base() { }
        //public override DbSet<Product> Products { get; set; }
        //public override DbSet<Supplier> Suppliers { get; set; }
    }

    [MetadataType(typeof(ProductMetaData))]
    [Table("Product")]
    public partial class Product
    {
    }
    public class ProductMetaData
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public System.Guid ProductId { get; set; }

        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Display(Name = "Unit Price")]
        [DataType(DataType.Currency)]
        public decimal UnitPrice { get; set; }

        [Display(Name = "Number of Units in Stock")]
        public Nullable<int> UnitsInStock { get; set; }
    }

    [MetadataType(typeof(SupplierMetaData))]
    [Table("Supplier")]
    public partial class Supplier
    {

    }
    public class SupplierMetaData
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public System.Guid SupplierId { get; set; }

        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [Display(Name = "Supplier City")]
        public string City { get; set; }

        [Display(Name = "Supplier Country")]
        public string Country { get; set; }

    }
}