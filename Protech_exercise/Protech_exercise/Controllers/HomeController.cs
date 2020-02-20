using Protech_exercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Protech_exercise.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View(this.Get());
        }

        public RootObject Get()
        {
            RootObject _colaborador = new RootObject();

            return _colaborador.ApresentarColaborador();
        }
    }
}
