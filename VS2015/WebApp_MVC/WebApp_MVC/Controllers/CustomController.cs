using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp_MVC.Controllers
{
    // put the [ authorize ] here for the entire class to require authorisation
    public class CustomController : Controller
    {
        // GET: custom/pages
        [Authorize]
        public ActionResult Pages()
        {
            return Content("Pages: Custom Controller has supplied this information. Only visible if you are logged in.");
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
            return Content("NewView: Custom controller supplied this for NewView.");
        }

        // GET: custom/manual
        public ActionResult Manual()
        {
            return Content("Manual: Custom controller output for Manual");
        }
    }
}