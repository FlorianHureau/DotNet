using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetWpfApp.ViewModel.heritage;
using DotNetClassLibrary;


namespace DotNetWpfApp.ViewModel
{
    public class ProduitViewModel : BaseViewModel
    {
        private int _code;
        private string _libelle;
        private string _description;
        private float _prix;
        private int _stock;

        public ProduitViewModel(Produit p)
        {
            _code = p.Code;
            _libelle = p.Libelle;
            _description = p.Description;
            _prix = p.Prix;
            _stock = p.Stock;

        }

        public int Code
        {
            get { return _code; }
            set { _code = value; }
        }

        public string Libelle
        {
            get { return _libelle; }
            set { _libelle = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public float Prix
        {
            get { return _prix; }
            set { _prix = value; }
        }
        public int Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }
    }
}
