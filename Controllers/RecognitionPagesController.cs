using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Centric_Team_3.DAL;
using Centric_Team_3.Models;

namespace Centric_Team_3.Controllers
{
    public class RecognitionPagesController : Controller
    {
        private context db = new context();

        // GET: RecognitionPages
        public ActionResult Index()
        {
            return View(db.RecognitionPages.ToList());
        }

        // GET: RecognitionPages/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RecognitionPage recognitionPage = db.RecognitionPages.Find(id);
            if (recognitionPage == null)
            {
                return HttpNotFound();
            }
            return View(recognitionPage);
        }

        // GET: RecognitionPages/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: RecognitionPages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,RecognitionID,myName,coreValues,reward")] RecognitionPage recognitionPage)
        {
            if (ModelState.IsValid)
            {
                db.RecognitionPages.Add(recognitionPage);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(recognitionPage);
        }

        // GET: RecognitionPages/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RecognitionPage recognitionPage = db.RecognitionPages.Find(id);
            if (recognitionPage == null)
            {
                return HttpNotFound();
            }
            return View(recognitionPage);
        }

        // POST: RecognitionPages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,RecognitionID,myName,coreValues,reward")] RecognitionPage recognitionPage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(recognitionPage).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(recognitionPage);
        }

        // GET: RecognitionPages/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RecognitionPage recognitionPage = db.RecognitionPages.Find(id);
            if (recognitionPage == null)
            {
                return HttpNotFound();
            }
            return View(recognitionPage);
        }

        // POST: RecognitionPages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RecognitionPage recognitionPage = db.RecognitionPages.Find(id);
            db.RecognitionPages.Remove(recognitionPage);
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
