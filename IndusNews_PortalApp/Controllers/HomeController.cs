using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IndusNews_PortalApp.Models;

namespace IndusNews_PortalApp.Controllers
{
    public class HomeController : Controller
    {
        private DB_A66B9F_dbindusportalEntities db = new DB_A66B9F_dbindusportalEntities();
        public ActionResult Homepage()
        {
            return View();
        }

        //GET: Careers
        public ActionResult Careers()
        {
            return View(db.Jobs.ToList());
        }

        //GET: Apply
        public ActionResult JobApply()
        {
            return View();
        }

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
    }
}