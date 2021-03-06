﻿using Protech_exercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace Protech_exercise.Controllers
{
    public class FormacaoController : Controller
    {
        public List<Formacao> Get()
        {
            Formacao _formacao= new Formacao();

            return _formacao.ListarFormacoes();
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
        public ActionResult Create(string curso, string status, string  dataConclusao)
        {
            RootObject _colaborador = new RootObject();
            Formacao formacao = new Formacao(curso, status, dataConclusao);
            _colaborador.InserirFormacao(formacao);
            return View();
        }
    }
}
