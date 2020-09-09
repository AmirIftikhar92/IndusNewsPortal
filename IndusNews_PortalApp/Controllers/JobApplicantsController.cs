using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IndusNews_PortalApp.Models;

namespace IndusNews_PortalApp.Controllers
{
    public class JobApplicantsController : Controller
    {
        private DB_A66B9F_dbindusportalEntities db = new DB_A66B9F_dbindusportalEntities();
        // GET: JobApplicants
        [Authorize (Users ="hr@indus.news")]
        public ActionResult Index()
        {
            var jobApplicants = db.JobApplicants.Include(j => j.Job);
            return View(jobApplicants.ToList());
        }

        // GET: JobApplicants/Details/5
        [Authorize(Users = "hr@indus.news")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobApplicant jobApplicant = db.JobApplicants.Find(id);
            if (jobApplicant == null)
            {
                return HttpNotFound();
            }
            return View(jobApplicant);
        }

        // GET: JobApplicants/Create
        public ActionResult Create()
        {
            ViewBag.AppliedJob = new SelectList(db.Jobs, "JobId", "JobTitle");
            return View();
        }

        // POST: JobApplicants/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ApplicantId,ApplicantName,ApplicantEmail,ApplicantPhone,AppliedJob,ApplyDate")] JobApplicant jobApplicant)
        {
            if (ModelState.IsValid)
            {
                jobApplicant.ApplyDate = DateTime.Now;
                db.JobApplicants.Add(jobApplicant);
                db.SaveChanges();
                return RedirectToAction("Careers","Home");
            }

            ViewBag.AppliedJob = new SelectList(db.Jobs, "JobId", "JobTitle", jobApplicant.AppliedJob);
            return View(jobApplicant);
        }

        // GET: JobApplicants/Edit/5
        [Authorize(Users = "hr@indus.news")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobApplicant jobApplicant = db.JobApplicants.Find(id);
            if (jobApplicant == null)
            {
                return HttpNotFound();
            }
            ViewBag.AppliedJob = new SelectList(db.Jobs, "JobId", "JobTitle", jobApplicant.AppliedJob);
            return View(jobApplicant);
        }

        // POST: JobApplicants/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Users = "hr@indus.news")]
        public ActionResult Edit([Bind(Include = "ApplicantId,ApplicantName,ApplicantEmail,ApplicantPhone,AppliedJob,ApplyDate")] JobApplicant jobApplicant)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jobApplicant).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AppliedJob = new SelectList(db.Jobs, "JobId", "JobTitle", jobApplicant.AppliedJob);
            return View(jobApplicant);
        }

        // GET: JobApplicants/Delete/5
        [Authorize(Users = "hr@indus.news")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobApplicant jobApplicant = db.JobApplicants.Find(id);
            if (jobApplicant == null)
            {
                return HttpNotFound();
            }
            return View(jobApplicant);
        }

        // POST: JobApplicants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Users = "hr@indus.news")]
        public ActionResult DeleteConfirmed(int id)
        {
            JobApplicant jobApplicant = db.JobApplicants.Find(id);
            db.JobApplicants.Remove(jobApplicant);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
