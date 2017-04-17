using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ToltekLMSPortal.Models;

namespace ToltekLMSPortal.Controllers
{
    public class CourseController : Controller
    {
        private TLMSPortalEntity db = new TLMSPortalEntity();

        // GET: Course
        public ActionResult Index()
        {
            var course = db.Course.Include(c => c.Company).Include(c => c.Unit).Include(c => c.CourseSettings).Include(c => c.CourseStats);
            return View(course.ToList());
        }

        // GET: Course/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = db.Course.Find(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        // GET: Course/Create
        public ActionResult Create()
        {
            ViewBag.CompanyId = new SelectList(db.Company, "CompanyId", "CompanyName");
            ViewBag.UnitId = new SelectList(db.Unit, "UnitId", "UnitName");
            ViewBag.CourseId = new SelectList(db.CourseSettings, "CourseId", "CourseId");
            ViewBag.CourseId = new SelectList(db.CourseStats, "CourseId", "CourseId");
            return View();
        }

        // POST: Course/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CompanyId,UnitId,CourseId,ImportKey,UniqueKey,Code,Name,EType,CMode,CType,Enable,Paid,Deleted,CUId,CDate,CUName,UUId,UDate,UUName")] Course course)
        {
            if (ModelState.IsValid)
            {
                db.Course.Add(course);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CompanyId = new SelectList(db.Company, "CompanyId", "CompanyName", course.CompanyId);
            ViewBag.UnitId = new SelectList(db.Unit, "UnitId", "UnitName", course.UnitId);
            ViewBag.CourseId = new SelectList(db.CourseSettings, "CourseId", "CourseId", course.CourseId);
            ViewBag.CourseId = new SelectList(db.CourseStats, "CourseId", "CourseId", course.CourseId);
            return View(course);
        }

        // GET: Course/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = db.Course.Find(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            ViewBag.CompanyId = new SelectList(db.Company, "CompanyId", "CompanyName", course.CompanyId);
            ViewBag.UnitId = new SelectList(db.Unit, "UnitId", "UnitName", course.UnitId);
            ViewBag.CourseId = new SelectList(db.CourseSettings, "CourseId", "CourseId", course.CourseId);
            ViewBag.CourseId = new SelectList(db.CourseStats, "CourseId", "CourseId", course.CourseId);
            return View(course);
        }

        // POST: Course/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CompanyId,UnitId,CourseId,ImportKey,UniqueKey,Code,Name,EType,CMode,CType,Enable,Paid,Deleted,CUId,CDate,CUName,UUId,UDate,UUName")] Course course)
        {
            if (ModelState.IsValid)
            {
                db.Entry(course).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CompanyId = new SelectList(db.Company, "CompanyId", "CompanyName", course.CompanyId);
            ViewBag.UnitId = new SelectList(db.Unit, "UnitId", "UnitName", course.UnitId);
            ViewBag.CourseId = new SelectList(db.CourseSettings, "CourseId", "CourseId", course.CourseId);
            ViewBag.CourseId = new SelectList(db.CourseStats, "CourseId", "CourseId", course.CourseId);
            return View(course);
        }

        // GET: Course/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = db.Course.Find(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        // POST: Course/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Course course = db.Course.Find(id);
            db.Course.Remove(course);
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
