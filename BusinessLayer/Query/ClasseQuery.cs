using MonTp;
using MonTp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Query
{
    class ClasseQuery
    {
        private MonContexte _monContexte;

        internal ClasseQuery(MonContexte contexte)
        {
            _monContexte = contexte;
        }

        public List<Classe> GetAll()
        {
            return _monContexte.Classes.ToList();
        }

        public Classe GetClasseById(int id)
        {
            return _monContexte.Classes.FirstOrDefault(c => c.ClasseId == id);
        }
    }
}
