using Enterwell_Fakture.Models;
using Enterwell_Fakture.Models.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Enterwell_Fakture.Controllers
{
    [Authorize]
    public class FakturaController : Controller
    {
        FakturaDbContex _db = new FakturaDbContex();

        // GET: Faktura
        public ActionResult Index()
        {
            List<Faktura> all = _db.Fakture.ToList();

            return View(all);
        }

        public ActionResult Create()
        {
            return View( new  Faktura() );
        }
    }
}