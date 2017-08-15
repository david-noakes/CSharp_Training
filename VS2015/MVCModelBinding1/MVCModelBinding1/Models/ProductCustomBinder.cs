using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCModelBinding1.Models
{
    public class ProductCustomBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            // Get  client HTTP request
            HttpRequestBase request = controllerContext.HttpContext.Request;

            // Get the form data from the request
            string pName = request.Form.Get("ProductName");
            string pDesc = request.Form.Get("ProductDescription");

            // Return the new product to the controller
            return new ProductLocal
            {
                ProductName = pName,
                ProductDescription = pDesc
            };
        }
    }
}