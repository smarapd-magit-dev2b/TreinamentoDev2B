using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02.Classes
{
    public class Aluno
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Nacionalidade { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public DateTime DataMatricula { get; set; }
        public string RegistroAluno { get; set; }
        public Professor Professor { get; set; }

        public Aluno()
        {
            Professor = new Professor();
        }

        public void EscreverAluno()
        {
            Console.WriteLine($"\nO nome é {Nome}.");
            Console.WriteLine($"A data de nascimento é {DataNascimento}.");
            Console.WriteLine($"O endereço é {Endereco}.");
            Console.WriteLine($"O telefone é {Telefone}.");
            Console.WriteLine($"O email é {Email}.");
            Console.WriteLine($"A nacionalidade é {Nacionalidade}.");
            Console.WriteLine($"A cidade é {Cidade}.");
            Console.WriteLine($"O estado é {Estado}.");
            Console.WriteLine($"A data de matricula é {DataMatricula}.");
            Console.WriteLine($"O registro do aluno é {RegistroAluno}.");
            Professor.EscreverProfessor();

        }
    }
}
