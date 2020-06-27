using MonTp;
using MonTp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Query
{
    internal class EtudiantQuery
    {
        private MonContexte _monContexte;

        internal EtudiantQuery(MonContexte contexte)
        {
            _monContexte = contexte;
        }

        public List<Eleve> GetAll()
        {
            return _monContexte.Eleves.ToList();
        }

        public Eleve GetEleveById(int id)
        {
            return _monContexte.Eleves.FirstOrDefault(e => e.EleveId == id);
        }
    }
}
