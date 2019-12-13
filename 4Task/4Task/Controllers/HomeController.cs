using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _4Task.Models;
using Microsoft.EntityFrameworkCore;

namespace _4Task.Controllers
{
    public class HomeController : Controller
    {
        CityContext db;
        public HomeController(CityContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Cities.ToList());
        }

        public IActionResult Index_Pilot()
        {
            return View(db.Pilots.ToList());
        }

        //для Едита
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            City city = db.Cities.Find(id);
            if (city != null)
            {
                return View(city);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Edit(City city)
        {
            db.Entry(city).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //для добавления
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(City city)
        {
            db.Cities.Add(city);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        //для удаления
        [HttpGet]
        public ActionResult Delete(int id)
        {
            City ForDelete = db.Cities.Find(id);
            if (ForDelete == null)
            {
                return RedirectToAction("Index");
            }
            return View(ForDelete);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            City ForDelete = db.Cities.Find(id);
            if (ForDelete == null)
            {
                return RedirectToAction("Index");
            }
            db.Cities.Remove(ForDelete);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details (int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index_pilot");
            }
            Pilot pilot = db.Pilots.Find(id);
            if (pilot == null)
            {
                return RedirectToAction("Index_pilot");
            }
            return View(pilot);
        }

        [HttpGet]
        public IActionResult Edit_pilot(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            Pilot pilot = db.Pilots.Find(id);
            if (pilot != null)
            {
                return View(pilot);
            }
            return RedirectToAction("Index_pilot");
        }
        [HttpPost]
        public ActionResult Edit_pilot(Pilot pilot)
        {
            db.Entry(pilot).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index_pilot");
        }

        [HttpGet]
        public ActionResult Delete_pilot(int id)
        {
            Pilot ForDelete = db.Pilots.Find(id);
            if (ForDelete == null)
            {
                return RedirectToAction("Index_pilot");
            }
            return View(ForDelete);
        }
        [HttpPost, ActionName("Delete_pilot")]
        public ActionResult DeleteConfirmed_pilot(int id)
        {
            Pilot ForDelete = db.Pilots.Find(id);
            if (ForDelete == null)
            {
                return RedirectToAction("Index_pilot");
            }
            db.Pilots.Remove(ForDelete);
            db.SaveChanges();
            return RedirectToAction("Index_pilot");
        }

        //для добавления
        [HttpGet]
        public ActionResult Create_pilot()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create_pilot(Pilot pilot)
        {
            db.Pilots.Add(pilot);
            db.SaveChanges();

            return RedirectToAction("Index_pilot");
        }

    }
}
