using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class TesteController : Controller
    {
        // GET: Teste
        public string nome()
        {
            return "Luis Fellipe";
        }
        public ActionResult Pagina()
        {

            return View();
        }
    }
}