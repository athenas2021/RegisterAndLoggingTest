using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegisterAndLogginTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Exemplo de ViewBag Sobre (camada controle - metodo ActionResult) ";
            ViewBag.MinhaCorFavorita = "Verde";

            //return View(); mesma coisa que abaixo
            return View("About");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Exemplo de ViewBag Contact (camada controle - metodo ActionResult) ";

            return View();
        }
    }
}