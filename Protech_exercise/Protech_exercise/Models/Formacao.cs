using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace Protech_exercise.Models
{
    public class Formacao
    {
        public string Curso { get; set; }
        public string Status { get; set; }
        public string DataConclusao { get; set; }

        public Formacao()
        {

        }

        public Formacao(string curso, string status, string dataConclusao)
        {
            this.Curso = curso;
            this.Status = status;
            this.DataConclusao = dataConclusao;
        }

        public List<Formacao> ListarFormacoes()
        {
            var path = HostingEnvironment.MapPath(@"~/App_Data/getResponse.json");
            var json = File.ReadAllText(path);
            var colaborador = JsonConvert.DeserializeObject<RootObject>(json);

            return colaborador.Formacao;
        }
    }
}