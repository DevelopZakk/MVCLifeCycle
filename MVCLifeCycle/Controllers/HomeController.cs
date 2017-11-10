using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCLifeCycle.Extension;

namespace MVCLifeCycle.Controllers
{
    [CustomerFilters1]
    public class HomeController : Controller
    {
        [CustomerFilters2]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [IsMobile]
        public ActionResult Contact(string id)
        {
            ViewBag.Message = "Hello Mobile";
            return View();
        }

        public ActionResult File()
        {
            Response.AddHeader("Content-Disposition", "inline; filename=test.config");
            return new FileContentResult(System.IO.File.ReadAllBytes(@"D:\web.config"),"application/text");
        }
    }
}