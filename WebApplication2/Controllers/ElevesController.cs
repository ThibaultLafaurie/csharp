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
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ElevesController : Controller
    {
        BusinessLayer.BusinessManager _bm = BusinessLayer.BusinessManager.GetInstance();

        // GET: Eleves
        public ActionResult Index()
        {
            var eleves = _bm.GetEleves();

            return View(eleves.ToList());
        }

        // GET: Eleves/Details/5
        public ActionResult Details(int id)
        {
            Eleve eleve = _bm.GetEleveById(id);
            List<Note> notes = _bm.GetNotesByEleve(eleve.EleveId);
            List<NoteVM> noteVMS = new List<NoteVM>();
            List<Absence> abscences = _bm.GetAbscences(eleve.EleveId);
            List<AbscenceVM> abscenceVMS = new List<AbscenceVM>();

            if (eleve == null)
            {
                return HttpNotFound();
            }


            if (notes != null)
            {
                foreach (var note in notes)
                {
                    noteVMS.Add(new NoteVM
                    {
                        NoteObtenue = note.NoteObtenue,
                        Appreciation = note.Appreciation,
                        DateNote = note.DateNote
                    });
                }
            }
            if (abscences != null)
            {
                foreach (var abscence in abscences)
                {
                    abscenceVMS.Add(new AbscenceVM
                    {
                        DateAbsence = abscence.DateAbsence,
                        Motif = abscence.Motif
                    });
                }
            }

            EleveVM eleveVM = new EleveVM
            {
                Nom = eleve.Nom,
                Prenom = eleve.Prenom,
                DateNaissance = eleve.DateNaissance,
                Notes = noteVMS,
                Absences = abscenceVMS
            };

            return View(eleveVM);
        }
    }
}
