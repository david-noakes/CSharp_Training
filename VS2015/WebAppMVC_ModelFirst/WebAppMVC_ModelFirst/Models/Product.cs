//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAppMVC_ModelFirst.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public System.Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public System.Guid SupplierId { get; set; }
    
        public virtual Supplier Supplier { get; set; }
    }
}
