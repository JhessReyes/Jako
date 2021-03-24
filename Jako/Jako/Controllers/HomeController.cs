
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
        private Nodo F = new Nodo();
        private ArbolEntities arbol = new ArbolEntities();
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Pregunta(int id)
        {
            return View(nodos.ObtenerP(id));
        }

        public ActionResult Respuesta(int id)
        {
            ViewBag.Iden = id;
            return View(F.Listar());
        }

        public ActionResult New(int id = 0) 
        {
            return View(id > 0 ? nodos.ObtenerP(id)
                : this.nodos
                ); ;
        }

        public ActionResult Listo(Nodo x) 
            {
            x.Listo();
            return Redirect("~/home/New/" + x.ObtenerP(x.padre.GetValueOrDefault()).Id);
        }

    }
}