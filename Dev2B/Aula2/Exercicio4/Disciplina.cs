using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2.Exercicio4
{
    public class Disciplina
    {
        private string Nome { get; set; }
        private string Cid { get; set; }
        private string Curso { get; set; }
        private DateTime DataInclusao { get; set; }

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

        public void EscreverDisciplina()
        {
            Console.WriteLine($"\nO nome é {Nome}.");
            Console.WriteLine($"O cid é {Cid}.");
            Console.WriteLine($"O curso é {Curso}.");
            Console.WriteLine($"A data é {DataInclusao}.");
        }
    }
}
