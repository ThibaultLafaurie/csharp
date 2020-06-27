using MonTp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetEleves()
        {
            BusinessLayer.BusinessManager _bm = BusinessLayer.BusinessManager.GetInstance();
            List<Eleve> eleves = _bm.GetEleves();

            List<EleveVM> eleveVMS = new List<EleveVM>();

            foreach (var eleve in eleves)
            {
                eleveVMS.Add(new EleveVM { Nom = eleve.Nom });
            }

            return View(eleveVMS);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}