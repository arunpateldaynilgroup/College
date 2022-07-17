using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _21__Mvc_ViewBag.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int hours = DateTime.Now.Hour; 
            ViewBag.test = hours < 12 ? "Good Morning" : "Good day";
            return View();
        }
    }
}