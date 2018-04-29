using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCAlmacen.Models.Masters;
using MVCAlmacen.Models;

namespace MVCAlmacen.Areas.Config.Controllers
{
    public class CompanyController : Controller
    {
        private ApplicationDbContext _ctx;
        public CompanyController()
        {
            _ctx = new ApplicationDbContext();
        }


        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            _ctx.Dispose();

        }

        // GET: Config/Company
        public ActionResult Index()
        {
            MVCAlmacen.Models.Masters.Company model = _ctx.Company.First();
            return View(model);
        }

        // GET: Config/Company/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Config/Company/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Config/Company/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Config/Company/Edit/5
        public ActionResult Edit(Guid id)
        {
           var comp =  _ctx.Company.Where(c => c.ID == id).Single();
           

            return View(comp);
        }

        // POST: Config/Company/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Config/Company/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Config/Company/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
