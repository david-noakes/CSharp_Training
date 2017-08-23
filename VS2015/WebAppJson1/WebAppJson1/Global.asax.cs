using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebAppJson1.Models;

namespace WebAppJson1
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
            //Database.SetInitializer<TheDBContext>(new TheDBInitializer(new TheDBContext(TheDBContext.theConnectionString)));
            //Database.SetInitializer<TheDBContext>(new TheDBInitializer());
            // remove now it is created

        }
    }
}
