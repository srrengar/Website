using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myFirstAzureWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("newindex");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Sravan's application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Sravan's contact page.";

            return View();
        }
    }
}