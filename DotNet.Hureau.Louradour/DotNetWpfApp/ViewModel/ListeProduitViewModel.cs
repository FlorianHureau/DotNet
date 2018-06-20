using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using DotNetWpfApp.ViewModel.heritage;
using DotNetClassLibrary;
using BusinessLayer;

namespace DotNetWpfApp.ViewModel
{
    public class ListeProduitViewModel : BaseViewModel
    {
        private ObservableCollection<ProduitViewModel> _produits = null;
        private ProduitViewModel _selectedProduit;

        public ListeProduitViewModel()
        {
            _produits = new ObservableCollection<ProduitViewModel>();
            foreach(Produit p in BusinessManager.Instance.GetAllProduit())
            {
                _produits.Add(new ProduitViewModel(p));

            }

            if(_produits != null && _produits.Count > 0)
            {
                _selectedProduit = _produits.ElementAt(0);
            }
        }

        public ObservableCollection<ProduitViewModel> Produits
        {
            get { return _produits; }
            set
            {
                _produits = value;
                OnPropertyChanged("Produits");
            }
        }

        public ProduitViewModel SelectedProduit
        {
            get { return _selectedProduit; }
            set
            {
                _selectedProduit = value;
                OnPropertyChanged("SelectedProduit");
            }
        }
    }
}
