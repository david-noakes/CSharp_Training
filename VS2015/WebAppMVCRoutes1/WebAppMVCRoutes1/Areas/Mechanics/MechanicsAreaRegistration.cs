using System.Web.Mvc;

namespace WebAppMVCRoutes1.Areas.Mechanics
{
    public class MechanicsAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Mechanics";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Mechanics_default",
                "Mechanics/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}