using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetClassLibrary;

namespace BusinnessLayer.Query
{
    public class ProduitQuery
    {
        private readonly Context _contexte;

        public ProduitQuery(Context contexte)
        {
            _contexte = contexte;
        }

        public IQueryable<Produit> GetAll()
        {
            return _contexte.Produits;
        }
    }
}
