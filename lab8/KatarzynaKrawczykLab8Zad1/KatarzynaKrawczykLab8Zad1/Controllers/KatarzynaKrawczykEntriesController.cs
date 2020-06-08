using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KatarzynaKrawczykLab8Zad1.Models;

namespace KatarzynaKrawczykLab8Zad1.Controllers
{
    public class KatarzynaKrawczykEntriesController : Controller
    {
        //próbowałam zmienić namespace, ale niesttey za każdym razem zostawała nazwa bazy danych i nie udalo mi się ego naprawić.
        private DB_9B1FC5_cpc20181Entities1 db = new DB_9B1FC5_cpc20181Entities1();

        // GET: KatarzynaKrawczykEntries
        public ActionResult Index(string word)
        {
            return View(db.KatarzynaKrawczykEntries.Where(x=> x.Keyword.Contains(word) || word ==null).ToList());
        }
        // GET: KatarzynaKrawczykEntries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KatarzynaKrawczykEntries katarzynaKrawczykEntries = db.KatarzynaKrawczykEntries.Find(id);
            if (katarzynaKrawczykEntries == null)
            {
                return HttpNotFound();
            }
            return View(katarzynaKrawczykEntries);
        }


        // GET: KatarzynaKrawczykEntries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KatarzynaKrawczykEntries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Keyword,Definition,Description")] KatarzynaKrawczykEntries katarzynaKrawczykEntries)
        {
            if (ModelState.IsValid)
            {
                db.KatarzynaKrawczykEntries.Add(katarzynaKrawczykEntries);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(katarzynaKrawczykEntries);
        }

        // GET: KatarzynaKrawczykEntries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KatarzynaKrawczykEntries katarzynaKrawczykEntries = db.KatarzynaKrawczykEntries.Find(id);
            if (katarzynaKrawczykEntries == null)
            {
                return HttpNotFound();
            }
            return View(katarzynaKrawczykEntries);
        }

        // POST: KatarzynaKrawczykEntries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Keyword,Definition,Description")] KatarzynaKrawczykEntries katarzynaKrawczykEntries)
        {
            if (ModelState.IsValid)
            {
                db.Entry(katarzynaKrawczykEntries).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(katarzynaKrawczykEntries);
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
