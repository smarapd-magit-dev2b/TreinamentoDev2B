using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2.Exercicio4
{
    class Disciplina
    {
        public string Nome { get; set; }
        public string Cid { get; set; }
        public string Curso { get; set; }
        public DateTime DataInclusao { get; set; }

        public Disciplina(string nome, string cid, string curso, DateTime datainclusao)
        {
            Nome = nome;
            Cid = cid;
            Curso = curso;
            DataInclusao = datainclusao;
        }

        public Disciplina()
        {
        }
    }
}
