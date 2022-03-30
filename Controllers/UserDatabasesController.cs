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
    public class UserDatabasesController : Controller
    {
        private context db = new context();

        // GET: UserDatabases
        public ActionResult Index(int? page, string search)
        {
            var user = from u in db.UserDatabase select u;
            user = db.UserDatabase.OrderBy(u => u.lastName).ThenBy(u => u.firstName); ;
            if (!String.IsNullOrEmpty(search))
            {
                user = user.Where(u => u.lastName.Contains(search) || u.firstName.Contains(search));
            }
            var userList = user.ToList();
            return View(userList);
        }

        // GET: UserDatabases/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserDatabase userDatabase = db.UserDatabase.Find(id);
            if (userDatabase == null)
            {
                return HttpNotFound();
            }
            return View(userDatabase);
        }

        // GET: UserDatabases/Create
        [Authorize]
        public ActionResult Create()
        {
            ViewBag.errorMessage = "";
            return View();
        }

        // POST: UserDatabases/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,lastName,firstName,businessUnit,office,startDate")] UserDatabase userDatabase)
        {
            if (ModelState.IsValid && userDatabase.businessUnit != 0 && userDatabase.office != 0) 
            {
                userDatabase.ID = Guid.NewGuid();
                db.UserDatabase.Add(userDatabase);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.errorMessage = "Please make sure you have selected Business Unit and Title";
            return View(userDatabase);

        }

        // GET: UserDatabases/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserDatabase userDatabase = db.UserDatabase.Find(id);
            if (userDatabase == null)
            {
                return HttpNotFound();
            }
            return View(userDatabase);
        }

        // POST: UserDatabases/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,lastName,firstName,businessUnit,office,startDate")] UserDatabase userDatabase)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userDatabase).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userDatabase);
        }

        // GET: UserDatabases/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserDatabase userDatabase = db.UserDatabase.Find(id);
            if (userDatabase == null)
            {
                return HttpNotFound();
            }
            return View(userDatabase);
        }

        // POST: UserDatabases/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            UserDatabase userDatabase = db.UserDatabase.Find(id);
            db.UserDatabase.Remove(userDatabase);
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
