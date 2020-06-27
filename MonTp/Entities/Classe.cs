using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonTp.Entities
{
    public class Classe
    {
        public int ClasseId { get; set; }

        public string NomEtablissement { get; set; }

        public string Niveau { get; set; }

        public List<Eleve> Eleves { get; set; }
    }
}
