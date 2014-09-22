using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PACGOPDB.Models;
using PACGOPDB.DAL;

namespace PACGOPDB.Controllers
{
    public class CardTypeController : Controller
    {
        private DBContext db = new DBContext();

        // GET: /CardType/
        public ActionResult Index()
        {
            return View(db.CardTypes.ToList());
        }

        // GET: /CardType/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CardType cardtype = db.CardTypes.Find(id);
            if (cardtype == null)
            {
                return HttpNotFound();
            }
            return View(cardtype);
        }

        // GET: /CardType/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /CardType/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ID,Name")] CardType cardtype)
        {
            if (ModelState.IsValid)
            {
                db.CardTypes.Add(cardtype);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cardtype);
        }

        // GET: /CardType/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CardType cardtype = db.CardTypes.Find(id);
            if (cardtype == null)
            {
                return HttpNotFound();
            }
            return View(cardtype);
        }

        // POST: /CardType/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID,Name")] CardType cardtype)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cardtype).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cardtype);
        }

        // GET: /CardType/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CardType cardtype = db.CardTypes.Find(id);
            if (cardtype == null)
            {
                return HttpNotFound();
            }
            return View(cardtype);
        }

        // POST: /CardType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CardType cardtype = db.CardTypes.Find(id);
            db.CardTypes.Remove(cardtype);
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
