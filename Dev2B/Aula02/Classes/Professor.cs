using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02.Classes
{
    public class Professor
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Nacionalidade { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cnh { get; set; }
        public DateTime DataAdmissao { get; set; }
        public string RegistroProfessor { get; set; }
        public decimal Salario { get; set; }
        public Disciplina Disciplina { get; set; }

        public Professor()
        {
            Disciplina = new Disciplina();
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
