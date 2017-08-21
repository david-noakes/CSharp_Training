using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebAppAPI1.Models;

namespace WebAppAPI1
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Create and seed database using data context
            Database.SetInitializer<myDBContext>(new myDBInitializer(new DbContext("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebAppAPI1;Integrated Security=True")));
            //    remove now it is created
        }
    }
}
