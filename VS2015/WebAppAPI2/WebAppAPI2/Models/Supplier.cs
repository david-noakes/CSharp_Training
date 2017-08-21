using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppAPI2.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}