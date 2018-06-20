using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DotNetClassLibrary;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        public Context myContext = new Context();
        public ActionResult Index()
        {
            BusinessLayer.Queries.ProduitQuery manager = new BusinessLayer.Queries.ProduitQuery(myContext);
            var produits = new List<Produit>();
            produits = manager.GetAll().ToList();
            return View("Index",produits);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}