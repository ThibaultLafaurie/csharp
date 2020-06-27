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
    public class NotesController : Controller
    {
        private MonContexte db = new MonContexte();


        // GET: Notes/Create
        public ActionResult Create()
        {
            ViewBag.EleveId = new SelectList(db.Eleves, "EleveId", "Nom");
            return View();
        }

        // POST: Notes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NoteId,Matiere,NoteObtenue,DateNote,Appreciation,EleveId")] Note note)
        {
            if (ModelState.IsValid)
            {
                db.Notes.Add(note);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EleveId = new SelectList(db.Eleves, "EleveId", "Nom", note.EleveId);
            return View(note);
        }

        // GET: Notes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Note note = db.Notes.Find(id);
            if (note == null)
            {
                return HttpNotFound();
            }
            ViewBag.EleveId = new SelectList(db.Eleves, "EleveId", "Nom", note.EleveId);
            return View(note);
        }

        // POST: Notes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NoteId,Matiere,NoteObtenue,DateNote,Appreciation,EleveId")] Note note)
        {
            if (ModelState.IsValid)
            {
                db.Entry(note).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EleveId = new SelectList(db.Eleves, "EleveId", "Nom", note.EleveId);
            return View(note);
        }
    }
}
