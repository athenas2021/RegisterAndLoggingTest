using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegisterAndLogginTest.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Message()
        {

            return View("Message");
            //return "Esta mensagem é um retorno do metodo Message dentro da classe ProductsControler";
        }

        public ActionResult Welcome(string nome, int numeroSecreto=13)
        {
            ViewBag.param1 = nome;
            ViewBag.param2 = numeroSecreto;
            return View();
           //return "Metodo Welcome da classe ProductsController" + nome + " / Numero secreto:  " + numeroSecreto;
        }
    }
}