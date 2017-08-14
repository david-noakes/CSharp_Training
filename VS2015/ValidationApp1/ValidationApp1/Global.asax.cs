using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using ValidationApp1.Models;

namespace ValidationApp1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            // Create and seed database using data context
            //Database.SetInitializer<ItemListDB>(new ItemListInitializer(new DbContext("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ValidationApp1;Integrated Security=True")));
            //    remove now it is created
        }
    }
}
