using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2.Exercicio4
{
    public class Aluno
    {
        private string Nome { get; set; }
        private DateTime DataNascimento { get; set; }
        private string Endereco { get; set; }
        private string Telefone { get; set; }
        private string Email { get; set; }
        private string Nacionalidade { get; set; }
        private string Cidade { get; set; }
        private string Estado { get; set; }
        private DateTime DataMatricula { get; set; }
        private string RegistroAluno { get; set; }
        private Professor Professor { get; set; }

        public Aluno(string nome, DateTime dataNascimento, string endereco, string telefone, string email, string nacionalidade, string cidade, string estado, DateTime dataMatricula, string registroAluno, Professor professor)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
            Nacionalidade = nacionalidade;
            Cidade = cidade;
            Estado = estado;
            DataMatricula = dataMatricula;
            RegistroAluno = registroAluno;
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
