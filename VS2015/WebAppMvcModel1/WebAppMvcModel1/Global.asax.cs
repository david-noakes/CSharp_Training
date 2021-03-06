﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebAppMvcModel1.Models;

namespace WebAppMvcModel1
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
      //      Database.SetInitializer<myDBContext>(new myDBInitializer(new DbContext("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebAppMvc;Integrated Security=True")));
     //    remove now it is created
        }
    }
}
