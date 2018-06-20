using DotNetClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BusinessManager
    {
        private readonly Context contexte;
        private static BusinessManager _businessManager = null;

        private BusinessManager()
        {
            contexte = new Context();
        }

        public static BusinessManager Instance
        {
            get
            {
                if (_businessManager == null)
                    _businessManager = new BusinessManager();
                return _businessManager;
            }
        }

        public List<Produit> GetAllProduit()
        {
            return contexte.Produits.ToList();
        }
    }
}
