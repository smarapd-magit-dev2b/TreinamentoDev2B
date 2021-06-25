using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2.Exercicio4Classes
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
            Console.Clear();
            Console.WriteLine("----- Informações do ALUNO -----");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Data de nascimento: {DataNascimento}");
            Console.WriteLine($"Endereço: {Endereco}");
            Console.WriteLine($"Telefone: {Telefone}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Nacionalidade: {Nacionalidade}");
            Console.WriteLine($"Cidade: {Cidade}");
            Console.WriteLine($"Estado: {Estado}");
            Console.WriteLine($"Data de matricula: {DataMatricula}");
            Console.WriteLine($"Registro do aluno: {RegistroAluno}");
            Professor.EscreverProfessor();
        }
    }
}
