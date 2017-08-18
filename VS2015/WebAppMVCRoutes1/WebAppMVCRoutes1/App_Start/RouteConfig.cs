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
                name: "HomeRoute",
                url: "Home",
                defaults: new { controller = "Home", action = "Index" }
            );

            routes.MapRoute(
                name: "HomeAbout",
                url: "Home/About",
                defaults: new { controller = "Home", action = "About" }
            );

            routes.MapRoute(
                name: "HomeContact",
                url: "Home/Contact",
                defaults: new { controller = "Home", action = "Contact" }
            );

            routes.MapRoute(
                name: "OrderRoute",
                url: "Orders",
                defaults: new { controller = "Orders", action = "Index" }
            );

            routes.MapRoute(
                name: "OrderIndex",
                url: "Orders/Index",
                defaults: new { controller = "Orders", action = "Index" }
            );

            // this one needs a constraint to ensure that home/about is not caught
            routes.MapRoute(
                name: "OrderById",
                url: "Orders/{id}",
                defaults: new { controller = "Orders", action = "Details"},
                constraints: new { id = @"^[0-9]+$" }
                );

            routes.MapRoute(
                name: "ProductsRoute",
                url: "Products",
                defaults: new { controller = "Products", action = "Index" }
            );

            routes.MapRoute(
                name: "ProductsIndex",
                url: "Products/Index",
                defaults: new { controller = "Products", action = "Index" }
            );

            routes.MapRoute(
                name: "ProductsListProducts",
                url: "Products/ListProducts",
                defaults: new { controller = "Products", action = "ListProducts" }
            );

            routes.MapRoute(
                name: "ProductsList",
                url: "Products/{action}",
                defaults: new { controller = "Products", action = "ListProducts" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
