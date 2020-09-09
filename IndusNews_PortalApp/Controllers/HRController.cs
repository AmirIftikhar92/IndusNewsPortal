using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IndusNews_PortalApp.Models;

namespace IndusNews_PortalApp.Controllers
{
    public class HRController : Controller
    {
        // GET: HR
        [Authorize(Users = "hr@indus.news")]
        public ActionResult Dashboard()
        {
            return View();
        }
    }
}