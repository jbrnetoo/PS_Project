using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace Protech_exercise.Models
{
    public class Experiencia
    {
        public string Tecnologia { get; set; }
        public int TempoExperiencia { get; set; }
        public string DetalheExperiencia { get; set; }

        public Experiencia()
        {

        }

        public Experiencia(string tecnologia, int tempoExperiencia, string detalheExp)
        {
            this.Tecnologia = tecnologia;
            this.TempoExperiencia = tempoExperiencia;
            this.DetalheExperiencia = detalheExp;
        }

        public List<Experiencia> ListarExperiencias()
        {
            var path = HostingEnvironment.MapPath(@"~/App_Data/getResponse.json");
            var json = File.ReadAllText(path);
            var colaborador = JsonConvert.DeserializeObject<RootObject>(json);

            return colaborador.Experiencia;
        }
    }
}