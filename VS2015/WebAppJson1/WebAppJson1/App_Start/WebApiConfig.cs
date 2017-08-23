using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;

namespace WebAppJson1
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
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Create reference to media types formatter collection
            var mediaTypeFormatters = config.Formatters;

            // create references to JSON and XML formatters
            var json = mediaTypeFormatters.JsonFormatter;
            var xml = mediaTypeFormatters.XmlFormatter;

            // Set JSON formatter to write indented JSON
            json.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;

            // set XML formattwe to write indented XML
            xml.Indent = true;

            // remove XML formatter
            //mediaTypeFormatters.Remove(xml);
            // OR remove json for xml
            mediaTypeFormatters.Remove(json);


        }
    }
}
