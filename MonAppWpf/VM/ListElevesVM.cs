using BusinessLayer;
using MonAppWpf.VM.Common;
using MonTp.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonAppWpf.VM
{
    public class ListElevesVM : BaseViewModel
    {
        private ObservableCollection<DetailEtudiantVM> _eleves;
        private DetailEtudiantVM _detail;
        private BusinessLayer.BusinessManager _bm;

        public ListElevesVM()
        {
            _bm = BusinessLayer.BusinessManager.GetInstance();
            _eleves = new ObservableCollection<DetailEtudiantVM>();

            foreach(Eleve eleve in _bm.GetEleves())
            {
                DetailEtudiantVM detailEtudiant = new DetailEtudiantVM
                {
                    Nom = eleve.Nom,
                    Prenom = eleve.Prenom
                };

                ICollection<Note> notes = _bm.GetNotesByEleve(eleve.EleveId);
                detailEtudiant.Moyenne = 10;
                _eleves.Add(detailEtudiant);
            }

            if(_eleves != null && _eleves.Count > 0)
            {
                _detail = _eleves.ElementAt(0);
            }
        }
         
        public ObservableCollection<DetailEtudiantVM> Eleves  
        {
            get { return _eleves; }
            set { _eleves = value; OnPropertyChanged("Eleves"); }
        }

        public DetailEtudiantVM SelectedEleve
        { 
            get { return _detail; }
            set { _detail = value; OnPropertyChanged("SelectedEleve"); }
        }
    }
}
