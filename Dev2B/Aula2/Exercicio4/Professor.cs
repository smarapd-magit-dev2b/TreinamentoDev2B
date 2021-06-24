using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2.Exercicio4
{
    public class Professor
    {
        private string Nome { get; set; }
        private DateTime DataNascimento { get; set; }
        private string Endereco { get; set; }
        private string Telefone { get; set; }
        private string Email { get; set; }
        private string Nacionalidade { get; set; }
        private string Cidade { get; set; }
        private string Estado { get; set; }
        private string Cnh { get; set; }
        private DateTime DataAdmissao { get; set; }
        private string RegistroProfessor { get; set; }
        private decimal Salario { get; set; }
        private Disciplina Disciplina { get; set; }

        public Professor(string nome, DateTime dataNascimento, string endereco, string telefone, string email, string nacionalidade, string cidade, string estado, string cnh, DateTime dataAdmissao, string registroProfessor, decimal salario, Disciplina disciplina)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
            Nacionalidade = nacionalidade;
            Cidade = cidade;
            Estado = estado;
            Cnh = cnh;
            DataAdmissao = dataAdmissao;
            RegistroProfessor = registroProfessor;
            Salario = salario;
            Disciplina = new Disciplina();
        }

        public Professor()
        {
        }

        public void EscreverProfessor()
        {
            Console.WriteLine($"\nO nome é {Nome}.");
            Console.WriteLine($"A data de nascimento é {DataNascimento}.");
            Console.WriteLine($"O endereço é {Endereco}.");
            Console.WriteLine($"O telefone é {Telefone}.");
            Console.WriteLine($"O email é {Email}.");
            Console.WriteLine($"A nacionalidade é {Nacionalidade}.");
            Console.WriteLine($"A cidade é {Cidade}.");
            Console.WriteLine($"O estado é {Estado}.");
            Console.WriteLine($"A cnh é {Cnh}.");
            Console.WriteLine($"A data de admissao é {DataAdmissao}.");
            Console.WriteLine($"O registro do professor é {RegistroProfessor}.");
            Console.WriteLine($"O salario é {Salario}.");
            Disciplina.EscreverDisciplina();
        }
    }
}
