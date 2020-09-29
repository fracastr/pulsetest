using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var mvcName = typeof(Controller).Assembly.GetName();
            var isMono = Type.GetType("Mono.Runtime") != null;

            ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
            ViewData["Runtime"] = isMono ? "Mono" : ".NET";

            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(FormCollection model)
        {
            string titulo = model["Titulo"];
            string fecha = model["Fecha"];
            string descripcion = model["Descripcion"];

            //Aqui debe ir la logica del guardado en la base de datos
            
            Models.Evento evento = new Models.Evento();
            evento.Id = Guid.NewGuid();
            evento.Titulo = titulo;
            evento.FechaEvento = DateTime.Parse(fecha);
            evento.Descripcion = descripcion;

            //evento.Save();

            return View("Index");
        }

        public ActionResult Invitate()
        {
            return View();
        }
    }
}
