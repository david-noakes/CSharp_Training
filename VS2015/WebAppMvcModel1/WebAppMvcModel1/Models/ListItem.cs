using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppMvcModel1.Models
{
    public class ListItem
    {
        public int ListItemID { get; set; }
        public string Title { get; set; }
        public string ListItemEntry { get; set; }
        public string TimeCreated { get; set; }

    }
}