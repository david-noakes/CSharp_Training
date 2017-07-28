using System.Web;
using System.Web.Mvc;
using WebApp_MVC.Filters;

namespace WebApp_MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new LogAttribute());
        }
    }
}
