using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CRUD_19_04_29.Models;

namespace CRUD_19_04_29.Controllers
{
    public class GETController : Controller
    {
        private Data db = new Data();




       // GET: GET
        public ActionResult Index(string search )
        {

            
            int srt = Convert.ToInt32(search);


            var IDENT = from I in db.Registers
                        select I;
            

         

            if (!String.IsNullOrEmpty(search))
            {

                return View(db.Registers.Where(I => I.IDENT == srt).ToList());
            }


            return View(db.Registers.ToList());
        }






        // GET: GET/Details/5
        public ActionResult Details(int? id)
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                Register register = db.Registers.Find(id);
                if (register == null)
                {
                    return HttpNotFound();
                }
                return View(register);
            }

            // GET: GET/Create
            public ActionResult Create()
            {
                return View();
            }

            // POST: GET/Create
            // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
            // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Create([Bind(Include = "CODE,IDENT,Name,Age,Address")] Register register)
            {
                if (ModelState.IsValid)
                {
                    db.Registers.Add(register);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(register);
            }

            // GET: GET/Edit/5
            public ActionResult Edit(int? id)
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                Register register = db.Registers.Find(id);
                if (register == null)
                {
                    return HttpNotFound();
                }
                return View(register);
            }

            // POST: GET/Edit/5
            // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
            // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Edit([Bind(Include = "CODE,IDENT,Name,Age,Address")] Register register)
            {
                if (ModelState.IsValid)
                {
                    db.Entry(register).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(register);
            }

            // GET: GET/Delete/5
            public ActionResult Delete(int? id)
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                Register register = db.Registers.Find(id);
                if (register == null)
                {
                    return HttpNotFound();
                }
                return View(register);
            }

            // POST: GET/Delete/5
            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public ActionResult DeleteConfirmed(int id)
            {
                Register register = db.Registers.Find(id);
                db.Registers.Remove(register);
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
