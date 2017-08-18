using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebAppMVCRoutes1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // start with specifics and work up to the generic
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Products",
                url:  "{controller}/{action}",
                defaults: new { action = "ListProducts" }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
