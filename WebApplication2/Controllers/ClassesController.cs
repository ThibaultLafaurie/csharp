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
    public class ClassesController : Controller
    {
        BusinessLayer.BusinessManager _bm = BusinessLayer.BusinessManager.GetInstance();

        // GET: Classes
        public ActionResult Index()
        {
            BusinessLayer.BusinessManager _bm = BusinessLayer.BusinessManager.GetInstance();
            List<Classe> classes = _bm.GetClasses();

            List<ClasseVM> classeVMS = new List<ClasseVM>();

            foreach (var classe in classes)
            {
                classeVMS.Add(new ClasseVM {
                    NomEtablissement = classe.NomEtablissement,
                    Niveau = classe.Niveau,
                    ClasseId = classe.ClasseId
                });
            }

            return View(classeVMS);
        }

        // GET: Classes/Details/5
        public ActionResult Details(int id)
        {
            BusinessLayer.BusinessManager _bm = BusinessLayer.BusinessManager.GetInstance();
            Classe classe = _bm.GetClasseById(id);

            if (classe == null)
            {
                return HttpNotFound();
            }

            List<Eleve> eleves = _bm.GetEleveByClasseId(id);
            List<EleveVM> eleveVMS = new List<EleveVM>();

            if (eleves != null)
            {
                foreach (var eleve in eleves)
                {
                    eleveVMS.Add(new EleveVM
                    {
                        Nom = eleve.Nom,
                        Prenom = eleve.Prenom
                    });
                }
            }

            ClasseVM classeVM = new ClasseVM
            {
                NomEtablissement = classe.NomEtablissement,
                Eleves = eleveVMS,
                Niveau = classe.Niveau,
                ClasseId = classe.ClasseId
            };

            return View(classeVM);
        }
    }
}
