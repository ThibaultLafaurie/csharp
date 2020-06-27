using MonTp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class ClasseVM
    {
        public int ClasseId { get; set; }

        public string NomEtablissement { get; set; }

        public string Niveau { get; set; }

        public List<EleveVM> Eleves { get; set; }
    }
}