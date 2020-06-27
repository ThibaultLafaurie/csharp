using MonTp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class AbscenceVM
    {
        public int AbsenceId { get; set; }

        public DateTime DateAbsence { get; set; }

        public string Motif { get; set; }

        public Eleve Eleve { get; set; }

        public int EleveId { get; set; }
    }
}