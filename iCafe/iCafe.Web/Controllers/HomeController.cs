using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using iCafe.DAL;
using iCafe.Models;

namespace iCafe.Web.Controllers
{
    public class HomeController : Controller
    {

        iCafeEntities entities = new iCafeEntities();

        public ActionResult Index()
        {
            var modal = entities.Roles.ToList();

            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
