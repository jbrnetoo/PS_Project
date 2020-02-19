using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace Protech_exercise.Models
{
    public class RootObject
    {
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public List<Formacao> Formacao { get; set; }
        public int ExperienciaTotal { get; set; }
        public List<Experiencia> Experiencia { get; set; }
        public List<ExperienciaEmpresa> ExperienciaEmpresas { get; set; }

        public RootObject() { }

        //Aqui foram apenas testes que fiz
        #region DEPRECATED
        //public RootObject(string nome, string dataNascimento, int experienciaTotal)
        //{
        //    this.Nome = nome;
        //    this.DataNascimento = dataNascimento;
        //    this.ExperienciaTotal = experienciaTotal;
        //    this.Experiencia =
        //    new List<Experiencia>
        //    {
        //        new Experiencia(tecnologia: "Flutter", tempoExperiencia: 6, detalheExp: "Criação da Startup LiZON"),
        //        new Experiencia(tecnologia: "Python", tempoExperiencia: 6, detalheExp: "Tangram Project"),
        //        new Experiencia(tecnologia: "Unreal Engine", tempoExperiencia: 4, detalheExp: "Speech Recognition Game")
        //    };
        //}
        #endregion

        public RootObject ApresentarColaborador()
        {
            var path = HostingEnvironment.MapPath(@"~/App_Data/getResponse.json");
            var json = File.ReadAllText(path);
            var colaborador = JsonConvert.DeserializeObject<RootObject>(json);

            return colaborador;
        }

        public bool ReescreverArquivo(RootObject root)
        {
            try
            {
                var path = HostingEnvironment.MapPath(@"~/App_Data/getResponse.json");
                var json = JsonConvert.SerializeObject(root, Formatting.Indented);
                File.WriteAllText(path, json);
            }
            catch
            {
                return false;
            }

            return true;
        }

        #region CRUD

        public List<Formacao> InserirFormacao(Formacao formacao)
        {
            var colaborador = this.ApresentarColaborador();
            List<Formacao> listaFormacao = colaborador.Formacao;
            listaFormacao.Add(formacao);

            ReescreverArquivo(colaborador);
            return listaFormacao;
        }

        public List<Formacao> AtualizarFormacao(string curso, Formacao formacao)
        {
            var colaborador = this.ApresentarColaborador();
            List<Formacao> listaFormacao = colaborador.Formacao;
            if ((!string.IsNullOrWhiteSpace(curso) && formacao != null) && (listaFormacao != null && listaFormacao.Count > 0))
            {
                listaFormacao[listaFormacao.IndexOf(listaFormacao.FirstOrDefault(f => f.Curso.Equals(curso)))] = formacao;
                ReescreverArquivo(colaborador);
            }
            return listaFormacao;
        }

        public List<Formacao> DeletarFormacao(string curso)
        {
            var colaborador = this.ApresentarColaborador();
            List<Formacao> listaFormacao = colaborador.Formacao;
            if (!string.IsNullOrWhiteSpace(curso) && (listaFormacao != null && listaFormacao.Count > 0))
            {
                listaFormacao.RemoveAt(listaFormacao.IndexOf(listaFormacao.FirstOrDefault(f => f.Curso.Equals(curso))));
                ReescreverArquivo(colaborador);
            }
            return listaFormacao;
        }

        #endregion
    }
}