using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LabPracticeProblem;

namespace LabPracticeProblem.Controllers
{
    public class DeepakFriendsController : Controller
    {
        private AdventureWorks2017Entities db = new AdventureWorks2017Entities();

        // GET: DeepakFriends
        public ActionResult Index()
        {
            return View(db.DeepakFriends.ToList());
        }

        // GET: DeepakFriends/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DeepakFriend deepakFriend = db.DeepakFriends.Find(id);
            if (deepakFriend == null)
            {
                return HttpNotFound();
            }
            return View(deepakFriend);
        }

        // GET: DeepakFriends/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DeepakFriends/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FriendID,FriendName,Place")] DeepakFriend deepakFriend)
        {
            if (ModelState.IsValid)
            {
                db.DeepakFriends.Add(deepakFriend);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(deepakFriend);
        }

        // GET: DeepakFriends/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DeepakFriend deepakFriend = db.DeepakFriends.Find(id);
            if (deepakFriend == null)
            {
                return HttpNotFound();
            }
            return View(deepakFriend);
        }

        // POST: DeepakFriends/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FriendID,FriendName,Place")] DeepakFriend deepakFriend)
        {
            if (ModelState.IsValid)
            {
                db.Entry(deepakFriend).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(deepakFriend);
        }

        // GET: DeepakFriends/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DeepakFriend deepakFriend = db.DeepakFriends.Find(id);
            if (deepakFriend == null)
            {
                return HttpNotFound();
            }
            return View(deepakFriend);
        }

        // POST: DeepakFriends/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DeepakFriend deepakFriend = db.DeepakFriends.Find(id);
            db.DeepakFriends.Remove(deepakFriend);
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
