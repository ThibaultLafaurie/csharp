using MonAppWpf.VM.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonAppWpf.VM
{
    public class MainWindowVM : BaseViewModel
    {
        private ListElevesVM _listElevesVM;

        public MainWindowVM()
        {
            ListElevesVM = new ListElevesVM();
        }

        public ListElevesVM ListElevesVM
        {
            get { return _listElevesVM; }
            set { _listElevesVM = value;  }
        }
    }
}
