using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IndusNews_PortalApp.Models;

namespace IndusNews_PortalApp.Controllers
{
    public class EmpDashboardController : Controller
    {
        private DB_A66B9F_dbindusportalEntities db = new DB_A66B9F_dbindusportalEntities();
        // GET: EmpDashboard
        [Authorize]
        public ActionResult Dashboard()
        {
            return View();
        }

        //GET: Emp Attendance
        [Authorize]
        public ActionResult EmpAttendance()
        {
            var eId = db.Employees.Where(c => c.EmpEmail == User.Identity.Name).Select(s => s.EmployeeId).FirstOrDefault();
            return View(db.Attendances.ToList().Where(a => a.EmpId == eId));
        }

        [Authorize]
        public ActionResult BioData(string email)
        {
            email = User.Identity.Name;
            if (email == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(email);
            if (email == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }
    }
}