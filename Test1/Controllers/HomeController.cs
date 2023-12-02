using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowInfo()
        {
            return View("Show");
        }
        public ActionResult Detail()
        { 
            return View("Details");
        }
        public ActionResult ShowMoreDetail() 
        {
            return View("~/Views/About/Index.cshtml");
        }
    }
}