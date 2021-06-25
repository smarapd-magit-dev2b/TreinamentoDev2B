using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2.Exercicio4Classes
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
            Console.WriteLine();
            Console.WriteLine("----- Informações do PROFESSOR -----");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Data de nascimento: {DataNascimento}");
            Console.WriteLine($"Endereço: {Endereco}");
            Console.WriteLine($"Telefone: {Telefone}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Nacionalidade: {Nacionalidade}");
            Console.WriteLine($"Cidade: {Cidade}");
            Console.WriteLine($"Estado: {Estado}");
            Console.WriteLine($"Cnh: {Cnh}");
            Console.WriteLine($"Data de admissao: {DataAdmissao}");
            Console.WriteLine($"Registro do professor: {RegistroProfessor}");
            Console.WriteLine($"Salario: {Salario}");
            Disciplina.EscreverDisciplina();
        }
    }
}
