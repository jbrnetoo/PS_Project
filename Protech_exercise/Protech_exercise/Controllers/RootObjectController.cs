using Protech_exercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Protech_exercise.Controllers
{
    public class RootObjectController : ApiController
    {
        public RootObject Get()
        {
            RootObject _colaborador = new RootObject();

            return _colaborador.ApresentarColaborador();
        }

        [HttpPost]
        public List<Formacao> PostFormacao(string curso, string status, string dataConclusao)
        {
            RootObject _colaborador = new RootObject();

            Formacao formacao = new Formacao(curso, status, dataConclusao);
            return _colaborador.InserirFormacao(formacao);
        }

        [HttpPut]
        public void PutFormacao(string curso, string status, string dataConclusao)
        {
            RootObject _colaborador = new RootObject();

            Formacao formacao = new Formacao(curso, status, dataConclusao);
            _colaborador.AtualizarFormacao(curso, formacao);
        }

        [HttpDelete]
        public void DeleteFormacao(string curso)
        {
            RootObject _colaborador = new RootObject();

            _colaborador.DeletarFormacao(curso);
        }
    }
}
