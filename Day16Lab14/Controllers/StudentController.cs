using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day16Lab14.Models;
using System.Data.Entity;

namespace Day16Lab14.Controllers
{
    public class StudentController : Controller
    {
        Wizarding_World _db = new Wizarding_World();

        [HttpGet]
        public ActionResult Index()
        {
            var stds = _db.Students.Include(s => s.House).ToList();
            return View(stds);
        }

        [HttpGet]
        public ActionResult CreateNew()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student std)
        {
            _db.Students.Add(std);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var std = _db.Students.Find(id);
            return View(std);
        }

        [HttpPost]
        public ActionResult Edited(Student newstd)
        {
            _db.Entry(newstd).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var std = _db.Students.Find(id);
            return View(std);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var delstd = _db.Students.Find(id);
            _db.Students.Remove(delstd);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}