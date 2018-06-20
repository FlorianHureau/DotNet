using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetWpfApp.ViewModel
{
    public class ViewModelBase
    {
        private ListeProduitViewModel _listeViewModel = null;

        public ViewModelBase()
        {
            _listeViewModel = new ListeProduitViewModel();
        }

        public ListeProduitViewModel ListeProduitViewModel
        {
            get { return _listeViewModel; }
            set { _listeViewModel = value; }
        }

    }
}
