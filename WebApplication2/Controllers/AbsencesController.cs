using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MonTp;
using MonTp.Entities;

namespace WebApplication2.Controllers
{
    public class AbsencesController : Controller
    {
        private MonContexte db = new MonContexte();

        // GET: Absences/Create
        public ActionResult Create()
        {
            ViewBag.EleveId = new SelectList(db.Eleves, "EleveId", "Nom");
            return View();
        }

        // POST: Absences/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AbsenceId,DateAbsence,Motif,EleveId")] Absence absence)
        {
            if (ModelState.IsValid)
            {
                db.Absences.Add(absence);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EleveId = new SelectList(db.Eleves, "EleveId", "Nom", absence.EleveId);
            return View(absence);
        }
    }
}
