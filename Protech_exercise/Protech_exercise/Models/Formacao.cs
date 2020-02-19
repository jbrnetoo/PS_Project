using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Protech_exercise.Models
{
    public class Formacao
    {
        public string Curso { get; set; }
        public string Status { get; set; }
        public string DataConclusao { get; set; }

        public Formacao(string curso, string status, string dataConclusao)
        {
            this.Curso = curso;
            this.Status = status;
            this.DataConclusao = dataConclusao;
        }
    }
}