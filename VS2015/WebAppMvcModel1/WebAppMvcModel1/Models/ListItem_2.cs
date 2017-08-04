using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebAppMvcModel1.Models
{
    public class ListItem_2
    {
        public int ListItemID { get; set; }
        [DisplayName("List Title: ")]
        public string Title { get; set; }
        [DisplayName("List Item Entry: ")]
        public string ListItemEntry { get; set; }
        [DisplayName("Time Created: ")]
        public string TimeCreated { get; set; }
    }
}