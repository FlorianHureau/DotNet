using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DotNetClassLibrary;

namespace MVC.Controllers
{
    public class ProduitController : Controller
    {
        // GET: Produit
        public ActionResult Produits()
        {
            BusinessLayer.Queries.ProduitQuery manager = new BusinessLayer.Queries.ProduitQuery(myContext);
            var produits = new Produit();
            produits = manager.GetByID(1);
            return View("Produits",new Produit()); //changer le new produit par le produit à visualiser
        }
    }
}