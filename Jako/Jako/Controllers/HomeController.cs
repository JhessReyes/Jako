
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Jako.Models;

namespace Jako.Controllers
{
    public class HomeController : Controller
    {
        private Nodo nodos = new Nodo();
  //      private ArbolEntities arbol = new ArbolEntities();
        public ActionResult Index()
        {
            return View(nodos.Listar());
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