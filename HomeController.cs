using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HighDistinctionTask.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Documentation()
        {
            ViewBag.Message = "Your documentation page.";

            return View();
        }

        public ActionResult Users()
        {
            ViewBag.Message = "Your users page.";

            return View();
        }

        public ActionResult Donation()
        {
            ViewBag.Message = "Your donation page.";

            return View();
        }

        public ActionResult AdditionalFeatures()
        {
            ViewBag.Message = "Your additional features page.";

            return View();
        }
    }
}