using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Protech_exercise.Models
{
    public class Experiencia
    {
        public string Tecnologia { get; set; }
        public int TempoExperiencia { get; set; }
        public string DetalheExperiencia { get; set; }

        public Experiencia(string tecnologia, int tempoExperiencia, string detalheExp)
        {
            this.Tecnologia = tecnologia;
            this.TempoExperiencia = tempoExperiencia;
            this.DetalheExperiencia = detalheExp;
        }
    }
}