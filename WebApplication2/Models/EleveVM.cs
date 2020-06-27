using MonTp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class EleveVM
    {

        public int EleveId { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public DateTime DateNaissance { get; set; }

        public List<NoteVM> Notes { get; set; }

        public List<AbscenceVM> Absences { get; set; }

        public Classe Classe { get; set; }

        public int ClasseId { get; set; }
    }
}