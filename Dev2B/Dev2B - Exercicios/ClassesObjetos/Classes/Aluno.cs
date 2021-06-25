using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2.Classes
{
    public class Aluno
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public string Nacionalidade { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
        public DateTime DataMatricula { get; set; }
        public string RA { get; set; }
        public Professor Professor { get; set; }



        public Aluno(string nome)
        {
            Nome = nome;
            Professor = new Professor();

            DateTime DateNascimento = new DateTime(2005, 08, 12);
            DataNascimento = DateNascimento;

            DateTime DateMatricula = new DateTime(2010, 02, 10);
            DataMatricula = DateMatricula;

        }

        public void getDados()
        {
            Console.WriteLine($"Dados do aluno {Nome}, assiste aulas de {Professor.Disciplina.Curso}, mestradas pelo Professor {Professor.Nome}.\n");
            Console.WriteLine($"{Nome} nasceu em {DataNascimento}, na cidade de {Cidade} no estado de {Estado}, e reside na Rua {Endereco}.\n");
            Console.WriteLine($"Documentos de {Nome}.\n");
            Console.WriteLine($">{Email}");
            Console.WriteLine($">{Nacionalidade}");
            Console.WriteLine($">{RA}");
            Console.WriteLine($">{Telefone}");
        }
    }
}
