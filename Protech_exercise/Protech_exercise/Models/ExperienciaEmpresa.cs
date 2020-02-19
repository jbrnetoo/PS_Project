using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Protech_exercise.Models
{
    public class ExperienciaEmpresa
    {
        public string Empresa { get; set; }
        public string Cargo { get; set; }
        public string DataInicio { get; set; }
        public string DataFim { get; set; }
        public string DetalheExperiencia { get; set; }

        public ExperienciaEmpresa(string empresa, string cargo, string dataInicio, string dataFim, string detalheExperiencia)
        {
            this.Empresa = empresa;
            this.Cargo = cargo;
            this.DataInicio = dataInicio;
            this.DataFim = dataFim;
            this.DetalheExperiencia = detalheExperiencia;
        }
    }
}