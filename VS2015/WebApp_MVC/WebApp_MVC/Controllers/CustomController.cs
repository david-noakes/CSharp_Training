using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp_MVC.Controllers
{
    public class CustomController : Controller
    {
        // GET: custom/pages
        public ActionResult Pages()
        {
            return Content("Custom Controller has supplied this information.");
        }

        // GET: custom/
        public ActionResult Index()
        {
            return RedirectToAction("Alternate", "Home");
        }
        // GET: custom/newview    -- Fred will not work
        [ActionName("NewView")]
        [HttpGet]
        public ActionResult Fred()
        {
            return Content("Custom controller supplied this for NewView.");
        }

        // GET: custom/manual
        public ActionResult Manual()
        {
            return Content("Custom controller output for Manual");
        }
    }
}