using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonTp.Entities
{
    public class Absence
    {
        public int AbsenceId { get; set; }

        public DateTime DateAbsence { get; set; }

        public string Motif { get; set; }

        public Eleve Eleve { get; set; }

        public int EleveId { get; set; }
    }
}
