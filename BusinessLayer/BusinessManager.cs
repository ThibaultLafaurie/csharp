using BusinessLayer.Query;
using MonTp;
using MonTp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BusinessManager
    {
        #region Structure / Singleton
        public static BusinessManager _instance;

        private MonContexte _monContexte;

        private BusinessManager()
        {
            _monContexte = new MonContexte();
        }

        public static BusinessManager GetInstance()
        {
            if(_instance != null)
            {
                return _instance;
            }

            _instance = new BusinessManager();
            return _instance;
        }
        #endregion

        public List<Eleve> GetEleves()
        {
            EtudiantQuery query = new EtudiantQuery(_monContexte);
            var result = query.GetAll();
            return result;
        }

        public Eleve GetEleveById(int id)
        {
            EtudiantQuery query = new EtudiantQuery(_monContexte);
            var result = query.GetEleveById(id);
            return result;
        }

        public List<Note>GetNotesByEleve(int idEleve)
        {
            EtudiantQuery query = new EtudiantQuery(_monContexte);
            var result = query.GetEleveById(idEleve);
            return result.Notes;
        }

        public List<Absence> GetAbscences(int idEleve)
        {
            EtudiantQuery query = new EtudiantQuery(_monContexte);
            var result = query.GetEleveById(idEleve);
            return result.Absences;
        }

        public List<Classe> GetClasses()
        {
            ClasseQuery query = new ClasseQuery(_monContexte);
            var result = query.GetAll();
            return result;
        }

        public Classe GetClasseById(int id)
        {
            ClasseQuery query = new ClasseQuery(_monContexte);
            var result = query.GetClasseById(id);
            return result;
        }

        public List<Eleve> GetEleveByClasseId(int id)
        {
            List<Eleve> eleves = new List<Eleve>();
            foreach(var eleve in GetEleves())
            {
                if(eleve.ClasseId == id)
                {
                    eleves.Add(eleve);
                }
            }
            return eleves;
        }
    }
}
