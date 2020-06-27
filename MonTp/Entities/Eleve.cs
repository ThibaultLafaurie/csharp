using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonTp.Entities
{
    public class Eleve
    {
        public int EleveId { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public DateTime DateNaissance { get; set; }

        public List<Note> Notes { get; set;  }

        public List<Absence> Absences { get; set; }

        public Classe Classe { get; set; }

        public int ClasseId { get; set; }
    }
}
