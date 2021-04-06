
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
        private ArbolEntities arbol = new ArbolEntities();
        public ActionResult Index()
        {
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
            return View(nodos.ObtenerP(id));
        }

        public ActionResult New(int id = 0) 
        {
            return View(id > 0 ? nodos.ObtenerP(id)
                : this.nodos
                ); ;
        }
        public ActionResult NewQuestion(int id = 0)
        {
            return View(id > 0 ? nodos.ObtenerP(id)
                : this.nodos
                ); ;
        }
        public ActionResult Listo(Nodo x) 
        {
            ViewBag.Nod = x.ObtenerP(x.padre.GetValueOrDefault()).Id;

            x.Listo();
            return Redirect("~/Home/NewQuestion/" + (ViewBag.Nod));

        }
        public ActionResult Clo(Nodo x)
        {
            x.Clonar();
            return Redirect("~/Home/New/" + x.Id);

        }
        public ActionResult Finalizar(Nodo x)
        {
            x.FinalizarEn();
            ViewBag.Nod = x.ObtenerP(x.padre.GetValueOrDefault()).hizq;
            return Redirect("/Home");

        }
        public ActionResult Editar(int id = 1)
        {
            return View();

        }
    }
}