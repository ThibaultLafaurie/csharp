using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonTp.Entities
{
    public class Note
    {
        public int NoteId { get; set; }

        public string Matiere { get; set; }

        public double NoteObtenue { get; set; }

        public DateTime DateNote { get; set; }

        public string Appreciation { get; set; }

        public Eleve Eleve { get; set; }

        public int EleveId { get; set; }
    }
}
