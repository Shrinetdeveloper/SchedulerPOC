using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchedulerPOC.Controllers
{
    public class SchedulerController : Controller
    {
        // GET: Scheduler
        public ActionResult Index()
        {
            return View();
        }

        // GET: Scheduler/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Scheduler/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Scheduler/Create
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

        // GET: Scheduler/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Scheduler/Edit/5
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

        // GET: Scheduler/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Scheduler/Delete/5
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
