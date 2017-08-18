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
            routes.IgnoreRoute("php-app/{*pathInfo}");

            // use constraints to restrict what matches
            routes.MapRoute(
                name: "HomeRoute",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                constraints: new { controller = "^Home$", action = "^Index$|^About$|^Contact$"},
                namespaces: new string[] { "WebAppMVCRoutes1.Controllers" }
            );

            routes.MapRoute(
                name: "OrderRoute",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Orders", action = "Index", id = UrlParameter.Optional },
                constraints: new { controller = "^Orders$",
                                   action = "^Index$|^Details$|^Edit$|^Create$|^Delete$",
                                   id = @"^[0-9]+$" }
            );

            routes.MapRoute(
                name: "ProductsRoute",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Products", action = "Index", id = UrlParameter.Optional },
                constraints: new
                {
                    controller = "^Products$",
                    action = "^Index$|^Details$|^Edit$|^Create$|^Delete$|^List.*$",
                    id = @"^[0-9]+$"
                }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "WebAppMVCRoutes1.Controllers" }
            );
        }
    }
}
