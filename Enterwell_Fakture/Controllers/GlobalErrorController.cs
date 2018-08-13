using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Enterwell_Fakture.Controllers
{
    public class GlobalErrorController : Controller
    {
        // GET: GlobalError
        public ActionResult Index()
        {
            return View("Error");
        }
    }
}