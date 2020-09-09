using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IndusNews_PortalApp.Models;

namespace IndusNews_PortalApp.Controllers
{
    public class AccountsFinanceController : Controller
    {
        // GET: AccountsFinance
        [Authorize(Users = "accounts@indus.news")]
        public ActionResult Dashboard()
        {
            return View();
        }
    }
}