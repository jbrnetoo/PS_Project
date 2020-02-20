using Protech_exercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace Protech_exercise.Controllers
{
    public class ExperienciaController : Controller
    {
        public List<Experiencia> Get()
        {
            Experiencia _experiencia = new Experiencia();

            return _experiencia.ListarExperiencias();
        }

        public ActionResult Index()
        {
            return View(this.Get());
        }

        public ActionResult Create()
        {
            return View();
        }

        [System.Web.Mvc.HttpPost]
        public ActionResult Create(string tecnologia, int tempoExperiencia, string detalheExp)
        {
            RootObject _colaborador = new RootObject();
            Experiencia experiencia = new Experiencia(tecnologia, tempoExperiencia, detalheExp);
            _colaborador.InserirExperiencia(experiencia);
            return View();
        }
    }
}
