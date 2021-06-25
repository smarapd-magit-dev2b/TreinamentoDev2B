using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2.Exercicio4Classes
{
    public class Disciplina
    {
        public string Nome { get; set; }
        public string Cid { get; set; }
        public string Curso { get; set; }
        public DateTime DataInclusao { get; set; }

        public Disciplina()
        {

        }

        public void EscreverDisciplina()
        {
            Console.WriteLine();
            Console.WriteLine("----- Informações do DISCIPLINA -----");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Cid: {Cid}");
            Console.WriteLine($"Curso: {Curso}");
            Console.WriteLine($"Data de inclusão: {DataInclusao}");
        }
    }
}
