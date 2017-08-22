using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;

namespace WebAppAPI1
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "CustomApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional },
                constraints: new { controller = "^values$", action = "^showallvalues$|^showvaluebyid$|^retrieve.*" }
                );

            config.Routes.MapHttpRoute(
                name: "SupplierApi",
                routeTemplate: "api/suppliers/{id}",
                defaults: new { controller = "Suppliers", id = RouteParameter.Optional },
                constraints: new { controller = "^suppliers$" }
            );

            //config.Routes.MapHttpRoute(
            //    name: "CustomValueApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { action = "get" },
            //    constraints: new { id = @"^[0-9]+$" }
            //);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                //defaults: new { action = "get", id = RouteParameter.Optional }
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
