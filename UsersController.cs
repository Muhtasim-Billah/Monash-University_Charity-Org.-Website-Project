using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HighDistinctionTask.Models;

namespace HighDistinctionTask.Controllers
{
    public class UsersController : Controller
    {
        private CharityEntities1 db = new CharityEntities1();

        // GET: /Users/
        public ActionResult Index()
        {
            return View(db.RegisteredUsers.OrderBy(r => r.first_name).ToList());
        }

        // GET: /Users/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegisteredUser registereduser = db.RegisteredUsers.Find(id);
            if (registereduser == null)
            {
                return HttpNotFound();
            }
            return View(registereduser);
        }

        // GET: /Users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="user_id,first_name,last_name,gender,password,address,email,postcode,state")] RegisteredUser registereduser)
        {
            if (ModelState.IsValid)
            {
                db.RegisteredUsers.Add(registereduser);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(registereduser);
        }

        // GET: /Users/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegisteredUser registereduser = db.RegisteredUsers.Find(id);
            if (registereduser == null)
            {
                return HttpNotFound();
            }
            return View(registereduser);
        }

        // POST: /Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="user_id,first_name,last_name,gender,password,address,email,postcode,state")] RegisteredUser registereduser)
        {
            if (ModelState.IsValid)
            {
                db.Entry(registereduser).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(registereduser);
        }

        // GET: /Users/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegisteredUser registereduser = db.RegisteredUsers.Find(id);
            if (registereduser == null)
            {
                return HttpNotFound();
            }
            return View(registereduser);
        }

        // POST: /Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RegisteredUser registereduser = db.RegisteredUsers.Find(id);
            db.RegisteredUsers.Remove(registereduser);
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
