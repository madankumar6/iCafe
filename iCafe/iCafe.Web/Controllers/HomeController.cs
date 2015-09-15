using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using iCafe.DAL;
using iCafe.Models;
using iCafe.Repositories;
using iCafe.Repositories.Interfaces;
using iCafe.Repositories.Interfaces.Concrete;

namespace iCafe.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private IUnitOfWork unitOfWork;

        public HomeController() : this(new UnitOfWork())
        {

        }

        public HomeController(IUnitOfWork UnitOfWork)
        {
            this.unitOfWork = UnitOfWork;
        }

        public ActionResult Index()
        {
            //var modal = entities.Roles.ToList();

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
