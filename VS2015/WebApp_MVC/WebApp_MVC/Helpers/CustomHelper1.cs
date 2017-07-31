using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp_MVC.Helpers
{
    public static class CustomHelper1
    {
        public static MvcHtmlString customHTMLStripper(this HtmlHelper html, string htmlInput)
        {
            return new MvcHtmlString(System.Text.RegularExpressions.Regex.Replace(htmlInput, "<.*?>", string.Empty));
        }
    }
}