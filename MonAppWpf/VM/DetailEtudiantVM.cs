using MonAppWpf.VM.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonAppWpf.VM
{
    public class DetailEtudiantVM : BaseViewModel
    {
        public string Nom { get; set; }

        public string Prenom { get; set; }

        public double Moyenne { get; set; }
    }
}
